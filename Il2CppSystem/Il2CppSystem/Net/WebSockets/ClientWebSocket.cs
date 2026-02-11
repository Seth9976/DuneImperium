using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000254 RID: 596
	public sealed class ClientWebSocket : WebSocket
	{
		// Token: 0x060027F4 RID: 10228 RVA: 0x000B64C8 File Offset: 0x000B46C8
		// Note: this type is marked as 'beforefieldinit'.
		static ClientWebSocket()
		{
			Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "ClientWebSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr);
			ClientWebSocket.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, "_options");
			ClientWebSocket.NativeFieldInfoPtr__innerWebSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, "_innerWebSocket");
			ClientWebSocket.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, "_state");
			ClientWebSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669254);
			ClientWebSocket.NativeMethodInfoPtr_get_Options_Public_get_ClientWebSocketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669255);
			ClientWebSocket.NativeMethodInfoPtr_get_CloseStatus_Public_Virtual_get_Nullable_1_WebSocketCloseStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669256);
			ClientWebSocket.NativeMethodInfoPtr_get_State_Public_Virtual_get_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669257);
			ClientWebSocket.NativeMethodInfoPtr_ConnectAsync_Public_Task_Uri_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669258);
			ClientWebSocket.NativeMethodInfoPtr_ConnectAsyncCore_Private_Task_Uri_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669259);
			ClientWebSocket.NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669260);
			ClientWebSocket.NativeMethodInfoPtr_ReceiveAsync_Public_Virtual_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669261);
			ClientWebSocket.NativeMethodInfoPtr_CloseAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669262);
			ClientWebSocket.NativeMethodInfoPtr_CloseOutputAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669263);
			ClientWebSocket.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669264);
			ClientWebSocket.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669265);
			ClientWebSocket.NativeMethodInfoPtr_ThrowIfNotConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, 100669266);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000B6638 File Offset: 0x000B4838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492950, RefRangeEnd = 492951, XrefRangeStart = 492901, XrefRangeEnd = 492950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientWebSocket()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x000B6674 File Offset: 0x000B4874
		public unsafe ClientWebSocketOptions Options
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_get_Options_Public_get_ClientWebSocketOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientWebSocketOptions>(intPtr3) : null;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x000B66B4 File Offset: 0x000B48B4
		public unsafe override Nullable<WebSocketCloseStatus> CloseStatus
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492951, XrefRangeEnd = 492954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_get_CloseStatus_Public_Virtual_get_Nullable_1_WebSocketCloseStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<WebSocketCloseStatus>(intPtr);
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x000B66EC File Offset: 0x000B48EC
		public unsafe override WebSocketState State
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492954, XrefRangeEnd = 492957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_get_State_Public_Virtual_get_WebSocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000B6728 File Offset: 0x000B4928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492983, RefRangeEnd = 492984, XrefRangeStart = 492957, XrefRangeEnd = 492983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ConnectAsync(Uri uri, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_ConnectAsync_Public_Task_Uri_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000B6790 File Offset: 0x000B4990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492984, XrefRangeEnd = 492996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_ConnectAsyncCore_Private_Task_Uri_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000B67F8 File Offset: 0x000B49F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492996, XrefRangeEnd = 492997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000B6884 File Offset: 0x000B4A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492997, XrefRangeEnd = 492998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_ReceiveAsync_Public_Virtual_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketReceiveResult>>(intPtr3) : null;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000B68F0 File Offset: 0x000B4AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492998, XrefRangeEnd = 493000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeStatus;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_CloseAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000B6968 File Offset: 0x000B4B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493000, XrefRangeEnd = 493002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeStatus;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_CloseOutputAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000B69E0 File Offset: 0x000B4BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493002, XrefRangeEnd = 493006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000B6A14 File Offset: 0x000B4C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493006, XrefRangeEnd = 493010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000B6A48 File Offset: 0x000B4C48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 493010, RefRangeEnd = 493014, XrefRangeStart = 493010, XrefRangeEnd = 493010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfNotConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.NativeMethodInfoPtr_ThrowIfNotConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000113DB File Offset: 0x0000F5DB
		public ClientWebSocket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x000B6A7C File Offset: 0x000B4C7C
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x000113E4 File Offset: 0x0000F5E4
		public unsafe ClientWebSocketOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket.NativeFieldInfoPtr__options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientWebSocketOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket.NativeFieldInfoPtr__options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x000B6AAC File Offset: 0x000B4CAC
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00011403 File Offset: 0x0000F603
		public unsafe WebSocketHandle _innerWebSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket.NativeFieldInfoPtr__innerWebSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocketHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket.NativeFieldInfoPtr__innerWebSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x000B6ADC File Offset: 0x000B4CDC
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x00011422 File Offset: 0x0000F622
		public unsafe int _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr__innerWebSocket;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_ClientWebSocketOptions_0;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseStatus_Public_Virtual_get_Nullable_1_WebSocketCloseStatus_0;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_WebSocketState_0;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsync_Public_Task_Uri_CancellationToken_0;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsyncCore_Private_Task_Uri_CancellationToken_0;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Virtual_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr_CloseAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_CloseOutputAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfNotConnected_Private_Void_0;

		// Token: 0x02000387 RID: 903
		public enum InternalState
		{
			// Token: 0x040027BC RID: 10172
			Created,
			// Token: 0x040027BD RID: 10173
			Connecting,
			// Token: 0x040027BE RID: 10174
			Connected,
			// Token: 0x040027BF RID: 10175
			Disposed
		}

		// Token: 0x02000388 RID: 904
		public sealed class DefaultWebProxy : Object
		{
			// Token: 0x06003422 RID: 13346 RVA: 0x000DA654 File Offset: 0x000D8854
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultWebProxy()
			{
				Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, "DefaultWebProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr);
				ClientWebSocket.DefaultWebProxy.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr, "<Instance>k__BackingField");
				ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_get_Instance_Public_Static_get_DefaultWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr, 100669267);
				ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr, 100669268);
				ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr, 100669269);
				ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr, 100669270);
				ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr, 100669271);
			}

			// Token: 0x17001074 RID: 4212
			// (get) Token: 0x06003423 RID: 13347 RVA: 0x000DA6F8 File Offset: 0x000D88F8
			public unsafe static ClientWebSocket.DefaultWebProxy Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492834, XrefRangeEnd = 492838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_get_Instance_Public_Static_get_DefaultWebProxy_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientWebSocket.DefaultWebProxy>(intPtr3) : null;
				}
			}

			// Token: 0x17001075 RID: 4213
			// (get) Token: 0x06003424 RID: 13348 RVA: 0x000DA72C File Offset: 0x000D892C
			public unsafe ICredentials Credentials
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492838, XrefRangeEnd = 492843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
				}
			}

			// Token: 0x06003425 RID: 13349 RVA: 0x000DA76C File Offset: 0x000D896C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492843, XrefRangeEnd = 492848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Uri GetProxy(Uri destination)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x06003426 RID: 13350 RVA: 0x000DA7BC File Offset: 0x000D89BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492848, XrefRangeEnd = 492860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsBypassed(Uri host)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003427 RID: 13351 RVA: 0x000DA80C File Offset: 0x000D8A0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultWebProxy()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientWebSocket.DefaultWebProxy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket.DefaultWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003428 RID: 13352 RVA: 0x00019100 File Offset: 0x00017300
			public DefaultWebProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001073 RID: 4211
			// (get) Token: 0x06003429 RID: 13353 RVA: 0x000DA848 File Offset: 0x000D8A48
			// (set) Token: 0x0600342A RID: 13354 RVA: 0x00019109 File Offset: 0x00017309
			public unsafe static ClientWebSocket.DefaultWebProxy _Instance_k__BackingField
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClientWebSocket.DefaultWebProxy.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientWebSocket.DefaultWebProxy>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClientWebSocket.DefaultWebProxy.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027C0 RID: 10176
			private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

			// Token: 0x040027C1 RID: 10177
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DefaultWebProxy_0;

			// Token: 0x040027C2 RID: 10178
			private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;

			// Token: 0x040027C3 RID: 10179
			private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

			// Token: 0x040027C4 RID: 10180
			private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;

			// Token: 0x040027C5 RID: 10181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000389 RID: 905
		[ObfuscatedName("System.Net.WebSockets.ClientWebSocket+<ConnectAsyncCore>d__16")]
		public sealed class _ConnectAsyncCore_d__16 : ValueType
		{
			// Token: 0x0600342B RID: 13355 RVA: 0x000DA870 File Offset: 0x000D8A70
			// Note: this type is marked as 'beforefieldinit'.
			static _ConnectAsyncCore_d__16()
			{
				Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientWebSocket>.NativeClassPtr, "<ConnectAsyncCore>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr);
				ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, "<>1__state");
				ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, "<>t__builder");
				ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, "<>4__this");
				ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, "uri");
				ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, "cancellationToken");
				ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, "<>u__1");
				ClientWebSocket._ConnectAsyncCore_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, 100669273);
				ClientWebSocket._ConnectAsyncCore_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr, 100669274);
			}

			// Token: 0x0600342C RID: 13356 RVA: 0x000DA93C File Offset: 0x000D8B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492860, XrefRangeEnd = 492897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket._ConnectAsyncCore_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600342D RID: 13357 RVA: 0x000DA974 File Offset: 0x000D8B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492897, XrefRangeEnd = 492901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocket._ConnectAsyncCore_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600342E RID: 13358 RVA: 0x0001911B File Offset: 0x0001731B
			public _ConnectAsyncCore_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600342F RID: 13359 RVA: 0x00019124 File Offset: 0x00017324
			public _ConnectAsyncCore_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientWebSocket._ConnectAsyncCore_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17001076 RID: 4214
			// (get) Token: 0x06003430 RID: 13360 RVA: 0x000DA9BC File Offset: 0x000D8BBC
			// (set) Token: 0x06003431 RID: 13361 RVA: 0x00019136 File Offset: 0x00017336
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001077 RID: 4215
			// (get) Token: 0x06003432 RID: 13362 RVA: 0x000DA9E4 File Offset: 0x000D8BE4
			// (set) Token: 0x06003433 RID: 13363 RVA: 0x00019151 File Offset: 0x00017351
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001078 RID: 4216
			// (get) Token: 0x06003434 RID: 13364 RVA: 0x000DAA14 File Offset: 0x000D8C14
			// (set) Token: 0x06003435 RID: 13365 RVA: 0x0001917F File Offset: 0x0001737F
			public unsafe ClientWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001079 RID: 4217
			// (get) Token: 0x06003436 RID: 13366 RVA: 0x000DAA44 File Offset: 0x000D8C44
			// (set) Token: 0x06003437 RID: 13367 RVA: 0x0001919E File Offset: 0x0001739E
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107A RID: 4218
			// (get) Token: 0x06003438 RID: 13368 RVA: 0x000DAA74 File Offset: 0x000D8C74
			// (set) Token: 0x06003439 RID: 13369 RVA: 0x000191BD File Offset: 0x000173BD
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700107B RID: 4219
			// (get) Token: 0x0600343A RID: 13370 RVA: 0x000DAAA4 File Offset: 0x000D8CA4
			// (set) Token: 0x0600343B RID: 13371 RVA: 0x000191EB File Offset: 0x000173EB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocket._ConnectAsyncCore_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040027C6 RID: 10182
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040027C7 RID: 10183
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040027C8 RID: 10184
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040027C9 RID: 10185
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x040027CA RID: 10186
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040027CB RID: 10187
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040027CC RID: 10188
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040027CD RID: 10189
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
