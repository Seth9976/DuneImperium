using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using NativeWebSocket;

namespace platform.websocket
{
	// Token: 0x02000007 RID: 7
	public class DWDWebSocket<TMessage> : Object
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00004B88 File Offset: 0x00002D88
		// Note: this type is marked as 'beforefieldinit'.
		static DWDWebSocket()
		{
			Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("platform.dll", "platform.websocket", "DWDWebSocket`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMessage>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr);
			DWDWebSocket<TMessage>.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "socket");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr_socketClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "socketClosed");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "OnOpen");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "OnClose");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "OnError");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr_MessageQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "MessageQueue");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr__messageFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "_messageFactory");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "URL");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr__keepAliveTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "_keepAliveTimeout");
			DWDWebSocket<TMessage>.NativeFieldInfoPtr__CloseCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "<CloseCode>k__BackingField");
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_add_OnOpen_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663306);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663307);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_add_OnClose_Public_add_Void_EventHandler_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663308);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_remove_OnClose_Public_rem_Void_EventHandler_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663309);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_add_OnError_Public_add_Void_EventHandler_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663310);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_remove_OnError_Public_rem_Void_EventHandler_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663311);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_Il2CppStructArray_1_Byte_TMessage_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663312);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_PeekMessage_Public_Boolean_byref_TMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663313);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_GetPendingMessages_Public_Void_ICollection_1_TMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663314);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_Reconnect_Public_Task_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663315);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_get_ReadyState_Public_get_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663316);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_ConfigureSocket_Private_Void_WebSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663317);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663318);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_ReadyToPing_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663319);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_ConnectSocket_Public_Task_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663320);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_Connect_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663321);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663322);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleError_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663323);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleMessage_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663324);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_get_CloseCode_Public_get_Nullable_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663325);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_set_CloseCode_Private_set_Void_Nullable_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663326);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleClose_Private_Void_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663327);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_Write_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663328);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_CloseSocket_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663329);
			DWDWebSocket<TMessage>.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, 100663330);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004EB0 File Offset: 0x000030B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165569, RefRangeEnd = 1165570, XrefRangeStart = 1165565, XrefRangeEnd = 1165569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnOpen(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_add_OnOpen_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004EF4 File Offset: 0x000030F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165570, XrefRangeEnd = 1165574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnOpen(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004F38 File Offset: 0x00003138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165579, RefRangeEnd = 1165580, XrefRangeStart = 1165574, XrefRangeEnd = 1165579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnClose(EventHandler<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_add_OnClose_Public_add_Void_EventHandler_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004F7C File Offset: 0x0000317C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165580, XrefRangeEnd = 1165585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnClose(EventHandler<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_remove_OnClose_Public_rem_Void_EventHandler_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004FC0 File Offset: 0x000031C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165585, XrefRangeEnd = 1165590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnError(EventHandler<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_add_OnError_Public_add_Void_EventHandler_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005004 File Offset: 0x00003204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165590, XrefRangeEnd = 1165595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnError(EventHandler<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_remove_OnError_Public_rem_Void_EventHandler_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005048 File Offset: 0x00003248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165602, RefRangeEnd = 1165603, XrefRangeStart = 1165595, XrefRangeEnd = 1165602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDWebSocket(string url, Func<Il2CppStructArray<byte>, TMessage> messageFactory, Nullable<TimeSpan> keepAliveTimeout = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageFactory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keepAliveTimeout));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_Il2CppStructArray_1_Byte_TMessage_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000050BC File Offset: 0x000032BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165603, XrefRangeEnd = 1165608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PeekMessage(out TMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(TMessage).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref message;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_PeekMessage_Public_Boolean_byref_TMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(TMessage).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					message = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TMessage>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005148 File Offset: 0x00003348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165613, RefRangeEnd = 1165614, XrefRangeStart = 1165608, XrefRangeEnd = 1165613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPendingMessages(ICollection<TMessage> messages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_GetPendingMessages_Public_Void_ICollection_1_TMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000518C File Offset: 0x0000338C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165626, RefRangeEnd = 1165627, XrefRangeStart = 1165614, XrefRangeEnd = 1165626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebSocketCloseCode> Reconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_Reconnect_Public_Task_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketCloseCode>>(intPtr3) : null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000051CC File Offset: 0x000033CC
		public unsafe WebSocketState ReadyState
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1165628, RefRangeEnd = 1165631, XrefRangeStart = 1165627, XrefRangeEnd = 1165628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_get_ReadyState_Public_get_WebSocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005208 File Offset: 0x00003408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1165673, RefRangeEnd = 1165675, XrefRangeStart = 1165631, XrefRangeEnd = 1165673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureSocket(WebSocket webSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webSocket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_ConfigureSocket_Private_Void_WebSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000524C File Offset: 0x0000344C
		public unsafe bool IsConnected
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1165675, RefRangeEnd = 1165685, XrefRangeStart = 1165675, XrefRangeEnd = 1165675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005288 File Offset: 0x00003488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1165685, RefRangeEnd = 1165688, XrefRangeStart = 1165685, XrefRangeEnd = 1165685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadyToPing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_ReadyToPing_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000052C4 File Offset: 0x000034C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165688, XrefRangeEnd = 1165700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebSocketCloseCode> ConnectSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_ConnectSocket_Public_Task_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketCloseCode>>(intPtr3) : null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005304 File Offset: 0x00003504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165704, RefRangeEnd = 1165705, XrefRangeStart = 1165700, XrefRangeEnd = 1165704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Connect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_Connect_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005344 File Offset: 0x00003544
		[CallerCount(0)]
		public unsafe void handleOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005378 File Offset: 0x00003578
		[CallerCount(0)]
		public unsafe void handleError(Exception errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errorMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleError_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000053BC File Offset: 0x000035BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165705, XrefRangeEnd = 1165706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleMessage(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleMessage_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00005400 File Offset: 0x00003600
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00005438 File Offset: 0x00003638
		public unsafe Nullable<WebSocketCloseCode> CloseCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_get_CloseCode_Public_get_Nullable_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<WebSocketCloseCode>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_set_CloseCode_Private_set_Void_Nullable_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005480 File Offset: 0x00003680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165706, XrefRangeEnd = 1165719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleClose(WebSocketCloseCode closeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_handleClose_Private_Void_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000054C0 File Offset: 0x000036C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1165764, RefRangeEnd = 1165767, XrefRangeStart = 1165719, XrefRangeEnd = 1165764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_Write_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005504 File Offset: 0x00003704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165775, RefRangeEnd = 1165776, XrefRangeStart = 1165767, XrefRangeEnd = 1165775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CloseSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_CloseSocket_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005544 File Offset: 0x00003744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1165784, RefRangeEnd = 1165786, XrefRangeStart = 1165776, XrefRangeEnd = 1165784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020F0 File Offset: 0x000002F0
		public DWDWebSocket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00005578 File Offset: 0x00003778
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe WebSocket socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000055A8 File Offset: 0x000037A8
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe bool socketClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_socketClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_socketClosed)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000055D0 File Offset: 0x000037D0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002133 File Offset: 0x00000333
		public unsafe EventHandler OnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00005600 File Offset: 0x00003800
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe EventHandler<int> OnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00005630 File Offset: 0x00003830
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002171 File Offset: 0x00000371
		public unsafe EventHandler<string> OnError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_OnError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005660 File Offset: 0x00003860
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002190 File Offset: 0x00000390
		public unsafe ConcurrentQueue<TMessage> MessageQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_MessageQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<TMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_MessageQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00005690 File Offset: 0x00003890
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021AF File Offset: 0x000003AF
		public unsafe Func<Il2CppStructArray<byte>, TMessage> _messageFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr__messageFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<byte>, TMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr__messageFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000056C0 File Offset: 0x000038C0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000021CE File Offset: 0x000003CE
		public unsafe string URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_URL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr_URL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000056E8 File Offset: 0x000038E8
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000021ED File Offset: 0x000003ED
		public Nullable<TimeSpan> _keepAliveTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr__keepAliveTimeout);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr__keepAliveTimeout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005718 File Offset: 0x00003918
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000221B File Offset: 0x0000041B
		public Nullable<WebSocketCloseCode> _CloseCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr__CloseCode_k__BackingField);
				return new Nullable<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WebSocketCloseCode>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>.NativeFieldInfoPtr__CloseCode_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_socketClosed;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_OnOpen;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_OnClose;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_OnError;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_MessageQueue;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr__messageFactory;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr__keepAliveTimeout;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__CloseCode_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOpen_Public_add_Void_EventHandler_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOpen_Public_rem_Void_EventHandler_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClose_Public_add_Void_EventHandler_1_Int32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClose_Public_rem_Void_EventHandler_1_Int32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_add_OnError_Public_add_Void_EventHandler_1_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnError_Public_rem_Void_EventHandler_1_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_Il2CppStructArray_1_Byte_TMessage_Nullable_1_TimeSpan_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_PeekMessage_Public_Boolean_byref_TMessage_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetPendingMessages_Public_Void_ICollection_1_TMessage_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Reconnect_Public_Task_1_WebSocketCloseCode_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadyState_Public_get_WebSocketState_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSocket_Private_Void_WebSocket_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_ReadyToPing_Public_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSocket_Public_Task_1_WebSocketCloseCode_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_IEnumerator_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_handleOpen_Private_Void_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_handleError_Private_Void_Exception_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_handleMessage_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseCode_Public_get_Nullable_1_WebSocketCloseCode_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseCode_Private_set_Void_Nullable_1_WebSocketCloseCode_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_handleClose_Private_Void_WebSocketCloseCode_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Object_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_CloseSocket_Public_Task_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0200005A RID: 90
		[ObfuscatedName("platform.websocket.DWDWebSocket`1+<CloseSocket>d__36")]
		public sealed class _CloseSocket_d__36 : ValueType
		{
			// Token: 0x0600038B RID: 907 RVA: 0x00010F88 File Offset: 0x0000F188
			// Note: this type is marked as 'beforefieldinit'.
			static _CloseSocket_d__36()
			{
				Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "<CloseSocket>d__36"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMessage>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr);
				DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr, "<>1__state");
				DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr, "<>t__builder");
				DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr, "<>4__this");
				DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr, "<>u__1");
				DWDWebSocket<TMessage>._CloseSocket_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr, 100663331);
				DWDWebSocket<TMessage>._CloseSocket_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr, 100663332);
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00011068 File Offset: 0x0000F268
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1165390, RefRangeEnd = 1165391, XrefRangeStart = 1165373, XrefRangeEnd = 1165390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600038D RID: 909 RVA: 0x000110A0 File Offset: 0x0000F2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165391, XrefRangeEnd = 1165403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600038E RID: 910 RVA: 0x00003A8A File Offset: 0x00001C8A
			public _CloseSocket_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00003A93 File Offset: 0x00001C93
			public _CloseSocket_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDWebSocket<TMessage>._CloseSocket_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000390 RID: 912 RVA: 0x000110E8 File Offset: 0x0000F2E8
			// (set) Token: 0x06000391 RID: 913 RVA: 0x00003AA5 File Offset: 0x00001CA5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000392 RID: 914 RVA: 0x00011110 File Offset: 0x0000F310
			// (set) Token: 0x06000393 RID: 915 RVA: 0x00003AC0 File Offset: 0x00001CC0
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x06000394 RID: 916 RVA: 0x00011140 File Offset: 0x0000F340
			// (set) Token: 0x06000395 RID: 917 RVA: 0x00003AEE File Offset: 0x00001CEE
			public unsafe DWDWebSocket<TMessage> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<TMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000396 RID: 918 RVA: 0x00011170 File Offset: 0x0000F370
			// (set) Token: 0x06000397 RID: 919 RVA: 0x00003B0D File Offset: 0x00001D0D
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._CloseSocket_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000245 RID: 581
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000246 RID: 582
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200005B RID: 91
		[ObfuscatedName("platform.websocket.DWDWebSocket`1+<Connect>d__26")]
		public sealed class _Connect_d__26 : Object
		{
			// Token: 0x06000398 RID: 920 RVA: 0x000111A0 File Offset: 0x0000F3A0
			// Note: this type is marked as 'beforefieldinit'.
			static _Connect_d__26()
			{
				Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "<Connect>d__26"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMessage>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr);
				DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, "<>1__state");
				DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, "<>2__current");
				DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, "<>4__this");
				DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, 100663333);
				DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, 100663334);
				DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, 100663335);
				DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, 100663336);
				DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, 100663337);
				DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr, 100663338);
			}

			// Token: 0x06000399 RID: 921 RVA: 0x000112BC File Offset: 0x0000F4BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Connect_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Connect_d__26>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600039A RID: 922 RVA: 0x00011304 File Offset: 0x0000F504
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600039B RID: 923 RVA: 0x00011338 File Offset: 0x0000F538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165403, XrefRangeEnd = 1165416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x0600039C RID: 924 RVA: 0x00011374 File Offset: 0x0000F574
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600039D RID: 925 RVA: 0x000113B4 File Offset: 0x0000F5B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x0600039E RID: 926 RVA: 0x000113E8 File Offset: 0x0000F5E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Connect_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600039F RID: 927 RVA: 0x00003B3B File Offset: 0x00001D3B
			public _Connect_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060003A0 RID: 928 RVA: 0x00011428 File Offset: 0x0000F628
			// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003B44 File Offset: 0x00001D44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060003A2 RID: 930 RVA: 0x00011450 File Offset: 0x0000F650
			// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003B5F File Offset: 0x00001D5F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060003A4 RID: 932 RVA: 0x00011480 File Offset: 0x0000F680
			// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003B7E File Offset: 0x00001D7E
			public unsafe DWDWebSocket<TMessage> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<TMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Connect_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200005C RID: 92
		[ObfuscatedName("platform.websocket.DWDWebSocket`1+<ConnectSocket>d__25")]
		public sealed class _ConnectSocket_d__25 : ValueType
		{
			// Token: 0x060003A6 RID: 934 RVA: 0x000114B0 File Offset: 0x0000F6B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ConnectSocket_d__25()
			{
				Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "<ConnectSocket>d__25"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMessage>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr);
				DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr, "<>1__state");
				DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr, "<>t__builder");
				DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr, "<>4__this");
				DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr, "<>u__1");
				DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr, 100663339);
				DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr, 100663340);
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x00011590 File Offset: 0x0000F790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165416, XrefRangeEnd = 1165440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x000115C8 File Offset: 0x0000F7C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165440, XrefRangeEnd = 1165452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x00003B9D File Offset: 0x00001D9D
			public _ConnectSocket_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003AA RID: 938 RVA: 0x00003BA6 File Offset: 0x00001DA6
			public _ConnectSocket_d__25()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDWebSocket<TMessage>._ConnectSocket_d__25>.NativeClassPtr))
			{
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060003AB RID: 939 RVA: 0x00011610 File Offset: 0x0000F810
			// (set) Token: 0x060003AC RID: 940 RVA: 0x00003BB8 File Offset: 0x00001DB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060003AD RID: 941 RVA: 0x00011638 File Offset: 0x0000F838
			// (set) Token: 0x060003AE RID: 942 RVA: 0x00003BD3 File Offset: 0x00001DD3
			public AsyncTaskMethodBuilder<WebSocketCloseCode> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060003AF RID: 943 RVA: 0x00011668 File Offset: 0x0000F868
			// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003C01 File Offset: 0x00001E01
			public unsafe DWDWebSocket<TMessage> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<TMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x00011698 File Offset: 0x0000F898
			// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003C20 File Offset: 0x00001E20
			public TaskAwaiter<WebSocketCloseCode> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._ConnectSocket_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200005D RID: 93
		[ObfuscatedName("platform.websocket.DWDWebSocket`1+<Reconnect>d__18")]
		public sealed class _Reconnect_d__18 : ValueType
		{
			// Token: 0x060003B3 RID: 947 RVA: 0x000116C8 File Offset: 0x0000F8C8
			// Note: this type is marked as 'beforefieldinit'.
			static _Reconnect_d__18()
			{
				Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDWebSocket<TMessage>>.NativeClassPtr, "<Reconnect>d__18"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMessage>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr);
				DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr, "<>1__state");
				DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr, "<>t__builder");
				DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr, "<>4__this");
				DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr, "<>u__1");
				DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr, "<>u__2");
				DWDWebSocket<TMessage>._Reconnect_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr, 100663341);
				DWDWebSocket<TMessage>._Reconnect_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr, 100663342);
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x000117BC File Offset: 0x0000F9BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165452, XrefRangeEnd = 1165553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Reconnect_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x000117F4 File Offset: 0x0000F9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165553, XrefRangeEnd = 1165565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDWebSocket<TMessage>._Reconnect_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00003C4E File Offset: 0x00001E4E
			public _Reconnect_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00003C57 File Offset: 0x00001E57
			public _Reconnect_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDWebSocket<TMessage>._Reconnect_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060003B8 RID: 952 RVA: 0x0001183C File Offset: 0x0000FA3C
			// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003C69 File Offset: 0x00001E69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060003BA RID: 954 RVA: 0x00011864 File Offset: 0x0000FA64
			// (set) Token: 0x060003BB RID: 955 RVA: 0x00003C84 File Offset: 0x00001E84
			public AsyncTaskMethodBuilder<WebSocketCloseCode> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060003BC RID: 956 RVA: 0x00011894 File Offset: 0x0000FA94
			// (set) Token: 0x060003BD RID: 957 RVA: 0x00003CB2 File Offset: 0x00001EB2
			public unsafe DWDWebSocket<TMessage> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<TMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060003BE RID: 958 RVA: 0x000118C4 File Offset: 0x0000FAC4
			// (set) Token: 0x060003BF RID: 959 RVA: 0x00003CD1 File Offset: 0x00001ED1
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x000118F4 File Offset: 0x0000FAF4
			// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003CFF File Offset: 0x00001EFF
			public TaskAwaiter<WebSocketCloseCode> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDWebSocket<TMessage>._Reconnect_d__18.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
