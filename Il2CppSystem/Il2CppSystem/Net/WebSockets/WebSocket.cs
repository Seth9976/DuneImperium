using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000257 RID: 599
	public class WebSocket : Object
	{
		// Token: 0x06002856 RID: 10326 RVA: 0x000B7CD8 File Offset: 0x000B5ED8
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocket()
		{
			Il2CppClassPointerStore<WebSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "WebSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocket>.NativeClassPtr);
			WebSocket.NativeMethodInfoPtr_get_CloseStatus_Public_Abstract_Virtual_New_get_Nullable_1_WebSocketCloseStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669324);
			WebSocket.NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669325);
			WebSocket.NativeMethodInfoPtr_Abort_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669326);
			WebSocket.NativeMethodInfoPtr_CloseAsync_Public_Abstract_Virtual_New_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669327);
			WebSocket.NativeMethodInfoPtr_CloseOutputAsync_Public_Abstract_Virtual_New_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669328);
			WebSocket.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669329);
			WebSocket.NativeMethodInfoPtr_ReceiveAsync_Public_Abstract_Virtual_New_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669330);
			WebSocket.NativeMethodInfoPtr_SendAsync_Public_Abstract_Virtual_New_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669331);
			WebSocket.NativeMethodInfoPtr_get_DefaultKeepAliveInterval_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669332);
			WebSocket.NativeMethodInfoPtr_CreateClientWebSocket_Public_Static_WebSocket_Stream_String_Int32_Int32_TimeSpan_Boolean_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669333);
			WebSocket.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocket>.NativeClassPtr, 100669334);
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000B7DE4 File Offset: 0x000B5FE4
		public unsafe virtual Nullable<WebSocketCloseStatus> CloseStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_get_CloseStatus_Public_Abstract_Virtual_New_get_Nullable_1_WebSocketCloseStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<WebSocketCloseStatus>(intPtr);
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000B7E28 File Offset: 0x000B6028
		public unsafe virtual WebSocketState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_WebSocketState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x000B7E70 File Offset: 0x000B6070
		[CallerCount(0)]
		public unsafe virtual void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_Abort_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000B7EAC File Offset: 0x000B60AC
		[CallerCount(0)]
		public unsafe virtual Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_CloseAsync_Public_Abstract_Virtual_New_Task_WebSocketCloseStatus_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000B7F2C File Offset: 0x000B612C
		[CallerCount(0)]
		public unsafe virtual Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_CloseOutputAsync_Public_Abstract_Virtual_New_Task_WebSocketCloseStatus_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000B7FAC File Offset: 0x000B61AC
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x000B7FE8 File Offset: 0x000B61E8
		[CallerCount(0)]
		public unsafe virtual Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_ReceiveAsync_Public_Abstract_Virtual_New_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketReceiveResult>>(intPtr3) : null;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x000B8060 File Offset: 0x000B6260
		[CallerCount(0)]
		public unsafe virtual Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebSocket.NativeMethodInfoPtr_SendAsync_Public_Abstract_Virtual_New_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x000B80F4 File Offset: 0x000B62F4
		public unsafe static TimeSpan DefaultKeepAliveInterval
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493727, XrefRangeEnd = 493731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_get_DefaultKeepAliveInterval_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000B8124 File Offset: 0x000B6324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493751, RefRangeEnd = 493752, XrefRangeStart = 493731, XrefRangeEnd = 493751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebSocket CreateClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment<byte> internalBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subProtocol);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveBufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendBufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveInterval;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useZeroMaskingKey;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(internalBuffer));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr_CreateClientWebSocket_Public_Static_WebSocket_Stream_String_Int32_Int32_TimeSpan_Boolean_ArraySegment_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr3) : null;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000B81CC File Offset: 0x000B63CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocket()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocket.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0001167A File Offset: 0x0000F87A
		public WebSocket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseStatus_Public_Abstract_Virtual_New_get_Nullable_1_WebSocketCloseStatus_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_WebSocketState_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_CloseAsync_Public_Abstract_Virtual_New_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_CloseOutputAsync_Public_Abstract_Virtual_New_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Abstract_Virtual_New_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Abstract_Virtual_New_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultKeepAliveInterval_Public_Static_get_TimeSpan_0;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientWebSocket_Public_Static_WebSocket_Stream_String_Int32_Int32_TimeSpan_Boolean_ArraySegment_1_Byte_0;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
