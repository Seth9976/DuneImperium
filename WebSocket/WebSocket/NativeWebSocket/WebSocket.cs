using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Net.WebSockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace NativeWebSocket
{
	// Token: 0x0200000C RID: 12
	public class WebSocket : Object
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000346C File Offset: 0x0000166C
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocket()
		{
			Il2CppClassPointerStore<WebSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("WebSocket.dll", "NativeWebSocket", "WebSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket>.NativeClassPtr);
			WebSocket.NativeFieldInfoPtr_OnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "OnOpen");
			WebSocket.NativeFieldInfoPtr_OnMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "OnMessage");
			WebSocket.NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "OnError");
			WebSocket.NativeFieldInfoPtr_OnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "OnClose");
			WebSocket.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "uri");
			WebSocket.NativeFieldInfoPtr_m_Socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "m_Socket");
			WebSocket.NativeFieldInfoPtr_hasConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "hasConnected");
			WebSocket.NativeFieldInfoPtr_disconnectRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "disconnectRequested");
			WebSocket.NativeFieldInfoPtr_m_TokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "m_TokenSource");
			WebSocket.NativeFieldInfoPtr_m_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "m_CancellationToken");
			WebSocket.NativeFieldInfoPtr_pendingMessagesToSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "pendingMessagesToSend");
			WebSocket.NativeMethodInfoPtr_add_OnOpen_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663338);
			WebSocket.NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663339);
			WebSocket.NativeMethodInfoPtr_add_OnMessage_Public_add_Void_Action_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663340);
			WebSocket.NativeMethodInfoPtr_remove_OnMessage_Public_rem_Void_Action_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663341);
			WebSocket.NativeMethodInfoPtr_add_OnError_Public_add_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663342);
			WebSocket.NativeMethodInfoPtr_remove_OnError_Public_rem_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663343);
			WebSocket.NativeMethodInfoPtr_add_OnClose_Public_add_Void_Action_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663344);
			WebSocket.NativeMethodInfoPtr_remove_OnClose_Public_rem_Void_Action_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663345);
			WebSocket.NativeMethodInfoPtr__ctor_Public_Void_String_Nullable_1_TimeSpan_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663346);
			WebSocket.NativeMethodInfoPtr_Connect_Public_Task_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663347);
			WebSocket.NativeMethodInfoPtr_RunConnection_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663348);
			WebSocket.NativeMethodInfoPtr_get_State_Public_get_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663349);
			WebSocket.NativeMethodInfoPtr_Send_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663350);
			WebSocket.NativeMethodInfoPtr_SendText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663351);
			WebSocket.NativeMethodInfoPtr_SendMessages_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663352);
			WebSocket.NativeMethodInfoPtr_ReceiveMessages_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663353);
			WebSocket.NativeMethodInfoPtr_Close_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100663354);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000036CC File Offset: 0x000018CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1262903, RefRangeEnd = 1262906, XrefRangeStart = 1262899, XrefRangeEnd = 1262903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnOpen(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_add_OnOpen_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003710 File Offset: 0x00001910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262910, RefRangeEnd = 1262912, XrefRangeStart = 1262906, XrefRangeEnd = 1262910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnOpen(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003754 File Offset: 0x00001954
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1262917, RefRangeEnd = 1262920, XrefRangeStart = 1262912, XrefRangeEnd = 1262917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnMessage(Action<Il2CppStructArray<byte>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_add_OnMessage_Public_add_Void_Action_1_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003798 File Offset: 0x00001998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262925, RefRangeEnd = 1262927, XrefRangeStart = 1262920, XrefRangeEnd = 1262925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnMessage(Action<Il2CppStructArray<byte>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_remove_OnMessage_Public_rem_Void_Action_1_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000037DC File Offset: 0x000019DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262932, RefRangeEnd = 1262934, XrefRangeStart = 1262927, XrefRangeEnd = 1262932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnError(Action<Exception> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_add_OnError_Public_add_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003820 File Offset: 0x00001A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1262939, RefRangeEnd = 1262940, XrefRangeStart = 1262934, XrefRangeEnd = 1262939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnError(Action<Exception> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_remove_OnError_Public_rem_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003864 File Offset: 0x00001A64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1262945, RefRangeEnd = 1262948, XrefRangeStart = 1262940, XrefRangeEnd = 1262945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnClose(Action<WebSocketCloseCode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_add_OnClose_Public_add_Void_Action_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000038A8 File Offset: 0x00001AA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262953, RefRangeEnd = 1262955, XrefRangeStart = 1262948, XrefRangeEnd = 1262953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnClose(Action<WebSocketCloseCode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_remove_OnClose_Public_rem_Void_Action_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000038EC File Offset: 0x00001AEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1263026, RefRangeEnd = 1263029, XrefRangeStart = 1262955, XrefRangeEnd = 1263026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocket(string url, Nullable<TimeSpan> keepAliveInterval = null, Dictionary<string, string> headers = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keepAliveInterval));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr__ctor_Public_Void_String_Nullable_1_TimeSpan_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003960 File Offset: 0x00001B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1263043, RefRangeEnd = 1263045, XrefRangeStart = 1263029, XrefRangeEnd = 1263043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebSocketCloseCode> Connect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_Connect_Public_Task_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketCloseCode>>(intPtr3) : null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000039A0 File Offset: 0x00001BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263045, XrefRangeEnd = 1263055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task RunConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_RunConnection_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000039E0 File Offset: 0x00001BE0
		public unsafe WebSocketState State
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1263055, RefRangeEnd = 1263059, XrefRangeStart = 1263055, XrefRangeEnd = 1263055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_get_State_Public_get_WebSocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003A1C File Offset: 0x00001C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263059, XrefRangeEnd = 1263065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send(Il2CppStructArray<byte> bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_Send_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003A60 File Offset: 0x00001C60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1263072, RefRangeEnd = 1263076, XrefRangeStart = 1263065, XrefRangeEnd = 1263072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendText(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_SendText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003AA4 File Offset: 0x00001CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263076, XrefRangeEnd = 1263086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SendMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_SendMessages_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003AE4 File Offset: 0x00001CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263086, XrefRangeEnd = 1263096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReceiveMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_ReceiveMessages_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003B24 File Offset: 0x00001D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1263106, RefRangeEnd = 1263108, XrefRangeStart = 1263096, XrefRangeEnd = 1263106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_Close_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002176 File Offset: 0x00000376
		public WebSocket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003B64 File Offset: 0x00001D64
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000217F File Offset: 0x0000037F
		public unsafe Action OnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003B94 File Offset: 0x00001D94
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000219E File Offset: 0x0000039E
		public unsafe Action<Il2CppStructArray<byte>> OnMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStructArray<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003BC4 File Offset: 0x00001DC4
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000021BD File Offset: 0x000003BD
		public unsafe Action<Exception> OnError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003BF4 File Offset: 0x00001DF4
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000021DC File Offset: 0x000003DC
		public unsafe Action<WebSocketCloseCode> OnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<WebSocketCloseCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_OnClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003C24 File Offset: 0x00001E24
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000021FB File Offset: 0x000003FB
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003C54 File Offset: 0x00001E54
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000221A File Offset: 0x0000041A
		public unsafe ClientWebSocket m_Socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_m_Socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientWebSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_m_Socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003C84 File Offset: 0x00001E84
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002239 File Offset: 0x00000439
		public unsafe bool hasConnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_hasConnected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_hasConnected)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003CAC File Offset: 0x00001EAC
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002254 File Offset: 0x00000454
		public unsafe bool disconnectRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_disconnectRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_disconnectRequested)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003CD4 File Offset: 0x00001ED4
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000226F File Offset: 0x0000046F
		public unsafe CancellationTokenSource m_TokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_m_TokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_m_TokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003D04 File Offset: 0x00001F04
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000228E File Offset: 0x0000048E
		public CancellationToken m_CancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_m_CancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_m_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003D34 File Offset: 0x00001F34
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000022BC File Offset: 0x000004BC
		public unsafe ConcurrentQueue<ValueTuple<WebSocketMessageType, Il2CppStructArray<byte>>> pendingMessagesToSend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_pendingMessagesToSend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<ValueTuple<WebSocketMessageType, Il2CppStructArray<byte>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.NativeFieldInfoPtr_pendingMessagesToSend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_OnOpen;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_OnMessage;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_OnError;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_OnClose;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_Socket;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_hasConnected;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_disconnectRequested;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_TokenSource;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_m_CancellationToken;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_pendingMessagesToSend;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOpen_Public_add_Void_Action_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_Action_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMessage_Public_add_Void_Action_1_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMessage_Public_rem_Void_Action_1_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_add_OnError_Public_add_Void_Action_1_Exception_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnError_Public_rem_Void_Action_1_Exception_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClose_Public_add_Void_Action_1_WebSocketCloseCode_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClose_Public_rem_Void_Action_1_WebSocketCloseCode_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Nullable_1_TimeSpan_Dictionary_2_String_String_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Task_1_WebSocketCloseCode_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_RunConnection_Public_Task_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_WebSocketState_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_SendText_Public_Void_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Private_Task_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessages_Private_Task_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Task_0;

		// Token: 0x02000014 RID: 20
		[ObfuscatedName("NativeWebSocket.WebSocket+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x0600009D RID: 157 RVA: 0x00004860 File Offset: 0x00002A60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr);
				WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, "error");
				WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, "status");
				WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, 100663355);
				WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, 100663356);
				WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, 100663357);
				WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, 100663358);
				WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr, 100663359);
			}

			// Token: 0x0600009E RID: 158 RVA: 0x0000492C File Offset: 0x00002B2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00004968 File Offset: 0x00002B68
			[CallerCount(0)]
			public unsafe void _Connect_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x0000499C File Offset: 0x00002B9C
			[CallerCount(0)]
			public unsafe void _Connect_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x000049D0 File Offset: 0x00002BD0
			[CallerCount(0)]
			public unsafe void _Connect_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00004A04 File Offset: 0x00002C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262507, XrefRangeEnd = 1262510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Connect_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.__c__DisplayClass20_0.NativeMethodInfoPtr__Connect_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x000024EB File Offset: 0x000006EB
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004A38 File Offset: 0x00002C38
			// (set) Token: 0x060000A5 RID: 165 RVA: 0x000024F4 File Offset: 0x000006F4
			public unsafe WebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004A68 File Offset: 0x00002C68
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002513 File Offset: 0x00000713
			public unsafe Exception error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr_error);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr_error), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004A98 File Offset: 0x00002C98
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002532 File Offset: 0x00000732
			public Nullable<WebSocketCloseCode> status
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr_status);
					return new Nullable<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass20_0.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeFieldInfoPtr_status;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeMethodInfoPtr__Connect_b__2_Internal_Void_0;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr__Connect_b__0_Internal_Void_0;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeMethodInfoPtr__Connect_b__1_Internal_Void_0;

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeMethodInfoPtr__Connect_b__3_Internal_Void_0;
		}

		// Token: 0x02000015 RID: 21
		[ObfuscatedName("NativeWebSocket.WebSocket+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x060000AA RID: 170 RVA: 0x00004AC8 File Offset: 0x00002CC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr);
				WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr, "error");
				WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr, "status");
				WebSocket.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr, 100663360);
				WebSocket.__c__DisplayClass21_0.NativeMethodInfoPtr__RunConnection_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr, 100663361);
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00004B58 File Offset: 0x00002D58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00004B94 File Offset: 0x00002D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262510, XrefRangeEnd = 1262513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunConnection_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.__c__DisplayClass21_0.NativeMethodInfoPtr__RunConnection_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00002560 File Offset: 0x00000760
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00004BC8 File Offset: 0x00002DC8
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00002569 File Offset: 0x00000769
			public unsafe Exception error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr_error);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr_error), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004BF8 File Offset: 0x00002DF8
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002588 File Offset: 0x00000788
			public unsafe WebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004C28 File Offset: 0x00002E28
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x000025A7 File Offset: 0x000007A7
			public Nullable<WebSocketCloseCode> status
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr_status);
					return new Nullable<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket.__c__DisplayClass21_0.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000079 RID: 121
			private static readonly IntPtr NativeFieldInfoPtr_status;

			// Token: 0x0400007A RID: 122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400007B RID: 123
			private static readonly IntPtr NativeMethodInfoPtr__RunConnection_b__0_Internal_Void_0;
		}

		// Token: 0x02000016 RID: 22
		[ObfuscatedName("NativeWebSocket.WebSocket+<Close>d__28")]
		public sealed class _Close_d__28 : ValueType
		{
			// Token: 0x060000B4 RID: 180 RVA: 0x00004C58 File Offset: 0x00002E58
			// Note: this type is marked as 'beforefieldinit'.
			static _Close_d__28()
			{
				Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "<Close>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr);
				WebSocket._Close_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr, "<>1__state");
				WebSocket._Close_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr, "<>t__builder");
				WebSocket._Close_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr, "<>4__this");
				WebSocket._Close_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr, "<>u__1");
				WebSocket._Close_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr, 100663362);
				WebSocket._Close_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr, 100663363);
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x00004CFC File Offset: 0x00002EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262513, XrefRangeEnd = 1262533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._Close_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00004D34 File Offset: 0x00002F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262533, XrefRangeEnd = 1262537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._Close_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x000025D5 File Offset: 0x000007D5
			public _Close_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x000025DE File Offset: 0x000007DE
			public _Close_d__28()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket._Close_d__28>.NativeClassPtr))
			{
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004D7C File Offset: 0x00002F7C
			// (set) Token: 0x060000BA RID: 186 RVA: 0x000025F0 File Offset: 0x000007F0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000BB RID: 187 RVA: 0x00004DA4 File Offset: 0x00002FA4
			// (set) Token: 0x060000BC RID: 188 RVA: 0x0000260B File Offset: 0x0000080B
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000BD RID: 189 RVA: 0x00004DD4 File Offset: 0x00002FD4
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00002639 File Offset: 0x00000839
			public unsafe WebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000BF RID: 191 RVA: 0x00004E04 File Offset: 0x00003004
			// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002658 File Offset: 0x00000858
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Close_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400007C RID: 124
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400007D RID: 125
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400007E RID: 126
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400007F RID: 127
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000081 RID: 129
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000017 RID: 23
		[ObfuscatedName("NativeWebSocket.WebSocket+<Connect>d__20")]
		public sealed class _Connect_d__20 : ValueType
		{
			// Token: 0x060000C1 RID: 193 RVA: 0x00004E34 File Offset: 0x00003034
			// Note: this type is marked as 'beforefieldinit'.
			static _Connect_d__20()
			{
				Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "<Connect>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr);
				WebSocket._Connect_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, "<>1__state");
				WebSocket._Connect_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, "<>t__builder");
				WebSocket._Connect_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, "<>4__this");
				WebSocket._Connect_d__20.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, "<>8__1");
				WebSocket._Connect_d__20.NativeFieldInfoPtr__connectSource_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, "<connectSource>5__2");
				WebSocket._Connect_d__20.NativeFieldInfoPtr__connectToken_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, "<connectToken>5__3");
				WebSocket._Connect_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, "<>u__1");
				WebSocket._Connect_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, 100663364);
				WebSocket._Connect_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr, 100663365);
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00004F14 File Offset: 0x00003114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262537, XrefRangeEnd = 1262672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._Connect_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00004F4C File Offset: 0x0000314C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262672, XrefRangeEnd = 1262678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._Connect_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00002686 File Offset: 0x00000886
			public _Connect_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x0000268F File Offset: 0x0000088F
			public _Connect_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket._Connect_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x00004F94 File Offset: 0x00003194
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x000026A1 File Offset: 0x000008A1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004FBC File Offset: 0x000031BC
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x000026BC File Offset: 0x000008BC
			public AsyncTaskMethodBuilder<WebSocketCloseCode> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000CA RID: 202 RVA: 0x00004FEC File Offset: 0x000031EC
			// (set) Token: 0x060000CB RID: 203 RVA: 0x000026EA File Offset: 0x000008EA
			public unsafe WebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000CC RID: 204 RVA: 0x0000501C File Offset: 0x0000321C
			// (set) Token: 0x060000CD RID: 205 RVA: 0x00002709 File Offset: 0x00000909
			public unsafe WebSocket.__c__DisplayClass20_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket.__c__DisplayClass20_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000CE RID: 206 RVA: 0x0000504C File Offset: 0x0000324C
			// (set) Token: 0x060000CF RID: 207 RVA: 0x00002728 File Offset: 0x00000928
			public unsafe CancellationTokenSource _connectSource_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr__connectSource_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr__connectSource_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000507C File Offset: 0x0000327C
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002747 File Offset: 0x00000947
			public unsafe CancellationTokenSource _connectToken_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr__connectToken_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr__connectToken_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x000050AC File Offset: 0x000032AC
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002766 File Offset: 0x00000966
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._Connect_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000082 RID: 130
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000083 RID: 131
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000084 RID: 132
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000085 RID: 133
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04000086 RID: 134
			private static readonly IntPtr NativeFieldInfoPtr__connectSource_5__2;

			// Token: 0x04000087 RID: 135
			private static readonly IntPtr NativeFieldInfoPtr__connectToken_5__3;

			// Token: 0x04000088 RID: 136
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000089 RID: 137
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400008A RID: 138
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000018 RID: 24
		[ObfuscatedName("NativeWebSocket.WebSocket+<ReceiveMessages>d__27")]
		public sealed class _ReceiveMessages_d__27 : ValueType
		{
			// Token: 0x060000D4 RID: 212 RVA: 0x000050DC File Offset: 0x000032DC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReceiveMessages_d__27()
			{
				Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "<ReceiveMessages>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr);
				WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, "<>1__state");
				WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, "<>t__builder");
				WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, "<>4__this");
				WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, "<buffer>5__2");
				WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr__ms_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, "<ms>5__3");
				WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, "<>u__1");
				WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, "<>u__2");
				WebSocket._ReceiveMessages_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, 100663366);
				WebSocket._ReceiveMessages_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr, 100663367);
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x000051BC File Offset: 0x000033BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262678, XrefRangeEnd = 1262730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._ReceiveMessages_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x000051F4 File Offset: 0x000033F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262730, XrefRangeEnd = 1262734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._ReceiveMessages_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00002794 File Offset: 0x00000994
			public _ReceiveMessages_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x0000279D File Offset: 0x0000099D
			public _ReceiveMessages_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket._ReceiveMessages_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000523C File Offset: 0x0000343C
			// (set) Token: 0x060000DA RID: 218 RVA: 0x000027AF File Offset: 0x000009AF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000DB RID: 219 RVA: 0x00005264 File Offset: 0x00003464
			// (set) Token: 0x060000DC RID: 220 RVA: 0x000027CA File Offset: 0x000009CA
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000DD RID: 221 RVA: 0x00005294 File Offset: 0x00003494
			// (set) Token: 0x060000DE RID: 222 RVA: 0x000027F8 File Offset: 0x000009F8
			public unsafe WebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000DF RID: 223 RVA: 0x000052C4 File Offset: 0x000034C4
			// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002817 File Offset: 0x00000A17
			public ArraySegment<byte> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr__buffer_5__2);
					return new ArraySegment<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArraySegment<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr__buffer_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArraySegment<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x000052F4 File Offset: 0x000034F4
			// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002845 File Offset: 0x00000A45
			public unsafe MemoryStream _ms_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr__ms_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr__ms_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005324 File Offset: 0x00003524
			// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002864 File Offset: 0x00000A64
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x00005354 File Offset: 0x00003554
			// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002892 File Offset: 0x00000A92
			public ConfiguredTaskAwaitable<WebSocketReceiveResult>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<WebSocketReceiveResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebSocketReceiveResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._ReceiveMessages_d__27.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebSocketReceiveResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400008B RID: 139
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400008C RID: 140
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400008D RID: 141
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400008E RID: 142
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x0400008F RID: 143
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__3;

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000093 RID: 147
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000019 RID: 25
		[ObfuscatedName("NativeWebSocket.WebSocket+<RunConnection>d__21")]
		public sealed class _RunConnection_d__21 : ValueType
		{
			// Token: 0x060000E7 RID: 231 RVA: 0x00005384 File Offset: 0x00003584
			// Note: this type is marked as 'beforefieldinit'.
			static _RunConnection_d__21()
			{
				Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "<RunConnection>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr);
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>1__state");
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>t__builder");
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>4__this");
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>8__1");
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>7__wrap1");
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>7__wrap2");
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>u__1");
				WebSocket._RunConnection_d__21.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, "<>u__2");
				WebSocket._RunConnection_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, 100663368);
				WebSocket._RunConnection_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr, 100663369);
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00005478 File Offset: 0x00003678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262734, XrefRangeEnd = 1262860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._RunConnection_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x000054B0 File Offset: 0x000036B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262860, XrefRangeEnd = 1262864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._RunConnection_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000EA RID: 234 RVA: 0x000028C0 File Offset: 0x00000AC0
			public _RunConnection_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000EB RID: 235 RVA: 0x000028C9 File Offset: 0x00000AC9
			public _RunConnection_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket._RunConnection_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000EC RID: 236 RVA: 0x000054F8 File Offset: 0x000036F8
			// (set) Token: 0x060000ED RID: 237 RVA: 0x000028DB File Offset: 0x00000ADB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000EE RID: 238 RVA: 0x00005520 File Offset: 0x00003720
			// (set) Token: 0x060000EF RID: 239 RVA: 0x000028F6 File Offset: 0x00000AF6
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005550 File Offset: 0x00003750
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002924 File Offset: 0x00000B24
			public unsafe WebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005580 File Offset: 0x00003780
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002943 File Offset: 0x00000B43
			public unsafe WebSocket.__c__DisplayClass21_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket.__c__DisplayClass21_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x000055B0 File Offset: 0x000037B0
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002962 File Offset: 0x00000B62
			public unsafe Object __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x000055E0 File Offset: 0x000037E0
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002981 File Offset: 0x00000B81
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005608 File Offset: 0x00003808
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000299C File Offset: 0x00000B9C
			public TaskAwaiter<Task> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Task>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Task>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Task>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000FA RID: 250 RVA: 0x00005638 File Offset: 0x00003838
			// (set) Token: 0x060000FB RID: 251 RVA: 0x000029CA File Offset: 0x00000BCA
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._RunConnection_d__21.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000094 RID: 148
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200001A RID: 26
		[ObfuscatedName("NativeWebSocket.WebSocket+<SendMessages>d__26")]
		public sealed class _SendMessages_d__26 : ValueType
		{
			// Token: 0x060000FC RID: 252 RVA: 0x00005668 File Offset: 0x00003868
			// Note: this type is marked as 'beforefieldinit'.
			static _SendMessages_d__26()
			{
				Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, "<SendMessages>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr);
				WebSocket._SendMessages_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, "<>1__state");
				WebSocket._SendMessages_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, "<>t__builder");
				WebSocket._SendMessages_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, "<>4__this");
				WebSocket._SendMessages_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, "<>u__1");
				WebSocket._SendMessages_d__26.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, "<buffer>5__2");
				WebSocket._SendMessages_d__26.NativeFieldInfoPtr__startSend_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, "<startSend>5__3");
				WebSocket._SendMessages_d__26.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, "<>u__2");
				WebSocket._SendMessages_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, 100663370);
				WebSocket._SendMessages_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr, 100663371);
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00005748 File Offset: 0x00003948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262864, XrefRangeEnd = 1262895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._SendMessages_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000FE RID: 254 RVA: 0x00005780 File Offset: 0x00003980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262895, XrefRangeEnd = 1262899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket._SendMessages_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x000029F8 File Offset: 0x00000BF8
			public _SendMessages_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00002A01 File Offset: 0x00000C01
			public _SendMessages_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket._SendMessages_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000101 RID: 257 RVA: 0x000057C8 File Offset: 0x000039C8
			// (set) Token: 0x06000102 RID: 258 RVA: 0x00002A13 File Offset: 0x00000C13
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000103 RID: 259 RVA: 0x000057F0 File Offset: 0x000039F0
			// (set) Token: 0x06000104 RID: 260 RVA: 0x00002A2E File Offset: 0x00000C2E
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000105 RID: 261 RVA: 0x00005820 File Offset: 0x00003A20
			// (set) Token: 0x06000106 RID: 262 RVA: 0x00002A5C File Offset: 0x00000C5C
			public unsafe WebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000107 RID: 263 RVA: 0x00005850 File Offset: 0x00003A50
			// (set) Token: 0x06000108 RID: 264 RVA: 0x00002A7B File Offset: 0x00000C7B
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000109 RID: 265 RVA: 0x00005880 File Offset: 0x00003A80
			// (set) Token: 0x0600010A RID: 266 RVA: 0x00002AA9 File Offset: 0x00000CA9
			public unsafe Il2CppStructArray<byte> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr__buffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr__buffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600010B RID: 267 RVA: 0x000058B0 File Offset: 0x00003AB0
			// (set) Token: 0x0600010C RID: 268 RVA: 0x00002AC8 File Offset: 0x00000CC8
			public unsafe DateTime _startSend_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr__startSend_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr__startSend_5__3)) = value;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600010D RID: 269 RVA: 0x000058D8 File Offset: 0x00003AD8
			// (set) Token: 0x0600010E RID: 270 RVA: 0x00002AE3 File Offset: 0x00000CE3
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocket._SendMessages_d__26.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeFieldInfoPtr__startSend_5__3;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
