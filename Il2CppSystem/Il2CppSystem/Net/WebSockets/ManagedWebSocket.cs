using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Security.Cryptography;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000252 RID: 594
	public sealed class ManagedWebSocket : WebSocket
	{
		// Token: 0x06002788 RID: 10120 RVA: 0x000B4868 File Offset: 0x000B2A68
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedWebSocket()
		{
			Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "ManagedWebSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr);
			ManagedWebSocket.NativeFieldInfoPtr_s_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "s_random");
			ManagedWebSocket.NativeFieldInfoPtr_s_textEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "s_textEncoding");
			ManagedWebSocket.NativeFieldInfoPtr_s_validSendStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "s_validSendStates");
			ManagedWebSocket.NativeFieldInfoPtr_s_validReceiveStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "s_validReceiveStates");
			ManagedWebSocket.NativeFieldInfoPtr_s_validCloseOutputStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "s_validCloseOutputStates");
			ManagedWebSocket.NativeFieldInfoPtr_s_validCloseStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "s_validCloseStates");
			ManagedWebSocket.NativeFieldInfoPtr_s_cachedCloseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "s_cachedCloseTask");
			ManagedWebSocket.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_stream");
			ManagedWebSocket.NativeFieldInfoPtr__isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_isServer");
			ManagedWebSocket.NativeFieldInfoPtr__subprotocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_subprotocol");
			ManagedWebSocket.NativeFieldInfoPtr__keepAliveTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_keepAliveTimer");
			ManagedWebSocket.NativeFieldInfoPtr__abortSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_abortSource");
			ManagedWebSocket.NativeFieldInfoPtr__receiveBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_receiveBuffer");
			ManagedWebSocket.NativeFieldInfoPtr__utf8TextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_utf8TextState");
			ManagedWebSocket.NativeFieldInfoPtr__sendFrameAsyncLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_sendFrameAsyncLock");
			ManagedWebSocket.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_state");
			ManagedWebSocket.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_disposed");
			ManagedWebSocket.NativeFieldInfoPtr__sentCloseFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_sentCloseFrame");
			ManagedWebSocket.NativeFieldInfoPtr__receivedCloseFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_receivedCloseFrame");
			ManagedWebSocket.NativeFieldInfoPtr__closeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_closeStatus");
			ManagedWebSocket.NativeFieldInfoPtr__closeStatusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_closeStatusDescription");
			ManagedWebSocket.NativeFieldInfoPtr__lastReceiveHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_lastReceiveHeader");
			ManagedWebSocket.NativeFieldInfoPtr__receiveBufferOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_receiveBufferOffset");
			ManagedWebSocket.NativeFieldInfoPtr__receiveBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_receiveBufferCount");
			ManagedWebSocket.NativeFieldInfoPtr__receivedMaskOffsetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_receivedMaskOffsetOffset");
			ManagedWebSocket.NativeFieldInfoPtr__sendBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_sendBuffer");
			ManagedWebSocket.NativeFieldInfoPtr__lastSendWasFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_lastSendWasFragment");
			ManagedWebSocket.NativeFieldInfoPtr__lastReceiveAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "_lastReceiveAsync");
			ManagedWebSocket.NativeMethodInfoPtr_CreateFromConnectedStream_Public_Static_ManagedWebSocket_Stream_Boolean_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669172);
			ManagedWebSocket.NativeMethodInfoPtr_get_StateUpdateLock_Private_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669173);
			ManagedWebSocket.NativeMethodInfoPtr_get_ReceiveAsyncLock_Private_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669174);
			ManagedWebSocket.NativeMethodInfoPtr__ctor_Private_Void_Stream_Boolean_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669175);
			ManagedWebSocket.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669176);
			ManagedWebSocket.NativeMethodInfoPtr_DisposeCore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669177);
			ManagedWebSocket.NativeMethodInfoPtr_get_CloseStatus_Public_Virtual_get_Nullable_1_WebSocketCloseStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669178);
			ManagedWebSocket.NativeMethodInfoPtr_get_State_Public_Virtual_get_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669179);
			ManagedWebSocket.NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669180);
			ManagedWebSocket.NativeMethodInfoPtr_SendPrivateAsync_Private_ValueTask_ReadOnlyMemory_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669181);
			ManagedWebSocket.NativeMethodInfoPtr_ReceiveAsync_Public_Virtual_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669182);
			ManagedWebSocket.NativeMethodInfoPtr_CloseAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669183);
			ManagedWebSocket.NativeMethodInfoPtr_CloseOutputAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669184);
			ManagedWebSocket.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669185);
			ManagedWebSocket.NativeMethodInfoPtr_SendFrameAsync_Private_ValueTask_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669186);
			ManagedWebSocket.NativeMethodInfoPtr_SendFrameLockAcquiredNonCancelableAsync_Private_ValueTask_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669187);
			ManagedWebSocket.NativeMethodInfoPtr_WaitForWriteTaskAsync_Private_Task_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669188);
			ManagedWebSocket.NativeMethodInfoPtr_SendFrameFallbackAsync_Private_Task_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669189);
			ManagedWebSocket.NativeMethodInfoPtr_WriteFrameToSendBuffer_Private_Int32_MessageOpcode_Boolean_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669190);
			ManagedWebSocket.NativeMethodInfoPtr_SendKeepAliveFrameAsync_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669191);
			ManagedWebSocket.NativeMethodInfoPtr_WriteHeader_Private_Static_Int32_MessageOpcode_Il2CppStructArray_1_Byte_ReadOnlySpan_1_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669192);
			ManagedWebSocket.NativeMethodInfoPtr_WriteRandomMask_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669193);
			ManagedWebSocket.NativeMethodInfoPtr_ReceiveAsyncPrivate_Private_ValueTask_1_TWebSocketReceiveResult_Memory_1_Byte_CancellationToken_TWebSocketReceiveResultGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669194);
			ManagedWebSocket.NativeMethodInfoPtr_HandleReceivedCloseAsync_Private_Task_MessageHeader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669195);
			ManagedWebSocket.NativeMethodInfoPtr_WaitForServerToCloseConnectionAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669196);
			ManagedWebSocket.NativeMethodInfoPtr_HandleReceivedPingPongAsync_Private_Task_MessageHeader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669197);
			ManagedWebSocket.NativeMethodInfoPtr_IsValidCloseStatus_Private_Static_Boolean_WebSocketCloseStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669198);
			ManagedWebSocket.NativeMethodInfoPtr_CloseWithReceiveErrorAndThrowAsync_Private_Task_WebSocketCloseStatus_WebSocketError_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669199);
			ManagedWebSocket.NativeMethodInfoPtr_TryParseMessageHeaderFromReceiveBuffer_Private_Boolean_byref_MessageHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669200);
			ManagedWebSocket.NativeMethodInfoPtr_CloseAsyncPrivate_Private_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669201);
			ManagedWebSocket.NativeMethodInfoPtr_SendCloseFrameAsync_Private_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669202);
			ManagedWebSocket.NativeMethodInfoPtr_ConsumeFromBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669203);
			ManagedWebSocket.NativeMethodInfoPtr_EnsureBufferContainsAsync_Private_Task_Int32_CancellationToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669204);
			ManagedWebSocket.NativeMethodInfoPtr_ThrowIfEOFUnexpected_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669205);
			ManagedWebSocket.NativeMethodInfoPtr_AllocateSendBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669206);
			ManagedWebSocket.NativeMethodInfoPtr_ReleaseSendBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669207);
			ManagedWebSocket.NativeMethodInfoPtr_CombineMaskBytes_Private_Static_Int32_Span_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669208);
			ManagedWebSocket.NativeMethodInfoPtr_ApplyMask_Private_Static_Int32_Span_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669209);
			ManagedWebSocket.NativeMethodInfoPtr_ApplyMask_Private_Static_Int32_Span_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669210);
			ManagedWebSocket.NativeMethodInfoPtr_ThrowIfOperationInProgress_Private_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669211);
			ManagedWebSocket.NativeMethodInfoPtr_ThrowOperationInProgress_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669212);
			ManagedWebSocket.NativeMethodInfoPtr_CreateOperationCanceledException_Private_Static_Exception_Exception_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669213);
			ManagedWebSocket.NativeMethodInfoPtr_TryValidateUtf8_Private_Static_Boolean_Span_1_Byte_Boolean_Utf8MessageState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669214);
			ManagedWebSocket.NativeMethodInfoPtr_ValidateAndReceiveAsync_Private_Task_Task_Il2CppStructArray_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, 100669215);
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000B4E38 File Offset: 0x000B3038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492178, XrefRangeEnd = 492182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ManagedWebSocket CreateFromConnectedStream(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isServer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subprotocol);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveInterval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_CreateFromConnectedStream_Public_Static_ManagedWebSocket_Stream_Boolean_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr3) : null;
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x000B4EAC File Offset: 0x000B30AC
		public unsafe Object StateUpdateLock
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_get_StateUpdateLock_Private_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000B4EEC File Offset: 0x000B30EC
		public unsafe Object ReceiveAsyncLock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_get_ReceiveAsyncLock_Private_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x000B4F2C File Offset: 0x000B312C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492259, RefRangeEnd = 492261, XrefRangeStart = 492182, XrefRangeEnd = 492259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagedWebSocket(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isServer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subprotocol);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveInterval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr__ctor_Private_Void_Stream_Boolean_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x000B4FA8 File Offset: 0x000B31A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492261, XrefRangeEnd = 492267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x000B4FDC File Offset: 0x000B31DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492267, XrefRangeEnd = 492269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_DisposeCore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000B5010 File Offset: 0x000B3210
		public unsafe override Nullable<WebSocketCloseStatus> CloseStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_get_CloseStatus_Public_Virtual_get_Nullable_1_WebSocketCloseStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<WebSocketCloseStatus>(intPtr);
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x000B5048 File Offset: 0x000B3248
		public unsafe override WebSocketState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_get_State_Public_Virtual_get_WebSocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000B5084 File Offset: 0x000B3284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492269, XrefRangeEnd = 492280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000B5110 File Offset: 0x000B3310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492287, RefRangeEnd = 492288, XrefRangeStart = 492280, XrefRangeEnd = 492287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask SendPrivateAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_SendPrivateAsync_Private_ValueTask_ReadOnlyMemory_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000B5194 File Offset: 0x000B3394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492288, XrefRangeEnd = 492317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ReceiveAsync_Public_Virtual_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketReceiveResult>>(intPtr3) : null;
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000B5200 File Offset: 0x000B3400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492317, XrefRangeEnd = 492335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_CloseAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x000B5278 File Offset: 0x000B3478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492335, XrefRangeEnd = 492342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_CloseOutputAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000B52F0 File Offset: 0x000B34F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492342, XrefRangeEnd = 492344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000B5324 File Offset: 0x000B3524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 492365, RefRangeEnd = 492368, XrefRangeStart = 492344, XrefRangeEnd = 492365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask SendFrameAsync(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(payloadBuffer));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_SendFrameAsync_Private_ValueTask_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000B53A8 File Offset: 0x000B35A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492420, RefRangeEnd = 492422, XrefRangeStart = 492368, XrefRangeEnd = 492420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask SendFrameLockAcquiredNonCancelableAsync(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(payloadBuffer));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_SendFrameLockAcquiredNonCancelableAsync_Private_ValueTask_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000B5414 File Offset: 0x000B3614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492422, XrefRangeEnd = 492433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WaitForWriteTaskAsync(ValueTask writeTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(writeTask));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_WaitForWriteTaskAsync_Private_Task_ValueTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000B546C File Offset: 0x000B366C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492433, XrefRangeEnd = 492445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SendFrameFallbackAsync(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(payloadBuffer));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_SendFrameFallbackAsync_Private_Task_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000B54F8 File Offset: 0x000B36F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492488, RefRangeEnd = 492490, XrefRangeStart = 492445, XrefRangeEnd = 492488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int WriteFrameToSendBuffer(ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, ReadOnlySpan<byte> payloadBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(payloadBuffer));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_WriteFrameToSendBuffer_Private_Int32_MessageOpcode_Boolean_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000B5568 File Offset: 0x000B3768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492539, RefRangeEnd = 492540, XrefRangeStart = 492490, XrefRangeEnd = 492539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendKeepAliveFrameAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_SendKeepAliveFrameAsync_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000B559C File Offset: 0x000B379C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492550, RefRangeEnd = 492552, XrefRangeStart = 492540, XrefRangeEnd = 492550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteHeader(ManagedWebSocket.MessageOpcode opcode, Il2CppStructArray<byte> sendBuffer, ReadOnlySpan<byte> payload, bool endOfMessage, bool useMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sendBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(payload));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_WriteHeader_Private_Static_Int32_MessageOpcode_Il2CppStructArray_1_Byte_ReadOnlySpan_1_Byte_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000B5620 File Offset: 0x000B3820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492552, XrefRangeEnd = 492556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteRandomMask(Il2CppStructArray<byte> buffer, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_WriteRandomMask_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x000B5664 File Offset: 0x000B3864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492556, XrefRangeEnd = 492580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>(Memory<byte> payloadBuffer, CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter = default(TWebSocketReceiveResultGetter)) where TWebSocketReceiveResultGetter : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(payloadBuffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TWebSocketReceiveResultGetter).IsValueType)
			{
				TWebSocketReceiveResultGetter twebSocketReceiveResultGetter = resultGetter;
				intPtr = ((twebSocketReceiveResultGetter is string) ? IL2CPP.ManagedStringToIl2Cpp(twebSocketReceiveResultGetter as string) : IL2CPP.Il2CppObjectBaseToPtr(twebSocketReceiveResultGetter as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref resultGetter;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.MethodInfoStoreGeneric_ReceiveAsyncPrivate_Private_ValueTask_1_TWebSocketReceiveResult_Memory_1_Byte_CancellationToken_TWebSocketReceiveResultGetter_0<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return new ValueTask<TWebSocketReceiveResult>(intPtr2);
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x000B5710 File Offset: 0x000B3910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492591, RefRangeEnd = 492592, XrefRangeStart = 492580, XrefRangeEnd = 492591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task HandleReceivedCloseAsync(ManagedWebSocket.MessageHeader header, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref header;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_HandleReceivedCloseAsync_Private_Task_MessageHeader_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000B5774 File Offset: 0x000B3974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492603, RefRangeEnd = 492605, XrefRangeStart = 492592, XrefRangeEnd = 492603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WaitForServerToCloseConnectionAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_WaitForServerToCloseConnectionAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x000B57CC File Offset: 0x000B39CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492605, XrefRangeEnd = 492616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task HandleReceivedPingPongAsync(ManagedWebSocket.MessageHeader header, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref header;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_HandleReceivedPingPongAsync_Private_Task_MessageHeader_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000B5830 File Offset: 0x000B3A30
		[CallerCount(0)]
		public unsafe static bool IsValidCloseStatus(WebSocketCloseStatus closeStatus)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeStatus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_IsValidCloseStatus_Private_Static_Boolean_WebSocketCloseStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000B5870 File Offset: 0x000B3A70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 492627, RefRangeEnd = 492632, XrefRangeStart = 492616, XrefRangeEnd = 492627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CloseWithReceiveErrorAndThrowAsync(WebSocketCloseStatus closeStatus, WebSocketError error, Exception innerException = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeStatus;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_CloseWithReceiveErrorAndThrowAsync_Private_Task_WebSocketCloseStatus_WebSocketError_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000B58DC File Offset: 0x000B3ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492649, RefRangeEnd = 492650, XrefRangeStart = 492632, XrefRangeEnd = 492649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryParseMessageHeaderFromReceiveBuffer(out ManagedWebSocket.MessageHeader resultHeader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &resultHeader;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_TryParseMessageHeaderFromReceiveBuffer_Private_Boolean_byref_MessageHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000B5928 File Offset: 0x000B3B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492650, XrefRangeEnd = 492662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CloseAsyncPrivate(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_CloseAsyncPrivate_Private_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000B59A0 File Offset: 0x000B3BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492674, RefRangeEnd = 492676, XrefRangeStart = 492662, XrefRangeEnd = 492674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SendCloseFrameAsync(WebSocketCloseStatus closeStatus, string closeStatusDescription, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeStatus;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(closeStatusDescription);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_SendCloseFrameAsync_Private_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000B5A18 File Offset: 0x000B3C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492676, RefRangeEnd = 492677, XrefRangeStart = 492676, XrefRangeEnd = 492676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeFromBuffer(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ConsumeFromBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000B5A58 File Offset: 0x000B3C58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 492688, RefRangeEnd = 492692, XrefRangeStart = 492677, XrefRangeEnd = 492688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task EnsureBufferContainsAsync(int minimumRequiredBytes, CancellationToken cancellationToken, bool throwOnPrematureClosure = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumRequiredBytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnPrematureClosure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_EnsureBufferContainsAsync_Private_Task_Int32_CancellationToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000B5ACC File Offset: 0x000B3CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492692, RefRangeEnd = 492693, XrefRangeStart = 492692, XrefRangeEnd = 492692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfEOFUnexpected(bool throwOnPrematureClosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnPrematureClosure;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ThrowIfEOFUnexpected_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000B5B0C File Offset: 0x000B3D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492693, XrefRangeEnd = 492701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateSendBuffer(int minLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_AllocateSendBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000B5B4C File Offset: 0x000B3D4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 492708, RefRangeEnd = 492712, XrefRangeStart = 492701, XrefRangeEnd = 492708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseSendBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ReleaseSendBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000B5B80 File Offset: 0x000B3D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492720, RefRangeEnd = 492722, XrefRangeStart = 492712, XrefRangeEnd = 492720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineMaskBytes(Span<byte> buffer, int maskOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_CombineMaskBytes_Private_Static_Int32_Span_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000B5BD4 File Offset: 0x000B3DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492722, XrefRangeEnd = 492730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ApplyMask(Span<byte> toMask, Il2CppStructArray<byte> mask, int maskOffset, int maskOffsetIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(toMask));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mask);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskOffsetIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ApplyMask_Private_Static_Int32_Span_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000B5C48 File Offset: 0x000B3E48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 492734, RefRangeEnd = 492739, XrefRangeStart = 492730, XrefRangeEnd = 492734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ApplyMask(Span<byte> toMask, int mask, int maskIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(toMask));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ApplyMask_Private_Static_Int32_Span_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000B5CAC File Offset: 0x000B3EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492739, XrefRangeEnd = 492741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfOperationInProgress(bool operationCompleted, string methodName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operationCompleted;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ThrowIfOperationInProgress_Private_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000B5CFC File Offset: 0x000B3EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492748, RefRangeEnd = 492749, XrefRangeStart = 492741, XrefRangeEnd = 492748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOperationInProgress(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ThrowOperationInProgress_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000B5D40 File Offset: 0x000B3F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492756, RefRangeEnd = 492757, XrefRangeStart = 492749, XrefRangeEnd = 492756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateOperationCanceledException(Exception innerException, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_CreateOperationCanceledException_Private_Static_Exception_Exception_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000B5D9C File Offset: 0x000B3F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492761, RefRangeEnd = 492762, XrefRangeStart = 492757, XrefRangeEnd = 492761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryValidateUtf8(Span<byte> span, bool endOfMessage, ManagedWebSocket.Utf8MessageState state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_TryValidateUtf8_Private_Static_Boolean_Span_1_Byte_Boolean_Utf8MessageState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000B5E04 File Offset: 0x000B4004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492780, RefRangeEnd = 492781, XrefRangeStart = 492762, XrefRangeEnd = 492780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ValidateAndReceiveAsync(Task receiveTask, Il2CppStructArray<byte> buffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(receiveTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.NativeMethodInfoPtr_ValidateAndReceiveAsync_Private_Task_Task_Il2CppStructArray_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000110CA File Offset: 0x0000F2CA
		public ManagedWebSocket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x000B5E80 File Offset: 0x000B4080
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x000110D3 File Offset: 0x0000F2D3
		public unsafe static RandomNumberGenerator s_random
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.NativeFieldInfoPtr_s_random, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.NativeFieldInfoPtr_s_random, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x000B5EA8 File Offset: 0x000B40A8
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x000110E5 File Offset: 0x0000F2E5
		public unsafe static UTF8Encoding s_textEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.NativeFieldInfoPtr_s_textEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UTF8Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.NativeFieldInfoPtr_s_textEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x000B5ED0 File Offset: 0x000B40D0
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x000110F7 File Offset: 0x0000F2F7
		public unsafe static Il2CppStructArray<WebSocketState> s_validSendStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.NativeFieldInfoPtr_s_validSendStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WebSocketState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.NativeFieldInfoPtr_s_validSendStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000B5EF8 File Offset: 0x000B40F8
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x00011109 File Offset: 0x0000F309
		public unsafe static Il2CppStructArray<WebSocketState> s_validReceiveStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.NativeFieldInfoPtr_s_validReceiveStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WebSocketState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.NativeFieldInfoPtr_s_validReceiveStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x000B5F20 File Offset: 0x000B4120
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x0001111B File Offset: 0x0000F31B
		public unsafe static Il2CppStructArray<WebSocketState> s_validCloseOutputStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.NativeFieldInfoPtr_s_validCloseOutputStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WebSocketState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.NativeFieldInfoPtr_s_validCloseOutputStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x000B5F48 File Offset: 0x000B4148
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x0001112D File Offset: 0x0000F32D
		public unsafe static Il2CppStructArray<WebSocketState> s_validCloseStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.NativeFieldInfoPtr_s_validCloseStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WebSocketState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.NativeFieldInfoPtr_s_validCloseStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000B5F70 File Offset: 0x000B4170
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x0001113F File Offset: 0x0000F33F
		public unsafe static Task<WebSocketReceiveResult> s_cachedCloseTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.NativeFieldInfoPtr_s_cachedCloseTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<WebSocketReceiveResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.NativeFieldInfoPtr_s_cachedCloseTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000B5F98 File Offset: 0x000B4198
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00011151 File Offset: 0x0000F351
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x000B5FC8 File Offset: 0x000B41C8
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00011170 File Offset: 0x0000F370
		public unsafe bool _isServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__isServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__isServer)) = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000B5FF0 File Offset: 0x000B41F0
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x0001118B File Offset: 0x0000F38B
		public unsafe string _subprotocol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__subprotocol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__subprotocol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x000B6018 File Offset: 0x000B4218
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x000111AA File Offset: 0x0000F3AA
		public unsafe Timer _keepAliveTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__keepAliveTimer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__keepAliveTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000B6048 File Offset: 0x000B4248
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x000111C9 File Offset: 0x0000F3C9
		public unsafe CancellationTokenSource _abortSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__abortSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__abortSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000B6078 File Offset: 0x000B4278
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x000111E8 File Offset: 0x0000F3E8
		public Memory<byte> _receiveBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receiveBuffer);
				return new Memory<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receiveBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x000B60A8 File Offset: 0x000B42A8
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x00011216 File Offset: 0x0000F416
		public unsafe ManagedWebSocket.Utf8MessageState _utf8TextState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__utf8TextState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket.Utf8MessageState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__utf8TextState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x000B60D8 File Offset: 0x000B42D8
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x00011235 File Offset: 0x0000F435
		public unsafe SemaphoreSlim _sendFrameAsyncLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__sendFrameAsyncLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__sendFrameAsyncLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x000B6108 File Offset: 0x000B4308
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x00011254 File Offset: 0x0000F454
		public unsafe WebSocketState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000B6130 File Offset: 0x000B4330
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x0001126F File Offset: 0x0000F46F
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x000B6158 File Offset: 0x000B4358
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x0001128A File Offset: 0x0000F48A
		public unsafe bool _sentCloseFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__sentCloseFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__sentCloseFrame)) = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x000B6180 File Offset: 0x000B4380
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x000112A5 File Offset: 0x0000F4A5
		public unsafe bool _receivedCloseFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receivedCloseFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receivedCloseFrame)) = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x000B61A8 File Offset: 0x000B43A8
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x000112C0 File Offset: 0x0000F4C0
		public Nullable<WebSocketCloseStatus> _closeStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__closeStatus);
				return new Nullable<WebSocketCloseStatus>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WebSocketCloseStatus>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__closeStatus), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WebSocketCloseStatus>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x000B61D8 File Offset: 0x000B43D8
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x000112EE File Offset: 0x0000F4EE
		public unsafe string _closeStatusDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__closeStatusDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__closeStatusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000B6200 File Offset: 0x000B4400
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x0001130D File Offset: 0x0000F50D
		public unsafe ManagedWebSocket.MessageHeader _lastReceiveHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__lastReceiveHeader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__lastReceiveHeader)) = value;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x000B6228 File Offset: 0x000B4428
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x00011328 File Offset: 0x0000F528
		public unsafe int _receiveBufferOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receiveBufferOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receiveBufferOffset)) = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000B6250 File Offset: 0x000B4450
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x00011343 File Offset: 0x0000F543
		public unsafe int _receiveBufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receiveBufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receiveBufferCount)) = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000B6278 File Offset: 0x000B4478
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x0001135E File Offset: 0x0000F55E
		public unsafe int _receivedMaskOffsetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receivedMaskOffsetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__receivedMaskOffsetOffset)) = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000B62A0 File Offset: 0x000B44A0
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x00011379 File Offset: 0x0000F579
		public unsafe Il2CppStructArray<byte> _sendBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__sendBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__sendBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x000B62D0 File Offset: 0x000B44D0
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x00011398 File Offset: 0x0000F598
		public unsafe bool _lastSendWasFragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__lastSendWasFragment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__lastSendWasFragment)) = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x000B62F8 File Offset: 0x000B44F8
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x000113B3 File Offset: 0x0000F5B3
		public unsafe Task _lastReceiveAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__lastReceiveAsync);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.NativeFieldInfoPtr__lastReceiveAsync), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeFieldInfoPtr_s_random;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeFieldInfoPtr_s_textEncoding;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeFieldInfoPtr_s_validSendStates;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeFieldInfoPtr_s_validReceiveStates;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeFieldInfoPtr_s_validCloseOutputStates;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeFieldInfoPtr_s_validCloseStates;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedCloseTask;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeFieldInfoPtr__isServer;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeFieldInfoPtr__subprotocol;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeFieldInfoPtr__keepAliveTimer;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeFieldInfoPtr__abortSource;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeFieldInfoPtr__receiveBuffer;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeFieldInfoPtr__utf8TextState;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeFieldInfoPtr__sendFrameAsyncLock;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeFieldInfoPtr__sentCloseFrame;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeFieldInfoPtr__receivedCloseFrame;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeFieldInfoPtr__closeStatus;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeFieldInfoPtr__closeStatusDescription;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeFieldInfoPtr__lastReceiveHeader;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeFieldInfoPtr__receiveBufferOffset;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeFieldInfoPtr__receiveBufferCount;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeFieldInfoPtr__receivedMaskOffsetOffset;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeFieldInfoPtr__sendBuffer;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeFieldInfoPtr__lastSendWasFragment;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeFieldInfoPtr__lastReceiveAsync;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromConnectedStream_Public_Static_ManagedWebSocket_Stream_Boolean_String_TimeSpan_0;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr_get_StateUpdateLock_Private_get_Object_0;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiveAsyncLock_Private_get_Object_0;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Stream_Boolean_String_TimeSpan_0;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr_DisposeCore_Private_Void_0;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseStatus_Public_Virtual_get_Nullable_1_WebSocketCloseStatus_0;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_get_WebSocketState_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr_SendPrivateAsync_Private_ValueTask_ReadOnlyMemory_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Virtual_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeMethodInfoPtr_CloseAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeMethodInfoPtr_CloseOutputAsync_Public_Virtual_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeMethodInfoPtr_SendFrameAsync_Private_ValueTask_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_CancellationToken_0;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeMethodInfoPtr_SendFrameLockAcquiredNonCancelableAsync_Private_ValueTask_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_0;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeMethodInfoPtr_WaitForWriteTaskAsync_Private_Task_ValueTask_0;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeMethodInfoPtr_SendFrameFallbackAsync_Private_Task_MessageOpcode_Boolean_ReadOnlyMemory_1_Byte_CancellationToken_0;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeMethodInfoPtr_WriteFrameToSendBuffer_Private_Int32_MessageOpcode_Boolean_ReadOnlySpan_1_Byte_0;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeMethodInfoPtr_SendKeepAliveFrameAsync_Private_Void_0;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeMethodInfoPtr_WriteHeader_Private_Static_Int32_MessageOpcode_Il2CppStructArray_1_Byte_ReadOnlySpan_1_Byte_Boolean_Boolean_0;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeMethodInfoPtr_WriteRandomMask_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsyncPrivate_Private_ValueTask_1_TWebSocketReceiveResult_Memory_1_Byte_CancellationToken_TWebSocketReceiveResultGetter_0;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeMethodInfoPtr_HandleReceivedCloseAsync_Private_Task_MessageHeader_CancellationToken_0;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeMethodInfoPtr_WaitForServerToCloseConnectionAsync_Private_Task_CancellationToken_0;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeMethodInfoPtr_HandleReceivedPingPongAsync_Private_Task_MessageHeader_CancellationToken_0;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCloseStatus_Private_Static_Boolean_WebSocketCloseStatus_0;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeMethodInfoPtr_CloseWithReceiveErrorAndThrowAsync_Private_Task_WebSocketCloseStatus_WebSocketError_Exception_0;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeMethodInfoPtr_TryParseMessageHeaderFromReceiveBuffer_Private_Boolean_byref_MessageHeader_0;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeMethodInfoPtr_CloseAsyncPrivate_Private_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeMethodInfoPtr_SendCloseFrameAsync_Private_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeFromBuffer_Private_Void_Int32_0;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBufferContainsAsync_Private_Task_Int32_CancellationToken_Boolean_0;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfEOFUnexpected_Private_Void_Boolean_0;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeMethodInfoPtr_AllocateSendBuffer_Private_Void_Int32_0;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSendBuffer_Private_Void_0;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeMethodInfoPtr_CombineMaskBytes_Private_Static_Int32_Span_1_Byte_Int32_0;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMask_Private_Static_Int32_Span_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMask_Private_Static_Int32_Span_1_Byte_Int32_Int32_0;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfOperationInProgress_Private_Void_Boolean_String_0;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOperationInProgress_Private_Void_String_0;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeMethodInfoPtr_CreateOperationCanceledException_Private_Static_Exception_Exception_CancellationToken_0;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeMethodInfoPtr_TryValidateUtf8_Private_Static_Boolean_Span_1_Byte_Boolean_Utf8MessageState_0;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAndReceiveAsync_Private_Task_Task_Il2CppStructArray_1_Byte_CancellationToken_0;

		// Token: 0x02000375 RID: 885
		public sealed class Utf8MessageState : Object
		{
			// Token: 0x06003322 RID: 13090 RVA: 0x000D7FE4 File Offset: 0x000D61E4
			// Note: this type is marked as 'beforefieldinit'.
			static Utf8MessageState()
			{
				Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "Utf8MessageState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr);
				ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_SequenceInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr, "SequenceInProgress");
				ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_AdditionalBytesExpected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr, "AdditionalBytesExpected");
				ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_ExpectedValueMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr, "ExpectedValueMin");
				ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_CurrentDecodeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr, "CurrentDecodeBits");
				ManagedWebSocket.Utf8MessageState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr, 100669217);
			}

			// Token: 0x06003323 RID: 13091 RVA: 0x000D8074 File Offset: 0x000D6274
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Utf8MessageState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket.Utf8MessageState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.Utf8MessageState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003324 RID: 13092 RVA: 0x0001832A File Offset: 0x0001652A
			public Utf8MessageState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001018 RID: 4120
			// (get) Token: 0x06003325 RID: 13093 RVA: 0x000D80B0 File Offset: 0x000D62B0
			// (set) Token: 0x06003326 RID: 13094 RVA: 0x00018333 File Offset: 0x00016533
			public unsafe bool SequenceInProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_SequenceInProgress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_SequenceInProgress)) = value;
				}
			}

			// Token: 0x17001019 RID: 4121
			// (get) Token: 0x06003327 RID: 13095 RVA: 0x000D80D8 File Offset: 0x000D62D8
			// (set) Token: 0x06003328 RID: 13096 RVA: 0x0001834E File Offset: 0x0001654E
			public unsafe int AdditionalBytesExpected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_AdditionalBytesExpected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_AdditionalBytesExpected)) = value;
				}
			}

			// Token: 0x1700101A RID: 4122
			// (get) Token: 0x06003329 RID: 13097 RVA: 0x000D8100 File Offset: 0x000D6300
			// (set) Token: 0x0600332A RID: 13098 RVA: 0x00018369 File Offset: 0x00016569
			public unsafe int ExpectedValueMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_ExpectedValueMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_ExpectedValueMin)) = value;
				}
			}

			// Token: 0x1700101B RID: 4123
			// (get) Token: 0x0600332B RID: 13099 RVA: 0x000D8128 File Offset: 0x000D6328
			// (set) Token: 0x0600332C RID: 13100 RVA: 0x00018384 File Offset: 0x00016584
			public unsafe int CurrentDecodeBits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_CurrentDecodeBits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket.Utf8MessageState.NativeFieldInfoPtr_CurrentDecodeBits)) = value;
				}
			}

			// Token: 0x04002731 RID: 10033
			private static readonly IntPtr NativeFieldInfoPtr_SequenceInProgress;

			// Token: 0x04002732 RID: 10034
			private static readonly IntPtr NativeFieldInfoPtr_AdditionalBytesExpected;

			// Token: 0x04002733 RID: 10035
			private static readonly IntPtr NativeFieldInfoPtr_ExpectedValueMin;

			// Token: 0x04002734 RID: 10036
			private static readonly IntPtr NativeFieldInfoPtr_CurrentDecodeBits;

			// Token: 0x04002735 RID: 10037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000376 RID: 886
		public enum MessageOpcode : byte
		{
			// Token: 0x04002737 RID: 10039
			Continuation,
			// Token: 0x04002738 RID: 10040
			Text,
			// Token: 0x04002739 RID: 10041
			Binary,
			// Token: 0x0400273A RID: 10042
			Close = 8,
			// Token: 0x0400273B RID: 10043
			Ping,
			// Token: 0x0400273C RID: 10044
			Pong
		}

		// Token: 0x02000377 RID: 887
		[StructLayout(2)]
		public struct MessageHeader
		{
			// Token: 0x0600332D RID: 13101 RVA: 0x000D8150 File Offset: 0x000D6350
			// Note: this type is marked as 'beforefieldinit'.
			static MessageHeader()
			{
				Il2CppClassPointerStore<ManagedWebSocket.MessageHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "MessageHeader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket.MessageHeader>.NativeClassPtr);
				ManagedWebSocket.MessageHeader.NativeFieldInfoPtr_Opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.MessageHeader>.NativeClassPtr, "Opcode");
				ManagedWebSocket.MessageHeader.NativeFieldInfoPtr_Fin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.MessageHeader>.NativeClassPtr, "Fin");
				ManagedWebSocket.MessageHeader.NativeFieldInfoPtr_PayloadLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.MessageHeader>.NativeClassPtr, "PayloadLength");
				ManagedWebSocket.MessageHeader.NativeFieldInfoPtr_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.MessageHeader>.NativeClassPtr, "Mask");
			}

			// Token: 0x0600332E RID: 13102 RVA: 0x0001839F File Offset: 0x0001659F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedWebSocket.MessageHeader>.NativeClassPtr, ref this));
			}

			// Token: 0x0400273D RID: 10045
			private static readonly IntPtr NativeFieldInfoPtr_Opcode;

			// Token: 0x0400273E RID: 10046
			private static readonly IntPtr NativeFieldInfoPtr_Fin;

			// Token: 0x0400273F RID: 10047
			private static readonly IntPtr NativeFieldInfoPtr_PayloadLength;

			// Token: 0x04002740 RID: 10048
			private static readonly IntPtr NativeFieldInfoPtr_Mask;

			// Token: 0x04002741 RID: 10049
			[FieldOffset(0)]
			public ManagedWebSocket.MessageOpcode Opcode;

			// Token: 0x04002742 RID: 10050
			[FieldOffset(1)]
			[MarshalAs(4)]
			public bool Fin;

			// Token: 0x04002743 RID: 10051
			[FieldOffset(8)]
			public long PayloadLength;

			// Token: 0x04002744 RID: 10052
			[FieldOffset(16)]
			public int Mask;
		}

		// Token: 0x02000378 RID: 888
		public class IWebSocketReceiveResultGetter<TResult> : Il2CppObjectBase
		{
			// Token: 0x0600332F RID: 13103 RVA: 0x000D81CC File Offset: 0x000D63CC
			// Note: this type is marked as 'beforefieldinit'.
			static IWebSocketReceiveResultGetter()
			{
				Il2CppClassPointerStore<ManagedWebSocket.IWebSocketReceiveResultGetter<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "IWebSocketReceiveResultGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				ManagedWebSocket.IWebSocketReceiveResultGetter<TResult>.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.IWebSocketReceiveResultGetter<TResult>>.NativeClassPtr, 100669218);
			}

			// Token: 0x06003330 RID: 13104 RVA: 0x000D823C File Offset: 0x000D643C
			[CallerCount(0)]
			public unsafe virtual TResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(closeStatus));
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(closeDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagedWebSocket.IWebSocketReceiveResultGetter<TResult>.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}

			// Token: 0x06003331 RID: 13105 RVA: 0x000183B1 File Offset: 0x000165B1
			public IWebSocketReceiveResultGetter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002745 RID: 10053
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0;
		}

		// Token: 0x02000379 RID: 889
		[StructLayout(2)]
		public struct WebSocketReceiveResultGetter
		{
			// Token: 0x06003332 RID: 13106 RVA: 0x000183BA File Offset: 0x000165BA
			// Note: this type is marked as 'beforefieldinit'.
			static WebSocketReceiveResultGetter()
			{
				Il2CppClassPointerStore<ManagedWebSocket.WebSocketReceiveResultGetter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "WebSocketReceiveResultGetter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket.WebSocketReceiveResultGetter>.NativeClassPtr);
				ManagedWebSocket.WebSocketReceiveResultGetter.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_WebSocketReceiveResult_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.WebSocketReceiveResultGetter>.NativeClassPtr, 100669219);
			}

			// Token: 0x06003333 RID: 13107 RVA: 0x000D82D4 File Offset: 0x000D64D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491181, XrefRangeEnd = 491185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebSocketReceiveResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeDescription)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(closeStatus));
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(closeDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.WebSocketReceiveResultGetter.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_WebSocketReceiveResult_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebSocketReceiveResult>(intPtr3) : null;
			}

			// Token: 0x06003334 RID: 13108 RVA: 0x000183EE File Offset: 0x000165EE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedWebSocket.WebSocketReceiveResultGetter>.NativeClassPtr, ref this));
			}

			// Token: 0x04002746 RID: 10054
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_WebSocketReceiveResult_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0;
		}

		// Token: 0x0200037A RID: 890
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003335 RID: 13109 RVA: 0x000D835C File Offset: 0x000D655C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr);
				ManagedWebSocket.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, "<>9");
				ManagedWebSocket.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, "<>9__36_0");
				ManagedWebSocket.__c.NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, "<>9__36_1");
				ManagedWebSocket.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, "<>9__56_0");
				ManagedWebSocket.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, "<>9__58_0");
				ManagedWebSocket.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, "<>9__63_0");
				ManagedWebSocket.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, 100669221);
				ManagedWebSocket.__c.NativeMethodInfoPtr___ctor_b__36_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, 100669222);
				ManagedWebSocket.__c.NativeMethodInfoPtr___ctor_b__36_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, 100669223);
				ManagedWebSocket.__c.NativeMethodInfoPtr__SendFrameFallbackAsync_b__56_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, 100669224);
				ManagedWebSocket.__c.NativeMethodInfoPtr__SendKeepAliveFrameAsync_b__58_0_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, 100669225);
				ManagedWebSocket.__c.NativeMethodInfoPtr__WaitForServerToCloseConnectionAsync_b__63_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr, 100669226);
			}

			// Token: 0x06003336 RID: 13110 RVA: 0x000D8478 File Offset: 0x000D6678
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003337 RID: 13111 RVA: 0x000D84B4 File Offset: 0x000D66B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491185, XrefRangeEnd = 491191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__36_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c.NativeMethodInfoPtr___ctor_b__36_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003338 RID: 13112 RVA: 0x000D84F8 File Offset: 0x000D66F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491191, XrefRangeEnd = 491196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__36_1(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c.NativeMethodInfoPtr___ctor_b__36_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003339 RID: 13113 RVA: 0x000D853C File Offset: 0x000D673C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491196, XrefRangeEnd = 491200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendFrameFallbackAsync_b__56_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c.NativeMethodInfoPtr__SendFrameFallbackAsync_b__56_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600333A RID: 13114 RVA: 0x000D8580 File Offset: 0x000D6780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491200, XrefRangeEnd = 491202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendKeepAliveFrameAsync_b__58_0(Task p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c.NativeMethodInfoPtr__SendKeepAliveFrameAsync_b__58_0_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600333B RID: 13115 RVA: 0x000D85C4 File Offset: 0x000D67C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491202, XrefRangeEnd = 491206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WaitForServerToCloseConnectionAsync_b__63_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c.NativeMethodInfoPtr__WaitForServerToCloseConnectionAsync_b__63_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600333C RID: 13116 RVA: 0x00018400 File Offset: 0x00016600
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700101C RID: 4124
			// (get) Token: 0x0600333D RID: 13117 RVA: 0x000D8608 File Offset: 0x000D6808
			// (set) Token: 0x0600333E RID: 13118 RVA: 0x00018409 File Offset: 0x00016609
			public unsafe static ManagedWebSocket.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700101D RID: 4125
			// (get) Token: 0x0600333F RID: 13119 RVA: 0x000D8630 File Offset: 0x000D6830
			// (set) Token: 0x06003340 RID: 13120 RVA: 0x0001841B File Offset: 0x0001661B
			public unsafe static Action<Object> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700101E RID: 4126
			// (get) Token: 0x06003341 RID: 13121 RVA: 0x000D8658 File Offset: 0x000D6858
			// (set) Token: 0x06003342 RID: 13122 RVA: 0x0001842D File Offset: 0x0001662D
			public unsafe static TimerCallback __9__36_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__36_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__36_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700101F RID: 4127
			// (get) Token: 0x06003343 RID: 13123 RVA: 0x000D8680 File Offset: 0x000D6880
			// (set) Token: 0x06003344 RID: 13124 RVA: 0x0001843F File Offset: 0x0001663F
			public unsafe static Action<Object> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001020 RID: 4128
			// (get) Token: 0x06003345 RID: 13125 RVA: 0x000D86A8 File Offset: 0x000D68A8
			// (set) Token: 0x06003346 RID: 13126 RVA: 0x00018451 File Offset: 0x00016651
			public unsafe static Action<Task> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Task>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001021 RID: 4129
			// (get) Token: 0x06003347 RID: 13127 RVA: 0x000D86D0 File Offset: 0x000D68D0
			// (set) Token: 0x06003348 RID: 13128 RVA: 0x00018463 File Offset: 0x00016663
			public unsafe static Action<Object> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002747 RID: 10055
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002748 RID: 10056
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x04002749 RID: 10057
			private static readonly IntPtr NativeFieldInfoPtr___9__36_1;

			// Token: 0x0400274A RID: 10058
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x0400274B RID: 10059
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x0400274C RID: 10060
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x0400274D RID: 10061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400274E RID: 10062
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__36_0_Internal_Void_Object_0;

			// Token: 0x0400274F RID: 10063
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__36_1_Internal_Void_Object_0;

			// Token: 0x04002750 RID: 10064
			private static readonly IntPtr NativeMethodInfoPtr__SendFrameFallbackAsync_b__56_0_Internal_Void_Object_0;

			// Token: 0x04002751 RID: 10065
			private static readonly IntPtr NativeMethodInfoPtr__SendKeepAliveFrameAsync_b__58_0_Internal_Void_Task_0;

			// Token: 0x04002752 RID: 10066
			private static readonly IntPtr NativeMethodInfoPtr__WaitForServerToCloseConnectionAsync_b__63_0_Internal_Void_Object_0;
		}

		// Token: 0x0200037B RID: 891
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<WaitForWriteTaskAsync>d__55")]
		public sealed class _WaitForWriteTaskAsync_d__55 : ValueType
		{
			// Token: 0x06003349 RID: 13129 RVA: 0x000D86F8 File Offset: 0x000D68F8
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForWriteTaskAsync_d__55()
			{
				Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<WaitForWriteTaskAsync>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr);
				ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr_writeTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr, "writeTask");
				ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr, 100669227);
				ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr, 100669228);
			}

			// Token: 0x0600334A RID: 13130 RVA: 0x000D87B0 File Offset: 0x000D69B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491206, XrefRangeEnd = 491244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600334B RID: 13131 RVA: 0x000D87E8 File Offset: 0x000D69E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491244, XrefRangeEnd = 491248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600334C RID: 13132 RVA: 0x00018475 File Offset: 0x00016675
			public _WaitForWriteTaskAsync_d__55(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600334D RID: 13133 RVA: 0x0001847E File Offset: 0x0001667E
			public _WaitForWriteTaskAsync_d__55()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._WaitForWriteTaskAsync_d__55>.NativeClassPtr))
			{
			}

			// Token: 0x17001022 RID: 4130
			// (get) Token: 0x0600334E RID: 13134 RVA: 0x000D8830 File Offset: 0x000D6A30
			// (set) Token: 0x0600334F RID: 13135 RVA: 0x00018490 File Offset: 0x00016690
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001023 RID: 4131
			// (get) Token: 0x06003350 RID: 13136 RVA: 0x000D8858 File Offset: 0x000D6A58
			// (set) Token: 0x06003351 RID: 13137 RVA: 0x000184AB File Offset: 0x000166AB
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001024 RID: 4132
			// (get) Token: 0x06003352 RID: 13138 RVA: 0x000D8888 File Offset: 0x000D6A88
			// (set) Token: 0x06003353 RID: 13139 RVA: 0x000184D9 File Offset: 0x000166D9
			public ValueTask writeTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr_writeTask);
					return new ValueTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr_writeTask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001025 RID: 4133
			// (get) Token: 0x06003354 RID: 13140 RVA: 0x000D88B8 File Offset: 0x000D6AB8
			// (set) Token: 0x06003355 RID: 13141 RVA: 0x00018507 File Offset: 0x00016707
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001026 RID: 4134
			// (get) Token: 0x06003356 RID: 13142 RVA: 0x000D88E8 File Offset: 0x000D6AE8
			// (set) Token: 0x06003357 RID: 13143 RVA: 0x00018526 File Offset: 0x00016726
			public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForWriteTaskAsync_d__55.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002753 RID: 10067
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002754 RID: 10068
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002755 RID: 10069
			private static readonly IntPtr NativeFieldInfoPtr_writeTask;

			// Token: 0x04002756 RID: 10070
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002757 RID: 10071
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002758 RID: 10072
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002759 RID: 10073
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200037C RID: 892
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<SendFrameFallbackAsync>d__56")]
		public sealed class _SendFrameFallbackAsync_d__56 : ValueType
		{
			// Token: 0x06003358 RID: 13144 RVA: 0x000D8918 File Offset: 0x000D6B18
			// Note: this type is marked as 'beforefieldinit'.
			static _SendFrameFallbackAsync_d__56()
			{
				Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<SendFrameFallbackAsync>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr);
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "opcode");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_endOfMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "endOfMessage");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_payloadBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "payloadBuffer");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "<>7__wrap1");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, "<>u__2");
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, 100669229);
				ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr, 100669230);
			}

			// Token: 0x06003359 RID: 13145 RVA: 0x000D8A34 File Offset: 0x000D6C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491248, XrefRangeEnd = 491312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600335A RID: 13146 RVA: 0x000D8A6C File Offset: 0x000D6C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491312, XrefRangeEnd = 491316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600335B RID: 13147 RVA: 0x00018554 File Offset: 0x00016754
			public _SendFrameFallbackAsync_d__56(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600335C RID: 13148 RVA: 0x0001855D File Offset: 0x0001675D
			public _SendFrameFallbackAsync_d__56()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._SendFrameFallbackAsync_d__56>.NativeClassPtr))
			{
			}

			// Token: 0x17001027 RID: 4135
			// (get) Token: 0x0600335D RID: 13149 RVA: 0x000D8AB4 File Offset: 0x000D6CB4
			// (set) Token: 0x0600335E RID: 13150 RVA: 0x0001856F File Offset: 0x0001676F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001028 RID: 4136
			// (get) Token: 0x0600335F RID: 13151 RVA: 0x000D8ADC File Offset: 0x000D6CDC
			// (set) Token: 0x06003360 RID: 13152 RVA: 0x0001858A File Offset: 0x0001678A
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001029 RID: 4137
			// (get) Token: 0x06003361 RID: 13153 RVA: 0x000D8B0C File Offset: 0x000D6D0C
			// (set) Token: 0x06003362 RID: 13154 RVA: 0x000185B8 File Offset: 0x000167B8
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700102A RID: 4138
			// (get) Token: 0x06003363 RID: 13155 RVA: 0x000D8B3C File Offset: 0x000D6D3C
			// (set) Token: 0x06003364 RID: 13156 RVA: 0x000185D7 File Offset: 0x000167D7
			public unsafe ManagedWebSocket.MessageOpcode opcode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_opcode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_opcode)) = value;
				}
			}

			// Token: 0x1700102B RID: 4139
			// (get) Token: 0x06003365 RID: 13157 RVA: 0x000D8B64 File Offset: 0x000D6D64
			// (set) Token: 0x06003366 RID: 13158 RVA: 0x000185F2 File Offset: 0x000167F2
			public unsafe bool endOfMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_endOfMessage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_endOfMessage)) = value;
				}
			}

			// Token: 0x1700102C RID: 4140
			// (get) Token: 0x06003367 RID: 13159 RVA: 0x000D8B8C File Offset: 0x000D6D8C
			// (set) Token: 0x06003368 RID: 13160 RVA: 0x0001860D File Offset: 0x0001680D
			public ReadOnlyMemory<byte> payloadBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_payloadBuffer);
					return new ReadOnlyMemory<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyMemory<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_payloadBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyMemory<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700102D RID: 4141
			// (get) Token: 0x06003369 RID: 13161 RVA: 0x000D8BBC File Offset: 0x000D6DBC
			// (set) Token: 0x0600336A RID: 13162 RVA: 0x0001863B File Offset: 0x0001683B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700102E RID: 4142
			// (get) Token: 0x0600336B RID: 13163 RVA: 0x000D8BEC File Offset: 0x000D6DEC
			// (set) Token: 0x0600336C RID: 13164 RVA: 0x00018669 File Offset: 0x00016869
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700102F RID: 4143
			// (get) Token: 0x0600336D RID: 13165 RVA: 0x000D8C1C File Offset: 0x000D6E1C
			// (set) Token: 0x0600336E RID: 13166 RVA: 0x00018697 File Offset: 0x00016897
			public CancellationTokenRegistration __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___7__wrap1);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001030 RID: 4144
			// (get) Token: 0x0600336F RID: 13167 RVA: 0x000D8C4C File Offset: 0x000D6E4C
			// (set) Token: 0x06003370 RID: 13168 RVA: 0x000186C5 File Offset: 0x000168C5
			public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___u__2);
					return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendFrameFallbackAsync_d__56.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400275A RID: 10074
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400275B RID: 10075
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400275C RID: 10076
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400275D RID: 10077
			private static readonly IntPtr NativeFieldInfoPtr_opcode;

			// Token: 0x0400275E RID: 10078
			private static readonly IntPtr NativeFieldInfoPtr_endOfMessage;

			// Token: 0x0400275F RID: 10079
			private static readonly IntPtr NativeFieldInfoPtr_payloadBuffer;

			// Token: 0x04002760 RID: 10080
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002761 RID: 10081
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002762 RID: 10082
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04002763 RID: 10083
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002764 RID: 10084
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002765 RID: 10085
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200037D RID: 893
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<>c__61`2")]
		[Serializable]
		public sealed class __c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> : Object where TWebSocketReceiveResultGetter : new()
		{
			// Token: 0x06003371 RID: 13169 RVA: 0x000D8C7C File Offset: 0x000D6E7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__61()
			{
				Il2CppClassPointerStore<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<>c__61`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TWebSocketReceiveResultGetter>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TWebSocketReceiveResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr);
				ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<>9");
				ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<>9__61_0");
				ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, 100669232);
				ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr__ReceiveAsyncPrivate_b__61_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, 100669233);
			}

			// Token: 0x06003372 RID: 13170 RVA: 0x000D8D44 File Offset: 0x000D6F44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__61()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003373 RID: 13171 RVA: 0x000D8D80 File Offset: 0x000D6F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491316, XrefRangeEnd = 491320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReceiveAsyncPrivate_b__61_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr__ReceiveAsyncPrivate_b__61_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003374 RID: 13172 RVA: 0x000186F3 File Offset: 0x000168F3
			public __c__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001031 RID: 4145
			// (get) Token: 0x06003375 RID: 13173 RVA: 0x000D8DC4 File Offset: 0x000D6FC4
			// (set) Token: 0x06003376 RID: 13174 RVA: 0x000186FC File Offset: 0x000168FC
			public unsafe static ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001032 RID: 4146
			// (get) Token: 0x06003377 RID: 13175 RVA: 0x000D8DEC File Offset: 0x000D6FEC
			// (set) Token: 0x06003378 RID: 13176 RVA: 0x0001870E File Offset: 0x0001690E
			public unsafe static Action<Object> __9__61_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagedWebSocket.__c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___9__61_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002766 RID: 10086
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002767 RID: 10087
			private static readonly IntPtr NativeFieldInfoPtr___9__61_0;

			// Token: 0x04002768 RID: 10088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002769 RID: 10089
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveAsyncPrivate_b__61_0_Internal_Void_Object_0;
		}

		// Token: 0x0200037E RID: 894
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<ReceiveAsyncPrivate>d__61`2")]
		public sealed class _ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> : ValueType where TWebSocketReceiveResultGetter : new()
		{
			// Token: 0x06003379 RID: 13177 RVA: 0x000D8E14 File Offset: 0x000D7014
			// Note: this type is marked as 'beforefieldinit'.
			static _ReceiveAsyncPrivate_d__61()
			{
				Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<ReceiveAsyncPrivate>d__61`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TWebSocketReceiveResultGetter>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TWebSocketReceiveResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr);
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_resultGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "resultGetter");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_payloadBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "payloadBuffer");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__registration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<registration>5__2");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__header_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<header>5__3");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__totalBytesReceived_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<totalBytesReceived>5__4");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, "<>u__2");
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, 100669234);
				ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr, 100669235);
			}

			// Token: 0x0600337A RID: 13178 RVA: 0x000D8F90 File Offset: 0x000D7190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491320, XrefRangeEnd = 491723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600337B RID: 13179 RVA: 0x000D8FC8 File Offset: 0x000D71C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491723, XrefRangeEnd = 491731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600337C RID: 13180 RVA: 0x00018720 File Offset: 0x00016920
			public _ReceiveAsyncPrivate_d__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600337D RID: 13181 RVA: 0x00018729 File Offset: 0x00016929
			public _ReceiveAsyncPrivate_d__61()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>>.NativeClassPtr))
			{
			}

			// Token: 0x17001033 RID: 4147
			// (get) Token: 0x0600337E RID: 13182 RVA: 0x000D9010 File Offset: 0x000D7210
			// (set) Token: 0x0600337F RID: 13183 RVA: 0x0001873B File Offset: 0x0001693B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001034 RID: 4148
			// (get) Token: 0x06003380 RID: 13184 RVA: 0x000D9038 File Offset: 0x000D7238
			// (set) Token: 0x06003381 RID: 13185 RVA: 0x00018756 File Offset: 0x00016956
			public AsyncValueTaskMethodBuilder<TWebSocketReceiveResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___t__builder);
					return new AsyncValueTaskMethodBuilder<TWebSocketReceiveResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TWebSocketReceiveResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TWebSocketReceiveResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001035 RID: 4149
			// (get) Token: 0x06003382 RID: 13186 RVA: 0x000D9068 File Offset: 0x000D7268
			// (set) Token: 0x06003383 RID: 13187 RVA: 0x00018784 File Offset: 0x00016984
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001036 RID: 4150
			// (get) Token: 0x06003384 RID: 13188 RVA: 0x000D9098 File Offset: 0x000D7298
			// (set) Token: 0x06003385 RID: 13189 RVA: 0x000187B2 File Offset: 0x000169B2
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001037 RID: 4151
			// (get) Token: 0x06003386 RID: 13190 RVA: 0x000D90C8 File Offset: 0x000D72C8
			// (set) Token: 0x06003387 RID: 13191 RVA: 0x000D90F0 File Offset: 0x000D72F0
			public unsafe TWebSocketReceiveResultGetter resultGetter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_resultGetter);
					return IL2CPP.PointerToValueGeneric<TWebSocketReceiveResultGetter>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_resultGetter);
					Type typeFromHandle = typeof(TWebSocketReceiveResultGetter);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17001038 RID: 4152
			// (get) Token: 0x06003388 RID: 13192 RVA: 0x000D9198 File Offset: 0x000D7398
			// (set) Token: 0x06003389 RID: 13193 RVA: 0x000187D1 File Offset: 0x000169D1
			public Memory<byte> payloadBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_payloadBuffer);
					return new Memory<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr_payloadBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001039 RID: 4153
			// (get) Token: 0x0600338A RID: 13194 RVA: 0x000D91C8 File Offset: 0x000D73C8
			// (set) Token: 0x0600338B RID: 13195 RVA: 0x000187FF File Offset: 0x000169FF
			public CancellationTokenRegistration _registration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__registration_5__2);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__registration_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700103A RID: 4154
			// (get) Token: 0x0600338C RID: 13196 RVA: 0x000D91F8 File Offset: 0x000D73F8
			// (set) Token: 0x0600338D RID: 13197 RVA: 0x0001882D File Offset: 0x00016A2D
			public unsafe ManagedWebSocket.MessageHeader _header_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__header_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__header_5__3)) = value;
				}
			}

			// Token: 0x1700103B RID: 4155
			// (get) Token: 0x0600338E RID: 13198 RVA: 0x000D9220 File Offset: 0x000D7420
			// (set) Token: 0x0600338F RID: 13199 RVA: 0x00018848 File Offset: 0x00016A48
			public unsafe int _totalBytesReceived_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__totalBytesReceived_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr__totalBytesReceived_5__4)) = value;
				}
			}

			// Token: 0x1700103C RID: 4156
			// (get) Token: 0x06003390 RID: 13200 RVA: 0x000D9248 File Offset: 0x000D7448
			// (set) Token: 0x06003391 RID: 13201 RVA: 0x00018863 File Offset: 0x00016A63
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700103D RID: 4157
			// (get) Token: 0x06003392 RID: 13202 RVA: 0x000D9278 File Offset: 0x000D7478
			// (set) Token: 0x06003393 RID: 13203 RVA: 0x00018891 File Offset: 0x00016A91
			public ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___u__2);
					return new ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._ReceiveAsyncPrivate_d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400276A RID: 10090
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400276B RID: 10091
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400276C RID: 10092
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400276D RID: 10093
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400276E RID: 10094
			private static readonly IntPtr NativeFieldInfoPtr_resultGetter;

			// Token: 0x0400276F RID: 10095
			private static readonly IntPtr NativeFieldInfoPtr_payloadBuffer;

			// Token: 0x04002770 RID: 10096
			private static readonly IntPtr NativeFieldInfoPtr__registration_5__2;

			// Token: 0x04002771 RID: 10097
			private static readonly IntPtr NativeFieldInfoPtr__header_5__3;

			// Token: 0x04002772 RID: 10098
			private static readonly IntPtr NativeFieldInfoPtr__totalBytesReceived_5__4;

			// Token: 0x04002773 RID: 10099
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002774 RID: 10100
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002775 RID: 10101
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002776 RID: 10102
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200037F RID: 895
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<HandleReceivedCloseAsync>d__62")]
		public sealed class _HandleReceivedCloseAsync_d__62 : ValueType
		{
			// Token: 0x06003394 RID: 13204 RVA: 0x000D92A8 File Offset: 0x000D74A8
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleReceivedCloseAsync_d__62()
			{
				Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<HandleReceivedCloseAsync>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr);
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "header");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr__closeStatus_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "<closeStatus>5__2");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr__closeStatusDescription_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "<closeStatusDescription>5__3");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, 100669236);
				ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr, 100669237);
			}

			// Token: 0x06003395 RID: 13205 RVA: 0x000D939C File Offset: 0x000D759C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491731, XrefRangeEnd = 491829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003396 RID: 13206 RVA: 0x000D93D4 File Offset: 0x000D75D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491829, XrefRangeEnd = 491833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003397 RID: 13207 RVA: 0x000188BF File Offset: 0x00016ABF
			public _HandleReceivedCloseAsync_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003398 RID: 13208 RVA: 0x000188C8 File Offset: 0x00016AC8
			public _HandleReceivedCloseAsync_d__62()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedCloseAsync_d__62>.NativeClassPtr))
			{
			}

			// Token: 0x1700103E RID: 4158
			// (get) Token: 0x06003399 RID: 13209 RVA: 0x000D941C File Offset: 0x000D761C
			// (set) Token: 0x0600339A RID: 13210 RVA: 0x000188DA File Offset: 0x00016ADA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700103F RID: 4159
			// (get) Token: 0x0600339B RID: 13211 RVA: 0x000D9444 File Offset: 0x000D7644
			// (set) Token: 0x0600339C RID: 13212 RVA: 0x000188F5 File Offset: 0x00016AF5
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001040 RID: 4160
			// (get) Token: 0x0600339D RID: 13213 RVA: 0x000D9474 File Offset: 0x000D7674
			// (set) Token: 0x0600339E RID: 13214 RVA: 0x00018923 File Offset: 0x00016B23
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001041 RID: 4161
			// (get) Token: 0x0600339F RID: 13215 RVA: 0x000D94A4 File Offset: 0x000D76A4
			// (set) Token: 0x060033A0 RID: 13216 RVA: 0x00018942 File Offset: 0x00016B42
			public unsafe ManagedWebSocket.MessageHeader header
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr_header);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr_header)) = value;
				}
			}

			// Token: 0x17001042 RID: 4162
			// (get) Token: 0x060033A1 RID: 13217 RVA: 0x000D94CC File Offset: 0x000D76CC
			// (set) Token: 0x060033A2 RID: 13218 RVA: 0x0001895D File Offset: 0x00016B5D
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001043 RID: 4163
			// (get) Token: 0x060033A3 RID: 13219 RVA: 0x000D94FC File Offset: 0x000D76FC
			// (set) Token: 0x060033A4 RID: 13220 RVA: 0x0001898B File Offset: 0x00016B8B
			public unsafe WebSocketCloseStatus _closeStatus_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr__closeStatus_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr__closeStatus_5__2)) = value;
				}
			}

			// Token: 0x17001044 RID: 4164
			// (get) Token: 0x060033A5 RID: 13221 RVA: 0x000D9524 File Offset: 0x000D7724
			// (set) Token: 0x060033A6 RID: 13222 RVA: 0x000189A6 File Offset: 0x00016BA6
			public unsafe string _closeStatusDescription_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr__closeStatusDescription_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr__closeStatusDescription_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001045 RID: 4165
			// (get) Token: 0x060033A7 RID: 13223 RVA: 0x000D954C File Offset: 0x000D774C
			// (set) Token: 0x060033A8 RID: 13224 RVA: 0x000189C5 File Offset: 0x00016BC5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedCloseAsync_d__62.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002777 RID: 10103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002778 RID: 10104
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002779 RID: 10105
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400277A RID: 10106
			private static readonly IntPtr NativeFieldInfoPtr_header;

			// Token: 0x0400277B RID: 10107
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400277C RID: 10108
			private static readonly IntPtr NativeFieldInfoPtr__closeStatus_5__2;

			// Token: 0x0400277D RID: 10109
			private static readonly IntPtr NativeFieldInfoPtr__closeStatusDescription_5__3;

			// Token: 0x0400277E RID: 10110
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400277F RID: 10111
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002780 RID: 10112
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000380 RID: 896
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<WaitForServerToCloseConnectionAsync>d__63")]
		public sealed class _WaitForServerToCloseConnectionAsync_d__63 : ValueType
		{
			// Token: 0x060033A9 RID: 13225 RVA: 0x000D957C File Offset: 0x000D777C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForServerToCloseConnectionAsync_d__63()
			{
				Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<WaitForServerToCloseConnectionAsync>d__63");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr);
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr__finalCts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, "<finalCts>5__2");
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, "<>7__wrap2");
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, 100669238);
				ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr, 100669239);
			}

			// Token: 0x060033AA RID: 13226 RVA: 0x000D965C File Offset: 0x000D785C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491833, XrefRangeEnd = 491911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033AB RID: 13227 RVA: 0x000D9694 File Offset: 0x000D7894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491911, XrefRangeEnd = 491915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033AC RID: 13228 RVA: 0x000189F3 File Offset: 0x00016BF3
			public _WaitForServerToCloseConnectionAsync_d__63(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060033AD RID: 13229 RVA: 0x000189FC File Offset: 0x00016BFC
			public _WaitForServerToCloseConnectionAsync_d__63()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63>.NativeClassPtr))
			{
			}

			// Token: 0x17001046 RID: 4166
			// (get) Token: 0x060033AE RID: 13230 RVA: 0x000D96DC File Offset: 0x000D78DC
			// (set) Token: 0x060033AF RID: 13231 RVA: 0x00018A0E File Offset: 0x00016C0E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001047 RID: 4167
			// (get) Token: 0x060033B0 RID: 13232 RVA: 0x000D9704 File Offset: 0x000D7904
			// (set) Token: 0x060033B1 RID: 13233 RVA: 0x00018A29 File Offset: 0x00016C29
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001048 RID: 4168
			// (get) Token: 0x060033B2 RID: 13234 RVA: 0x000D9734 File Offset: 0x000D7934
			// (set) Token: 0x060033B3 RID: 13235 RVA: 0x00018A57 File Offset: 0x00016C57
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001049 RID: 4169
			// (get) Token: 0x060033B4 RID: 13236 RVA: 0x000D9764 File Offset: 0x000D7964
			// (set) Token: 0x060033B5 RID: 13237 RVA: 0x00018A76 File Offset: 0x00016C76
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700104A RID: 4170
			// (get) Token: 0x060033B6 RID: 13238 RVA: 0x000D9794 File Offset: 0x000D7994
			// (set) Token: 0x060033B7 RID: 13239 RVA: 0x00018AA4 File Offset: 0x00016CA4
			public unsafe CancellationTokenSource _finalCts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr__finalCts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr__finalCts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700104B RID: 4171
			// (get) Token: 0x060033B8 RID: 13240 RVA: 0x000D97C4 File Offset: 0x000D79C4
			// (set) Token: 0x060033B9 RID: 13241 RVA: 0x00018AC3 File Offset: 0x00016CC3
			public CancellationTokenRegistration __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___7__wrap2);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700104C RID: 4172
			// (get) Token: 0x060033BA RID: 13242 RVA: 0x000D97F4 File Offset: 0x000D79F4
			// (set) Token: 0x060033BB RID: 13243 RVA: 0x00018AF1 File Offset: 0x00016CF1
			public ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._WaitForServerToCloseConnectionAsync_d__63.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002781 RID: 10113
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002782 RID: 10114
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002783 RID: 10115
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002784 RID: 10116
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002785 RID: 10117
			private static readonly IntPtr NativeFieldInfoPtr__finalCts_5__2;

			// Token: 0x04002786 RID: 10118
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04002787 RID: 10119
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002788 RID: 10120
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002789 RID: 10121
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000381 RID: 897
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<HandleReceivedPingPongAsync>d__64")]
		public sealed class _HandleReceivedPingPongAsync_d__64 : ValueType
		{
			// Token: 0x060033BC RID: 13244 RVA: 0x000D9824 File Offset: 0x000D7A24
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleReceivedPingPongAsync_d__64()
			{
				Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<HandleReceivedPingPongAsync>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr);
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, "header");
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, "<>u__2");
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, 100669240);
				ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr, 100669241);
			}

			// Token: 0x060033BD RID: 13245 RVA: 0x000D9904 File Offset: 0x000D7B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491915, XrefRangeEnd = 491968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033BE RID: 13246 RVA: 0x000D993C File Offset: 0x000D7B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491968, XrefRangeEnd = 491972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033BF RID: 13247 RVA: 0x00018B1F File Offset: 0x00016D1F
			public _HandleReceivedPingPongAsync_d__64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060033C0 RID: 13248 RVA: 0x00018B28 File Offset: 0x00016D28
			public _HandleReceivedPingPongAsync_d__64()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._HandleReceivedPingPongAsync_d__64>.NativeClassPtr))
			{
			}

			// Token: 0x1700104D RID: 4173
			// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000D9984 File Offset: 0x000D7B84
			// (set) Token: 0x060033C2 RID: 13250 RVA: 0x00018B3A File Offset: 0x00016D3A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700104E RID: 4174
			// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000D99AC File Offset: 0x000D7BAC
			// (set) Token: 0x060033C4 RID: 13252 RVA: 0x00018B55 File Offset: 0x00016D55
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700104F RID: 4175
			// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000D99DC File Offset: 0x000D7BDC
			// (set) Token: 0x060033C6 RID: 13254 RVA: 0x00018B83 File Offset: 0x00016D83
			public unsafe ManagedWebSocket.MessageHeader header
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr_header);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr_header)) = value;
				}
			}

			// Token: 0x17001050 RID: 4176
			// (get) Token: 0x060033C7 RID: 13255 RVA: 0x000D9A04 File Offset: 0x000D7C04
			// (set) Token: 0x060033C8 RID: 13256 RVA: 0x00018B9E File Offset: 0x00016D9E
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001051 RID: 4177
			// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000D9A34 File Offset: 0x000D7C34
			// (set) Token: 0x060033CA RID: 13258 RVA: 0x00018BBD File Offset: 0x00016DBD
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001052 RID: 4178
			// (get) Token: 0x060033CB RID: 13259 RVA: 0x000D9A64 File Offset: 0x000D7C64
			// (set) Token: 0x060033CC RID: 13260 RVA: 0x00018BEB File Offset: 0x00016DEB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001053 RID: 4179
			// (get) Token: 0x060033CD RID: 13261 RVA: 0x000D9A94 File Offset: 0x000D7C94
			// (set) Token: 0x060033CE RID: 13262 RVA: 0x00018C19 File Offset: 0x00016E19
			public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___u__2);
					return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._HandleReceivedPingPongAsync_d__64.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400278A RID: 10122
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400278B RID: 10123
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400278C RID: 10124
			private static readonly IntPtr NativeFieldInfoPtr_header;

			// Token: 0x0400278D RID: 10125
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400278E RID: 10126
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400278F RID: 10127
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002790 RID: 10128
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002791 RID: 10129
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002792 RID: 10130
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000382 RID: 898
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<CloseWithReceiveErrorAndThrowAsync>d__66")]
		public sealed class _CloseWithReceiveErrorAndThrowAsync_d__66 : ValueType
		{
			// Token: 0x060033CF RID: 13263 RVA: 0x000D9AC4 File Offset: 0x000D7CC4
			// Note: this type is marked as 'beforefieldinit'.
			static _CloseWithReceiveErrorAndThrowAsync_d__66()
			{
				Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<CloseWithReceiveErrorAndThrowAsync>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr);
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_closeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, "closeStatus");
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, "error");
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, "innerException");
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, 100669242);
				ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr, 100669243);
			}

			// Token: 0x060033D0 RID: 13264 RVA: 0x000D9BA4 File Offset: 0x000D7DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491972, XrefRangeEnd = 491989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033D1 RID: 13265 RVA: 0x000D9BDC File Offset: 0x000D7DDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491989, XrefRangeEnd = 491993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033D2 RID: 13266 RVA: 0x00018C47 File Offset: 0x00016E47
			public _CloseWithReceiveErrorAndThrowAsync_d__66(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060033D3 RID: 13267 RVA: 0x00018C50 File Offset: 0x00016E50
			public _CloseWithReceiveErrorAndThrowAsync_d__66()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66>.NativeClassPtr))
			{
			}

			// Token: 0x17001054 RID: 4180
			// (get) Token: 0x060033D4 RID: 13268 RVA: 0x000D9C24 File Offset: 0x000D7E24
			// (set) Token: 0x060033D5 RID: 13269 RVA: 0x00018C62 File Offset: 0x00016E62
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001055 RID: 4181
			// (get) Token: 0x060033D6 RID: 13270 RVA: 0x000D9C4C File Offset: 0x000D7E4C
			// (set) Token: 0x060033D7 RID: 13271 RVA: 0x00018C7D File Offset: 0x00016E7D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001056 RID: 4182
			// (get) Token: 0x060033D8 RID: 13272 RVA: 0x000D9C7C File Offset: 0x000D7E7C
			// (set) Token: 0x060033D9 RID: 13273 RVA: 0x00018CAB File Offset: 0x00016EAB
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001057 RID: 4183
			// (get) Token: 0x060033DA RID: 13274 RVA: 0x000D9CAC File Offset: 0x000D7EAC
			// (set) Token: 0x060033DB RID: 13275 RVA: 0x00018CCA File Offset: 0x00016ECA
			public unsafe WebSocketCloseStatus closeStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_closeStatus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_closeStatus)) = value;
				}
			}

			// Token: 0x17001058 RID: 4184
			// (get) Token: 0x060033DC RID: 13276 RVA: 0x000D9CD4 File Offset: 0x000D7ED4
			// (set) Token: 0x060033DD RID: 13277 RVA: 0x00018CE5 File Offset: 0x00016EE5
			public unsafe WebSocketError error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_error);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_error)) = value;
				}
			}

			// Token: 0x17001059 RID: 4185
			// (get) Token: 0x060033DE RID: 13278 RVA: 0x000D9CFC File Offset: 0x000D7EFC
			// (set) Token: 0x060033DF RID: 13279 RVA: 0x00018D00 File Offset: 0x00016F00
			public unsafe Exception innerException
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_innerException);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr_innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105A RID: 4186
			// (get) Token: 0x060033E0 RID: 13280 RVA: 0x000D9D2C File Offset: 0x000D7F2C
			// (set) Token: 0x060033E1 RID: 13281 RVA: 0x00018D1F File Offset: 0x00016F1F
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseWithReceiveErrorAndThrowAsync_d__66.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002793 RID: 10131
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002794 RID: 10132
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002795 RID: 10133
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002796 RID: 10134
			private static readonly IntPtr NativeFieldInfoPtr_closeStatus;

			// Token: 0x04002797 RID: 10135
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x04002798 RID: 10136
			private static readonly IntPtr NativeFieldInfoPtr_innerException;

			// Token: 0x04002799 RID: 10137
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400279A RID: 10138
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400279B RID: 10139
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000383 RID: 899
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<CloseAsyncPrivate>d__68")]
		public sealed class _CloseAsyncPrivate_d__68 : ValueType
		{
			// Token: 0x060033E2 RID: 13282 RVA: 0x000D9D5C File Offset: 0x000D7F5C
			// Note: this type is marked as 'beforefieldinit'.
			static _CloseAsyncPrivate_d__68()
			{
				Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<CloseAsyncPrivate>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr);
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_closeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "closeStatus");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_statusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "statusDescription");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr__closeBuffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "<closeBuffer>5__2");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, 100669244);
				ManagedWebSocket._CloseAsyncPrivate_d__68.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr, 100669245);
			}

			// Token: 0x060033E3 RID: 13283 RVA: 0x000D9E50 File Offset: 0x000D8050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491993, XrefRangeEnd = 492046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033E4 RID: 13284 RVA: 0x000D9E88 File Offset: 0x000D8088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492046, XrefRangeEnd = 492050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033E5 RID: 13285 RVA: 0x00018D4D File Offset: 0x00016F4D
			public _CloseAsyncPrivate_d__68(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060033E6 RID: 13286 RVA: 0x00018D56 File Offset: 0x00016F56
			public _CloseAsyncPrivate_d__68()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._CloseAsyncPrivate_d__68>.NativeClassPtr))
			{
			}

			// Token: 0x1700105B RID: 4187
			// (get) Token: 0x060033E7 RID: 13287 RVA: 0x000D9ED0 File Offset: 0x000D80D0
			// (set) Token: 0x060033E8 RID: 13288 RVA: 0x00018D68 File Offset: 0x00016F68
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700105C RID: 4188
			// (get) Token: 0x060033E9 RID: 13289 RVA: 0x000D9EF8 File Offset: 0x000D80F8
			// (set) Token: 0x060033EA RID: 13290 RVA: 0x00018D83 File Offset: 0x00016F83
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700105D RID: 4189
			// (get) Token: 0x060033EB RID: 13291 RVA: 0x000D9F28 File Offset: 0x000D8128
			// (set) Token: 0x060033EC RID: 13292 RVA: 0x00018DB1 File Offset: 0x00016FB1
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105E RID: 4190
			// (get) Token: 0x060033ED RID: 13293 RVA: 0x000D9F58 File Offset: 0x000D8158
			// (set) Token: 0x060033EE RID: 13294 RVA: 0x00018DD0 File Offset: 0x00016FD0
			public unsafe WebSocketCloseStatus closeStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_closeStatus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_closeStatus)) = value;
				}
			}

			// Token: 0x1700105F RID: 4191
			// (get) Token: 0x060033EF RID: 13295 RVA: 0x000D9F80 File Offset: 0x000D8180
			// (set) Token: 0x060033F0 RID: 13296 RVA: 0x00018DEB File Offset: 0x00016FEB
			public unsafe string statusDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_statusDescription);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_statusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001060 RID: 4192
			// (get) Token: 0x060033F1 RID: 13297 RVA: 0x000D9FA8 File Offset: 0x000D81A8
			// (set) Token: 0x060033F2 RID: 13298 RVA: 0x00018E0A File Offset: 0x0001700A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001061 RID: 4193
			// (get) Token: 0x060033F3 RID: 13299 RVA: 0x000D9FD8 File Offset: 0x000D81D8
			// (set) Token: 0x060033F4 RID: 13300 RVA: 0x00018E38 File Offset: 0x00017038
			public unsafe Il2CppStructArray<byte> _closeBuffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr__closeBuffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr__closeBuffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001062 RID: 4194
			// (get) Token: 0x060033F5 RID: 13301 RVA: 0x000DA008 File Offset: 0x000D8208
			// (set) Token: 0x060033F6 RID: 13302 RVA: 0x00018E57 File Offset: 0x00017057
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._CloseAsyncPrivate_d__68.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400279C RID: 10140
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400279D RID: 10141
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400279E RID: 10142
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400279F RID: 10143
			private static readonly IntPtr NativeFieldInfoPtr_closeStatus;

			// Token: 0x040027A0 RID: 10144
			private static readonly IntPtr NativeFieldInfoPtr_statusDescription;

			// Token: 0x040027A1 RID: 10145
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040027A2 RID: 10146
			private static readonly IntPtr NativeFieldInfoPtr__closeBuffer_5__2;

			// Token: 0x040027A3 RID: 10147
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040027A4 RID: 10148
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040027A5 RID: 10149
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000384 RID: 900
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<SendCloseFrameAsync>d__69")]
		public sealed class _SendCloseFrameAsync_d__69 : ValueType
		{
			// Token: 0x060033F7 RID: 13303 RVA: 0x000DA038 File Offset: 0x000D8238
			// Note: this type is marked as 'beforefieldinit'.
			static _SendCloseFrameAsync_d__69()
			{
				Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<SendCloseFrameAsync>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr);
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_closeStatusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "closeStatusDescription");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_closeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "closeStatus");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "<buffer>5__2");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, "<>u__2");
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, 100669246);
				ManagedWebSocket._SendCloseFrameAsync_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr, 100669247);
			}

			// Token: 0x060033F8 RID: 13304 RVA: 0x000DA140 File Offset: 0x000D8340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492050, XrefRangeEnd = 492120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033F9 RID: 13305 RVA: 0x000DA178 File Offset: 0x000D8378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492120, XrefRangeEnd = 492124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033FA RID: 13306 RVA: 0x00018E85 File Offset: 0x00017085
			public _SendCloseFrameAsync_d__69(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060033FB RID: 13307 RVA: 0x00018E8E File Offset: 0x0001708E
			public _SendCloseFrameAsync_d__69()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._SendCloseFrameAsync_d__69>.NativeClassPtr))
			{
			}

			// Token: 0x17001063 RID: 4195
			// (get) Token: 0x060033FC RID: 13308 RVA: 0x000DA1C0 File Offset: 0x000D83C0
			// (set) Token: 0x060033FD RID: 13309 RVA: 0x00018EA0 File Offset: 0x000170A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001064 RID: 4196
			// (get) Token: 0x060033FE RID: 13310 RVA: 0x000DA1E8 File Offset: 0x000D83E8
			// (set) Token: 0x060033FF RID: 13311 RVA: 0x00018EBB File Offset: 0x000170BB
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001065 RID: 4197
			// (get) Token: 0x06003400 RID: 13312 RVA: 0x000DA218 File Offset: 0x000D8418
			// (set) Token: 0x06003401 RID: 13313 RVA: 0x00018EE9 File Offset: 0x000170E9
			public unsafe string closeStatusDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_closeStatusDescription);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_closeStatusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001066 RID: 4198
			// (get) Token: 0x06003402 RID: 13314 RVA: 0x000DA240 File Offset: 0x000D8440
			// (set) Token: 0x06003403 RID: 13315 RVA: 0x00018F08 File Offset: 0x00017108
			public unsafe WebSocketCloseStatus closeStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_closeStatus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_closeStatus)) = value;
				}
			}

			// Token: 0x17001067 RID: 4199
			// (get) Token: 0x06003404 RID: 13316 RVA: 0x000DA268 File Offset: 0x000D8468
			// (set) Token: 0x06003405 RID: 13317 RVA: 0x00018F23 File Offset: 0x00017123
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001068 RID: 4200
			// (get) Token: 0x06003406 RID: 13318 RVA: 0x000DA298 File Offset: 0x000D8498
			// (set) Token: 0x06003407 RID: 13319 RVA: 0x00018F42 File Offset: 0x00017142
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001069 RID: 4201
			// (get) Token: 0x06003408 RID: 13320 RVA: 0x000DA2C8 File Offset: 0x000D84C8
			// (set) Token: 0x06003409 RID: 13321 RVA: 0x00018F70 File Offset: 0x00017170
			public unsafe Il2CppStructArray<byte> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr__buffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr__buffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106A RID: 4202
			// (get) Token: 0x0600340A RID: 13322 RVA: 0x000DA2F8 File Offset: 0x000D84F8
			// (set) Token: 0x0600340B RID: 13323 RVA: 0x00018F8F File Offset: 0x0001718F
			public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700106B RID: 4203
			// (get) Token: 0x0600340C RID: 13324 RVA: 0x000DA328 File Offset: 0x000D8528
			// (set) Token: 0x0600340D RID: 13325 RVA: 0x00018FBD File Offset: 0x000171BD
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._SendCloseFrameAsync_d__69.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040027A6 RID: 10150
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040027A7 RID: 10151
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040027A8 RID: 10152
			private static readonly IntPtr NativeFieldInfoPtr_closeStatusDescription;

			// Token: 0x040027A9 RID: 10153
			private static readonly IntPtr NativeFieldInfoPtr_closeStatus;

			// Token: 0x040027AA RID: 10154
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040027AB RID: 10155
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040027AC RID: 10156
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x040027AD RID: 10157
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040027AE RID: 10158
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040027AF RID: 10159
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040027B0 RID: 10160
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000385 RID: 901
		[ObfuscatedName("System.Net.WebSockets.ManagedWebSocket+<EnsureBufferContainsAsync>d__71")]
		public sealed class _EnsureBufferContainsAsync_d__71 : ValueType
		{
			// Token: 0x0600340E RID: 13326 RVA: 0x000DA358 File Offset: 0x000D8558
			// Note: this type is marked as 'beforefieldinit'.
			static _EnsureBufferContainsAsync_d__71()
			{
				Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr, "<EnsureBufferContainsAsync>d__71");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr);
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, "<>1__state");
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, "<>t__builder");
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, "<>4__this");
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_minimumRequiredBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, "minimumRequiredBytes");
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, "cancellationToken");
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_throwOnPrematureClosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, "throwOnPrematureClosure");
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, "<>u__1");
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, 100669248);
				ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr, 100669249);
			}

			// Token: 0x0600340F RID: 13327 RVA: 0x000DA438 File Offset: 0x000D8638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492124, XrefRangeEnd = 492174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003410 RID: 13328 RVA: 0x000DA470 File Offset: 0x000D8670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 492174, XrefRangeEnd = 492178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003411 RID: 13329 RVA: 0x00018FEB File Offset: 0x000171EB
			public _EnsureBufferContainsAsync_d__71(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003412 RID: 13330 RVA: 0x00018FF4 File Offset: 0x000171F4
			public _EnsureBufferContainsAsync_d__71()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedWebSocket._EnsureBufferContainsAsync_d__71>.NativeClassPtr))
			{
			}

			// Token: 0x1700106C RID: 4204
			// (get) Token: 0x06003413 RID: 13331 RVA: 0x000DA4B8 File Offset: 0x000D86B8
			// (set) Token: 0x06003414 RID: 13332 RVA: 0x00019006 File Offset: 0x00017206
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700106D RID: 4205
			// (get) Token: 0x06003415 RID: 13333 RVA: 0x000DA4E0 File Offset: 0x000D86E0
			// (set) Token: 0x06003416 RID: 13334 RVA: 0x00019021 File Offset: 0x00017221
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700106E RID: 4206
			// (get) Token: 0x06003417 RID: 13335 RVA: 0x000DA510 File Offset: 0x000D8710
			// (set) Token: 0x06003418 RID: 13336 RVA: 0x0001904F File Offset: 0x0001724F
			public unsafe ManagedWebSocket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedWebSocket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106F RID: 4207
			// (get) Token: 0x06003419 RID: 13337 RVA: 0x000DA540 File Offset: 0x000D8740
			// (set) Token: 0x0600341A RID: 13338 RVA: 0x0001906E File Offset: 0x0001726E
			public unsafe int minimumRequiredBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_minimumRequiredBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_minimumRequiredBytes)) = value;
				}
			}

			// Token: 0x17001070 RID: 4208
			// (get) Token: 0x0600341B RID: 13339 RVA: 0x000DA568 File Offset: 0x000D8768
			// (set) Token: 0x0600341C RID: 13340 RVA: 0x00019089 File Offset: 0x00017289
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001071 RID: 4209
			// (get) Token: 0x0600341D RID: 13341 RVA: 0x000DA598 File Offset: 0x000D8798
			// (set) Token: 0x0600341E RID: 13342 RVA: 0x000190B7 File Offset: 0x000172B7
			public unsafe bool throwOnPrematureClosure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_throwOnPrematureClosure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr_throwOnPrematureClosure)) = value;
				}
			}

			// Token: 0x17001072 RID: 4210
			// (get) Token: 0x0600341F RID: 13343 RVA: 0x000DA5C0 File Offset: 0x000D87C0
			// (set) Token: 0x06003420 RID: 13344 RVA: 0x000190D2 File Offset: 0x000172D2
			public ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedWebSocket._EnsureBufferContainsAsync_d__71.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040027B1 RID: 10161
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040027B2 RID: 10162
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040027B3 RID: 10163
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040027B4 RID: 10164
			private static readonly IntPtr NativeFieldInfoPtr_minimumRequiredBytes;

			// Token: 0x040027B5 RID: 10165
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040027B6 RID: 10166
			private static readonly IntPtr NativeFieldInfoPtr_throwOnPrematureClosure;

			// Token: 0x040027B7 RID: 10167
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040027B8 RID: 10168
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040027B9 RID: 10169
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000386 RID: 902
		private sealed class MethodInfoStoreGeneric_ReceiveAsyncPrivate_Private_ValueTask_1_TWebSocketReceiveResult_Memory_1_Byte_CancellationToken_TWebSocketReceiveResultGetter_0<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>
		{
			// Token: 0x040027BA RID: 10170
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ManagedWebSocket.NativeMethodInfoPtr_ReceiveAsyncPrivate_Private_ValueTask_1_TWebSocketReceiveResult_Memory_1_Byte_CancellationToken_TWebSocketReceiveResultGetter_0, Il2CppClassPointerStore<ManagedWebSocket>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TWebSocketReceiveResultGetter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TWebSocketReceiveResult>.NativeClassPtr))
			}))));
		}
	}
}
