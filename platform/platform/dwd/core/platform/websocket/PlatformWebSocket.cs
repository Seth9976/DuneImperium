using System;
using dwd.core.platform.authentication;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;
using NativeWebSocket;

namespace dwd.core.platform.websocket
{
	// Token: 0x0200001D RID: 29
	public sealed class PlatformWebSocket : Object
	{
		// Token: 0x06000153 RID: 339 RVA: 0x0000A0B0 File Offset: 0x000082B0
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformWebSocket()
		{
			Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "PlatformWebSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr);
			PlatformWebSocket.NativeFieldInfoPtr_ServerErrorRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "ServerErrorRegex");
			PlatformWebSocket.NativeFieldInfoPtr_webSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "webSocket");
			PlatformWebSocket.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "disposed");
			PlatformWebSocket.NativeFieldInfoPtr__url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "_url");
			PlatformWebSocket.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "client");
			PlatformWebSocket.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "token");
			PlatformWebSocket.NativeFieldInfoPtr_logEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "logEnabled");
			PlatformWebSocket.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "<State>k__BackingField");
			PlatformWebSocket.NativeFieldInfoPtr__Dispatcher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, "<Dispatcher>k__BackingField");
			PlatformWebSocket.NativeMethodInfoPtr_get_State_Public_get_SocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663567);
			PlatformWebSocket.NativeMethodInfoPtr_set_State_Private_set_Void_SocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663568);
			PlatformWebSocket.NativeMethodInfoPtr_get_Dispatcher_Public_get_IMessageDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663569);
			PlatformWebSocket.NativeMethodInfoPtr_set_Dispatcher_Private_set_Void_IMessageDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663570);
			PlatformWebSocket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663571);
			PlatformWebSocket.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663572);
			PlatformWebSocket.NativeMethodInfoPtr_Connect_Public_Void_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663573);
			PlatformWebSocket.NativeMethodInfoPtr_Disconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663574);
			PlatformWebSocket.NativeMethodInfoPtr_Write_Public_Void_OutgoingWebSocketMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663575);
			PlatformWebSocket.NativeMethodInfoPtr_handleOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663576);
			PlatformWebSocket.NativeMethodInfoPtr_handleClose_Private_Void_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663577);
			PlatformWebSocket.NativeMethodInfoPtr_handleAuthenticated_Private_Void_Authenticated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663578);
			PlatformWebSocket.NativeMethodInfoPtr_handleMessage_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663579);
			PlatformWebSocket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr, 100663580);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000A2AC File Offset: 0x000084AC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000A2E8 File Offset: 0x000084E8
		public unsafe PlatformWebSocket.SocketState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_get_State_Public_get_SocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_set_State_Private_set_Void_SocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000A328 File Offset: 0x00008528
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000A368 File Offset: 0x00008568
		public unsafe IMessageDispatcher Dispatcher
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_get_Dispatcher_Public_get_IMessageDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageDispatcher>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_set_Dispatcher_Private_set_Void_IMessageDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000A3AC File Offset: 0x000085AC
		public unsafe bool Connected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000A3E8 File Offset: 0x000085E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167488, RefRangeEnd = 1167489, XrefRangeStart = 1167445, XrefRangeEnd = 1167488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformWebSocket(string url, string client, bool logEnabled = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformWebSocket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000A454 File Offset: 0x00008654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167537, RefRangeEnd = 1167539, XrefRangeStart = 1167489, XrefRangeEnd = 1167537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(PlatformToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_Connect_Public_Void_PlatformToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000A498 File Offset: 0x00008698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1167560, RefRangeEnd = 1167564, XrefRangeStart = 1167539, XrefRangeEnd = 1167560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_Disconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000A4CC File Offset: 0x000086CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1167591, RefRangeEnd = 1167594, XrefRangeStart = 1167564, XrefRangeEnd = 1167591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(OutgoingWebSocketMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_Write_Public_Void_OutgoingWebSocketMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000A510 File Offset: 0x00008710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167594, XrefRangeEnd = 1167637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_handleOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000A544 File Offset: 0x00008744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167637, XrefRangeEnd = 1167662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleClose(WebSocketCloseCode closeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_handleClose_Private_Void_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000A584 File Offset: 0x00008784
		[CallerCount(0)]
		public unsafe void handleAuthenticated(Authenticated msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_handleAuthenticated_Private_Void_Authenticated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000A5C8 File Offset: 0x000087C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167662, XrefRangeEnd = 1167716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleMessage(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_handleMessage_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000A60C File Offset: 0x0000880C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167746, RefRangeEnd = 1167748, XrefRangeStart = 1167716, XrefRangeEnd = 1167746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformWebSocket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000027A0 File Offset: 0x000009A0
		public PlatformWebSocket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000A640 File Offset: 0x00008840
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000027A9 File Offset: 0x000009A9
		public unsafe static Regex ServerErrorRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformWebSocket.NativeFieldInfoPtr_ServerErrorRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformWebSocket.NativeFieldInfoPtr_ServerErrorRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000A668 File Offset: 0x00008868
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000027BB File Offset: 0x000009BB
		public unsafe WebSocket webSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_webSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_webSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000A698 File Offset: 0x00008898
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000027DA File Offset: 0x000009DA
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000A6C0 File Offset: 0x000088C0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000027F5 File Offset: 0x000009F5
		public unsafe string _url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr__url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr__url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000A6E8 File Offset: 0x000088E8
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002814 File Offset: 0x00000A14
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000A710 File Offset: 0x00008910
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002833 File Offset: 0x00000A33
		public unsafe PlatformToken token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_token);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_token), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000A740 File Offset: 0x00008940
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002852 File Offset: 0x00000A52
		public unsafe bool logEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_logEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr_logEnabled)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000A768 File Offset: 0x00008968
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000286D File Offset: 0x00000A6D
		public unsafe PlatformWebSocket.SocketState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000A790 File Offset: 0x00008990
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002888 File Offset: 0x00000A88
		public unsafe IMessageDispatcher _Dispatcher_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr__Dispatcher_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformWebSocket.NativeFieldInfoPtr__Dispatcher_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_ServerErrorRegex;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_webSocket;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr__url;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_token;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_logEnabled;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr__Dispatcher_k__BackingField;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_SocketState_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_SocketState_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_Dispatcher_Public_get_IMessageDispatcher_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_set_Dispatcher_Private_set_Void_IMessageDispatcher_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_PlatformToken_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_OutgoingWebSocketMessage_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_handleOpen_Private_Void_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_handleClose_Private_Void_WebSocketCloseCode_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_handleAuthenticated_Private_Void_Authenticated_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_handleMessage_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000079 RID: 121
		public enum SocketState
		{
			// Token: 0x040002D6 RID: 726
			Disconnected,
			// Token: 0x040002D7 RID: 727
			Connecting,
			// Token: 0x040002D8 RID: 728
			Connected,
			// Token: 0x040002D9 RID: 729
			Authenticated,
			// Token: 0x040002DA RID: 730
			Closing,
			// Token: 0x040002DB RID: 731
			Disposed
		}
	}
}
