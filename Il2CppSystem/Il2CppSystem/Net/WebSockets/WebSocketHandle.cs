using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000256 RID: 598
	public sealed class WebSocketHandle : Object
	{
		// Token: 0x06002833 RID: 10291 RVA: 0x000B7300 File Offset: 0x000B5500
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocketHandle()
		{
			Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "WebSocketHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr);
			WebSocketHandle.NativeFieldInfoPtr_t_cachedStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "t_cachedStringBuilder");
			WebSocketHandle.NativeFieldInfoPtr_s_defaultHttpEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "s_defaultHttpEncoding");
			WebSocketHandle.NativeFieldInfoPtr_DefaultReceiveBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "DefaultReceiveBufferSize");
			WebSocketHandle.NativeFieldInfoPtr_WSServerGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "WSServerGuid");
			WebSocketHandle.NativeFieldInfoPtr__abortSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "_abortSource");
			WebSocketHandle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "_state");
			WebSocketHandle.NativeFieldInfoPtr__webSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "_webSocket");
			WebSocketHandle.NativeMethodInfoPtr_Create_Public_Static_WebSocketHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669289);
			WebSocketHandle.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_WebSocketHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669290);
			WebSocketHandle.NativeMethodInfoPtr_get_CloseStatus_Public_get_Nullable_1_WebSocketCloseStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669291);
			WebSocketHandle.NativeMethodInfoPtr_get_State_Public_get_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669292);
			WebSocketHandle.NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669293);
			WebSocketHandle.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669294);
			WebSocketHandle.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669295);
			WebSocketHandle.NativeMethodInfoPtr_SendAsync_Public_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669296);
			WebSocketHandle.NativeMethodInfoPtr_ReceiveAsync_Public_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669297);
			WebSocketHandle.NativeMethodInfoPtr_CloseAsync_Public_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669298);
			WebSocketHandle.NativeMethodInfoPtr_CloseOutputAsync_Public_Task_WebSocketCloseStatus_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669299);
			WebSocketHandle.NativeMethodInfoPtr_ConnectAsyncCore_Public_Task_Uri_CancellationToken_ClientWebSocketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669300);
			WebSocketHandle.NativeMethodInfoPtr_ConnectSocketAsync_Private_Task_1_Socket_String_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669301);
			WebSocketHandle.NativeMethodInfoPtr_BuildRequestHeader_Private_Static_Il2CppStructArray_1_Byte_Uri_ClientWebSocketOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669302);
			WebSocketHandle.NativeMethodInfoPtr_CreateSecKeyAndSecWebSocketAccept_Private_Static_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669303);
			WebSocketHandle.NativeMethodInfoPtr_ParseAndValidateConnectResponseAsync_Private_Task_1_String_Stream_ClientWebSocketOptions_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669304);
			WebSocketHandle.NativeMethodInfoPtr_ValidateAndTrackHeader_Private_Static_Void_String_String_String_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669305);
			WebSocketHandle.NativeMethodInfoPtr_ReadResponseHeaderLineAsync_Private_Static_Task_1_String_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669306);
			WebSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, 100669307);
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000B7538 File Offset: 0x000B5738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493505, XrefRangeEnd = 493514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebSocketHandle Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_Create_Public_Static_WebSocketHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebSocketHandle>(intPtr3) : null;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x000B756C File Offset: 0x000B576C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 493514, RefRangeEnd = 493516, XrefRangeStart = 493514, XrefRangeEnd = 493514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(WebSocketHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_WebSocketHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x000B75B0 File Offset: 0x000B57B0
		public unsafe Nullable<WebSocketCloseStatus> CloseStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_get_CloseStatus_Public_get_Nullable_1_WebSocketCloseStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<WebSocketCloseStatus>(intPtr);
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x000B75E8 File Offset: 0x000B57E8
		public unsafe WebSocketState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_get_State_Public_get_WebSocketState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000B7624 File Offset: 0x000B5824
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckPlatformSupport()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000B764C File Offset: 0x000B584C
		[CallerCount(0)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000B7680 File Offset: 0x000B5880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493516, XrefRangeEnd = 493517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000B76B4 File Offset: 0x000B58B4
		[CallerCount(0)]
		public unsafe Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_SendAsync_Public_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x000B7740 File Offset: 0x000B5940
		[CallerCount(0)]
		public unsafe Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_ReceiveAsync_Public_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketReceiveResult>>(intPtr3) : null;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000B77AC File Offset: 0x000B59AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493517, XrefRangeEnd = 493518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_CloseAsync_Public_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000B7824 File Offset: 0x000B5A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493518, XrefRangeEnd = 493519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_CloseOutputAsync_Public_Task_WebSocketCloseStatus_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000B789C File Offset: 0x000B5A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493519, XrefRangeEnd = 493533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken, ClientWebSocketOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_ConnectAsyncCore_Public_Task_Uri_CancellationToken_ClientWebSocketOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000B7918 File Offset: 0x000B5B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493533, XrefRangeEnd = 493550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Socket> ConnectSocketAsync(string host, int port, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_ConnectSocketAsync_Private_Task_1_Socket_String_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Socket>>(intPtr3) : null;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000B7990 File Offset: 0x000B5B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493656, RefRangeEnd = 493657, XrefRangeStart = 493550, XrefRangeEnd = 493656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> BuildRequestHeader(Uri uri, ClientWebSocketOptions options, string secKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_BuildRequestHeader_Private_Static_Il2CppStructArray_1_Byte_Uri_ClientWebSocketOptions_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000B79F8 File Offset: 0x000B5BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493681, RefRangeEnd = 493682, XrefRangeStart = 493657, XrefRangeEnd = 493681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyValuePair<string, string> CreateSecKeyAndSecWebSocketAccept()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_CreateSecKeyAndSecWebSocketAccept_Private_Static_KeyValuePair_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new KeyValuePair<string, string>(intPtr);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000B7A24 File Offset: 0x000B5C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493682, XrefRangeEnd = 493699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> ParseAndValidateConnectResponseAsync(Stream stream, ClientWebSocketOptions options, string expectedSecWebSocketAccept, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedSecWebSocketAccept);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_ParseAndValidateConnectResponseAsync_Private_Task_1_String_Stream_ClientWebSocketOptions_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x000B7AB0 File Offset: 0x000B5CB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 493701, RefRangeEnd = 493704, XrefRangeStart = 493699, XrefRangeEnd = 493701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateAndTrackHeader(string targetHeaderName, string targetHeaderValue, string foundHeaderName, string foundHeaderValue, ref bool foundHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHeaderName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHeaderValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(foundHeaderName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(foundHeaderValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &foundHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_ValidateAndTrackHeader_Private_Static_Void_String_String_String_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000B7B2C File Offset: 0x000B5D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 493719, RefRangeEnd = 493721, XrefRangeStart = 493704, XrefRangeEnd = 493719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<string> ReadResponseHeaderLineAsync(Stream stream, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr_ReadResponseHeaderLineAsync_Private_Static_Task_1_String_Stream_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000B7B88 File Offset: 0x000B5D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493721, XrefRangeEnd = 493727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x000115D4 File Offset: 0x0000F7D4
		public WebSocketHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000B7BC4 File Offset: 0x000B5DC4
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x000115DD File Offset: 0x0000F7DD
		public unsafe static StringBuilder t_cachedStringBuilder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.NativeFieldInfoPtr_t_cachedStringBuilder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.NativeFieldInfoPtr_t_cachedStringBuilder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000B7BEC File Offset: 0x000B5DEC
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x000115EF File Offset: 0x0000F7EF
		public unsafe static Encoding s_defaultHttpEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.NativeFieldInfoPtr_s_defaultHttpEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.NativeFieldInfoPtr_s_defaultHttpEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x000B7C14 File Offset: 0x000B5E14
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x00011601 File Offset: 0x0000F801
		public unsafe static int DefaultReceiveBufferSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.NativeFieldInfoPtr_DefaultReceiveBufferSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.NativeFieldInfoPtr_DefaultReceiveBufferSize, (void*)(&value));
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x000B7C30 File Offset: 0x000B5E30
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x0001160F File Offset: 0x0000F80F
		public unsafe static string WSServerGuid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.NativeFieldInfoPtr_WSServerGuid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.NativeFieldInfoPtr_WSServerGuid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000B7C50 File Offset: 0x000B5E50
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x00011621 File Offset: 0x0000F821
		public unsafe CancellationTokenSource _abortSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.NativeFieldInfoPtr__abortSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.NativeFieldInfoPtr__abortSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x000B7C80 File Offset: 0x000B5E80
		// (set) Token: 0x06002853 RID: 10323 RVA: 0x00011640 File Offset: 0x0000F840
		public unsafe WebSocketState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x000B7CA8 File Offset: 0x000B5EA8
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x0001165B File Offset: 0x0000F85B
		public unsafe WebSocket _webSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.NativeFieldInfoPtr__webSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.NativeFieldInfoPtr__webSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeFieldInfoPtr_t_cachedStringBuilder;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultHttpEncoding;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_DefaultReceiveBufferSize;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr_WSServerGuid;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr__abortSource;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeFieldInfoPtr__webSocket;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WebSocketHandle_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_WebSocketHandle_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseStatus_Public_get_Nullable_1_WebSocketCloseStatus_0;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_WebSocketState_0;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Void_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Task_ArraySegment_1_Byte_WebSocketMessageType_Boolean_CancellationToken_0;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Task_1_WebSocketReceiveResult_ArraySegment_1_Byte_CancellationToken_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeMethodInfoPtr_CloseAsync_Public_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr_CloseOutputAsync_Public_Task_WebSocketCloseStatus_String_CancellationToken_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsyncCore_Public_Task_Uri_CancellationToken_ClientWebSocketOptions_0;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSocketAsync_Private_Task_1_Socket_String_Int32_CancellationToken_0;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr_BuildRequestHeader_Private_Static_Il2CppStructArray_1_Byte_Uri_ClientWebSocketOptions_String_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_CreateSecKeyAndSecWebSocketAccept_Private_Static_KeyValuePair_2_String_String_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_ParseAndValidateConnectResponseAsync_Private_Task_1_String_Stream_ClientWebSocketOptions_String_CancellationToken_0;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAndTrackHeader_Private_Static_Void_String_String_String_String_byref_Boolean_0;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_ReadResponseHeaderLineAsync_Private_Static_Task_1_String_Stream_CancellationToken_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038A RID: 906
		[ObfuscatedName("System.Net.WebSockets.WebSocketHandle+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600343C RID: 13372 RVA: 0x000DAAD4 File Offset: 0x000D8CD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr);
				WebSocketHandle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, "<>9");
				WebSocketHandle.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, "<>9__26_0");
				WebSocketHandle.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, "<>9__27_0");
				WebSocketHandle.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, "<>9__27_1");
				WebSocketHandle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, 100669310);
				WebSocketHandle.__c.NativeMethodInfoPtr__ConnectAsyncCore_b__26_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, 100669311);
				WebSocketHandle.__c.NativeMethodInfoPtr__ConnectSocketAsync_b__27_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, 100669312);
				WebSocketHandle.__c.NativeMethodInfoPtr__ConnectSocketAsync_b__27_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr, 100669313);
			}

			// Token: 0x0600343D RID: 13373 RVA: 0x000DABA0 File Offset: 0x000D8DA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketHandle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600343E RID: 13374 RVA: 0x000DABDC File Offset: 0x000D8DDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493064, XrefRangeEnd = 493067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ConnectAsyncCore_b__26_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.__c.NativeMethodInfoPtr__ConnectAsyncCore_b__26_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600343F RID: 13375 RVA: 0x000DAC20 File Offset: 0x000D8E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493067, XrefRangeEnd = 493072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ConnectSocketAsync_b__27_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.__c.NativeMethodInfoPtr__ConnectSocketAsync_b__27_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003440 RID: 13376 RVA: 0x000DAC64 File Offset: 0x000D8E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493072, XrefRangeEnd = 493077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ConnectSocketAsync_b__27_1(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.__c.NativeMethodInfoPtr__ConnectSocketAsync_b__27_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003441 RID: 13377 RVA: 0x00019219 File Offset: 0x00017419
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700107C RID: 4220
			// (get) Token: 0x06003442 RID: 13378 RVA: 0x000DACA8 File Offset: 0x000D8EA8
			// (set) Token: 0x06003443 RID: 13379 RVA: 0x00019222 File Offset: 0x00017422
			public unsafe static WebSocketHandle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocketHandle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107D RID: 4221
			// (get) Token: 0x06003444 RID: 13380 RVA: 0x000DACD0 File Offset: 0x000D8ED0
			// (set) Token: 0x06003445 RID: 13381 RVA: 0x00019234 File Offset: 0x00017434
			public unsafe static Action<Object> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107E RID: 4222
			// (get) Token: 0x06003446 RID: 13382 RVA: 0x000DACF8 File Offset: 0x000D8EF8
			// (set) Token: 0x06003447 RID: 13383 RVA: 0x00019246 File Offset: 0x00017446
			public unsafe static Action<Object> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107F RID: 4223
			// (get) Token: 0x06003448 RID: 13384 RVA: 0x000DAD20 File Offset: 0x000D8F20
			// (set) Token: 0x06003449 RID: 13385 RVA: 0x00019258 File Offset: 0x00017458
			public unsafe static Action<Object> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebSocketHandle.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebSocketHandle.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027CE RID: 10190
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040027CF RID: 10191
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x040027D0 RID: 10192
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040027D1 RID: 10193
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x040027D2 RID: 10194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040027D3 RID: 10195
			private static readonly IntPtr NativeMethodInfoPtr__ConnectAsyncCore_b__26_0_Internal_Void_Object_0;

			// Token: 0x040027D4 RID: 10196
			private static readonly IntPtr NativeMethodInfoPtr__ConnectSocketAsync_b__27_0_Internal_Void_Object_0;

			// Token: 0x040027D5 RID: 10197
			private static readonly IntPtr NativeMethodInfoPtr__ConnectSocketAsync_b__27_1_Internal_Void_Object_0;
		}

		// Token: 0x0200038B RID: 907
		[ObfuscatedName("System.Net.WebSockets.WebSocketHandle+<ConnectAsyncCore>d__26")]
		public sealed class _ConnectAsyncCore_d__26 : ValueType
		{
			// Token: 0x0600344A RID: 13386 RVA: 0x000DAD48 File Offset: 0x000D8F48
			// Note: this type is marked as 'beforefieldinit'.
			static _ConnectAsyncCore_d__26()
			{
				Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "<ConnectAsyncCore>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr);
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<>1__state");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<>t__builder");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "cancellationToken");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<>4__this");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "uri");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "options");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__registration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<registration>5__2");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__stream_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<stream>5__3");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__secKeyAndSecWebSocketAccept_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<secKeyAndSecWebSocketAccept>5__4");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<>u__1");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__sslStream_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<sslStream>5__5");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<>u__2");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, "<>u__3");
				WebSocketHandle._ConnectAsyncCore_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, 100669314);
				WebSocketHandle._ConnectAsyncCore_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr, 100669315);
			}

			// Token: 0x0600344B RID: 13387 RVA: 0x000DAEA0 File Offset: 0x000D90A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493077, XrefRangeEnd = 493224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ConnectAsyncCore_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600344C RID: 13388 RVA: 0x000DAED8 File Offset: 0x000D90D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493224, XrefRangeEnd = 493228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ConnectAsyncCore_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600344D RID: 13389 RVA: 0x0001926A File Offset: 0x0001746A
			public _ConnectAsyncCore_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600344E RID: 13390 RVA: 0x00019273 File Offset: 0x00017473
			public _ConnectAsyncCore_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketHandle._ConnectAsyncCore_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x17001080 RID: 4224
			// (get) Token: 0x0600344F RID: 13391 RVA: 0x000DAF20 File Offset: 0x000D9120
			// (set) Token: 0x06003450 RID: 13392 RVA: 0x00019285 File Offset: 0x00017485
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001081 RID: 4225
			// (get) Token: 0x06003451 RID: 13393 RVA: 0x000DAF48 File Offset: 0x000D9148
			// (set) Token: 0x06003452 RID: 13394 RVA: 0x000192A0 File Offset: 0x000174A0
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001082 RID: 4226
			// (get) Token: 0x06003453 RID: 13395 RVA: 0x000DAF78 File Offset: 0x000D9178
			// (set) Token: 0x06003454 RID: 13396 RVA: 0x000192CE File Offset: 0x000174CE
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001083 RID: 4227
			// (get) Token: 0x06003455 RID: 13397 RVA: 0x000DAFA8 File Offset: 0x000D91A8
			// (set) Token: 0x06003456 RID: 13398 RVA: 0x000192FC File Offset: 0x000174FC
			public unsafe WebSocketHandle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocketHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001084 RID: 4228
			// (get) Token: 0x06003457 RID: 13399 RVA: 0x000DAFD8 File Offset: 0x000D91D8
			// (set) Token: 0x06003458 RID: 13400 RVA: 0x0001931B File Offset: 0x0001751B
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001085 RID: 4229
			// (get) Token: 0x06003459 RID: 13401 RVA: 0x000DB008 File Offset: 0x000D9208
			// (set) Token: 0x0600345A RID: 13402 RVA: 0x0001933A File Offset: 0x0001753A
			public unsafe ClientWebSocketOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientWebSocketOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001086 RID: 4230
			// (get) Token: 0x0600345B RID: 13403 RVA: 0x000DB038 File Offset: 0x000D9238
			// (set) Token: 0x0600345C RID: 13404 RVA: 0x00019359 File Offset: 0x00017559
			public CancellationTokenRegistration _registration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__registration_5__2);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__registration_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001087 RID: 4231
			// (get) Token: 0x0600345D RID: 13405 RVA: 0x000DB068 File Offset: 0x000D9268
			// (set) Token: 0x0600345E RID: 13406 RVA: 0x00019387 File Offset: 0x00017587
			public unsafe Stream _stream_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__stream_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__stream_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001088 RID: 4232
			// (get) Token: 0x0600345F RID: 13407 RVA: 0x000DB098 File Offset: 0x000D9298
			// (set) Token: 0x06003460 RID: 13408 RVA: 0x000193A6 File Offset: 0x000175A6
			public KeyValuePair<string, string> _secKeyAndSecWebSocketAccept_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__secKeyAndSecWebSocketAccept_5__4);
					return new KeyValuePair<string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__secKeyAndSecWebSocketAccept_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001089 RID: 4233
			// (get) Token: 0x06003461 RID: 13409 RVA: 0x000DB0C8 File Offset: 0x000D92C8
			// (set) Token: 0x06003462 RID: 13410 RVA: 0x000193D4 File Offset: 0x000175D4
			public ConfiguredTaskAwaitable<Socket>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Socket>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Socket>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Socket>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x06003463 RID: 13411 RVA: 0x000DB0F8 File Offset: 0x000D92F8
			// (set) Token: 0x06003464 RID: 13412 RVA: 0x00019402 File Offset: 0x00017602
			public unsafe SslStream _sslStream_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__sslStream_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr__sslStream_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108B RID: 4235
			// (get) Token: 0x06003465 RID: 13413 RVA: 0x000DB128 File Offset: 0x000D9328
			// (set) Token: 0x06003466 RID: 13414 RVA: 0x00019421 File Offset: 0x00017621
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700108C RID: 4236
			// (get) Token: 0x06003467 RID: 13415 RVA: 0x000DB158 File Offset: 0x000D9358
			// (set) Token: 0x06003468 RID: 13416 RVA: 0x0001944F File Offset: 0x0001764F
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectAsyncCore_d__26.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040027D6 RID: 10198
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040027D7 RID: 10199
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040027D8 RID: 10200
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040027D9 RID: 10201
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040027DA RID: 10202
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x040027DB RID: 10203
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x040027DC RID: 10204
			private static readonly IntPtr NativeFieldInfoPtr__registration_5__2;

			// Token: 0x040027DD RID: 10205
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__3;

			// Token: 0x040027DE RID: 10206
			private static readonly IntPtr NativeFieldInfoPtr__secKeyAndSecWebSocketAccept_5__4;

			// Token: 0x040027DF RID: 10207
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040027E0 RID: 10208
			private static readonly IntPtr NativeFieldInfoPtr__sslStream_5__5;

			// Token: 0x040027E1 RID: 10209
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040027E2 RID: 10210
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040027E3 RID: 10211
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040027E4 RID: 10212
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200038C RID: 908
		[ObfuscatedName("System.Net.WebSockets.WebSocketHandle+<ConnectSocketAsync>d__27")]
		public sealed class _ConnectSocketAsync_d__27 : ValueType
		{
			// Token: 0x06003469 RID: 13417 RVA: 0x000DB188 File Offset: 0x000D9388
			// Note: this type is marked as 'beforefieldinit'.
			static _ConnectSocketAsync_d__27()
			{
				Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "<ConnectSocketAsync>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr);
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>1__state");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>t__builder");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "host");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "cancellationToken");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>4__this");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "port");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>u__1");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>7__wrap1");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>7__wrap2");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr__socket_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<socket>5__4");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>7__wrap4");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>7__wrap5");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, "<>u__2");
				WebSocketHandle._ConnectSocketAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, 100669316);
				WebSocketHandle._ConnectSocketAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr, 100669317);
			}

			// Token: 0x0600346A RID: 13418 RVA: 0x000DB2E0 File Offset: 0x000D94E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493228, XrefRangeEnd = 493329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ConnectSocketAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600346B RID: 13419 RVA: 0x000DB318 File Offset: 0x000D9518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493329, XrefRangeEnd = 493335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ConnectSocketAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600346C RID: 13420 RVA: 0x0001947D File Offset: 0x0001767D
			public _ConnectSocketAsync_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600346D RID: 13421 RVA: 0x00019486 File Offset: 0x00017686
			public _ConnectSocketAsync_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketHandle._ConnectSocketAsync_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x1700108D RID: 4237
			// (get) Token: 0x0600346E RID: 13422 RVA: 0x000DB360 File Offset: 0x000D9560
			// (set) Token: 0x0600346F RID: 13423 RVA: 0x00019498 File Offset: 0x00017698
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700108E RID: 4238
			// (get) Token: 0x06003470 RID: 13424 RVA: 0x000DB388 File Offset: 0x000D9588
			// (set) Token: 0x06003471 RID: 13425 RVA: 0x000194B3 File Offset: 0x000176B3
			public AsyncTaskMethodBuilder<Socket> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Socket>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Socket>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Socket>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700108F RID: 4239
			// (get) Token: 0x06003472 RID: 13426 RVA: 0x000DB3B8 File Offset: 0x000D95B8
			// (set) Token: 0x06003473 RID: 13427 RVA: 0x000194E1 File Offset: 0x000176E1
			public unsafe string host
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_host);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_host), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001090 RID: 4240
			// (get) Token: 0x06003474 RID: 13428 RVA: 0x000DB3E0 File Offset: 0x000D95E0
			// (set) Token: 0x06003475 RID: 13429 RVA: 0x00019500 File Offset: 0x00017700
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001091 RID: 4241
			// (get) Token: 0x06003476 RID: 13430 RVA: 0x000DB410 File Offset: 0x000D9610
			// (set) Token: 0x06003477 RID: 13431 RVA: 0x0001952E File Offset: 0x0001772E
			public unsafe WebSocketHandle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebSocketHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001092 RID: 4242
			// (get) Token: 0x06003478 RID: 13432 RVA: 0x000DB440 File Offset: 0x000D9640
			// (set) Token: 0x06003479 RID: 13433 RVA: 0x0001954D File Offset: 0x0001774D
			public unsafe int port
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_port);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr_port)) = value;
				}
			}

			// Token: 0x17001093 RID: 4243
			// (get) Token: 0x0600347A RID: 13434 RVA: 0x000DB468 File Offset: 0x000D9668
			// (set) Token: 0x0600347B RID: 13435 RVA: 0x00019568 File Offset: 0x00017768
			public ConfiguredTaskAwaitable<Il2CppReferenceArray<IPAddress>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Il2CppReferenceArray<IPAddress>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppReferenceArray<IPAddress>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppReferenceArray<IPAddress>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001094 RID: 4244
			// (get) Token: 0x0600347C RID: 13436 RVA: 0x000DB498 File Offset: 0x000D9698
			// (set) Token: 0x0600347D RID: 13437 RVA: 0x00019596 File Offset: 0x00017796
			public unsafe Il2CppReferenceArray<IPAddress> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001095 RID: 4245
			// (get) Token: 0x0600347E RID: 13438 RVA: 0x000DB4C8 File Offset: 0x000D96C8
			// (set) Token: 0x0600347F RID: 13439 RVA: 0x000195B5 File Offset: 0x000177B5
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x17001096 RID: 4246
			// (get) Token: 0x06003480 RID: 13440 RVA: 0x000DB4F0 File Offset: 0x000D96F0
			// (set) Token: 0x06003481 RID: 13441 RVA: 0x000195D0 File Offset: 0x000177D0
			public unsafe Socket _socket_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr__socket_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr__socket_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001097 RID: 4247
			// (get) Token: 0x06003482 RID: 13442 RVA: 0x000DB520 File Offset: 0x000D9720
			// (set) Token: 0x06003483 RID: 13443 RVA: 0x000195EF File Offset: 0x000177EF
			public CancellationTokenRegistration __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap4);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001098 RID: 4248
			// (get) Token: 0x06003484 RID: 13444 RVA: 0x000DB550 File Offset: 0x000D9750
			// (set) Token: 0x06003485 RID: 13445 RVA: 0x0001961D File Offset: 0x0001781D
			public CancellationTokenRegistration __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap5);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001099 RID: 4249
			// (get) Token: 0x06003486 RID: 13446 RVA: 0x000DB580 File Offset: 0x000D9780
			// (set) Token: 0x06003487 RID: 13447 RVA: 0x0001964B File Offset: 0x0001784B
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ConnectSocketAsync_d__27.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040027E5 RID: 10213
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040027E6 RID: 10214
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040027E7 RID: 10215
			private static readonly IntPtr NativeFieldInfoPtr_host;

			// Token: 0x040027E8 RID: 10216
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040027E9 RID: 10217
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040027EA RID: 10218
			private static readonly IntPtr NativeFieldInfoPtr_port;

			// Token: 0x040027EB RID: 10219
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040027EC RID: 10220
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040027ED RID: 10221
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040027EE RID: 10222
			private static readonly IntPtr NativeFieldInfoPtr__socket_5__4;

			// Token: 0x040027EF RID: 10223
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040027F0 RID: 10224
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x040027F1 RID: 10225
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040027F2 RID: 10226
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040027F3 RID: 10227
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200038D RID: 909
		[ObfuscatedName("System.Net.WebSockets.WebSocketHandle+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Object
		{
			// Token: 0x06003488 RID: 13448 RVA: 0x000DB5B0 File Offset: 0x000D97B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<WebSocketHandle.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHandle.__c__DisplayClass30_0>.NativeClassPtr);
				WebSocketHandle.__c__DisplayClass30_0.NativeFieldInfoPtr_headerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle.__c__DisplayClass30_0>.NativeClassPtr, "headerValue");
				WebSocketHandle.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle.__c__DisplayClass30_0>.NativeClassPtr, 100669318);
				WebSocketHandle.__c__DisplayClass30_0.NativeMethodInfoPtr__ParseAndValidateConnectResponseAsync_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle.__c__DisplayClass30_0>.NativeClassPtr, 100669319);
			}

			// Token: 0x06003489 RID: 13449 RVA: 0x000DB618 File Offset: 0x000D9818
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketHandle.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600348A RID: 13450 RVA: 0x000DB654 File Offset: 0x000D9854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493335, XrefRangeEnd = 493357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ParseAndValidateConnectResponseAsync_b__0(string requested)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(requested);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle.__c__DisplayClass30_0.NativeMethodInfoPtr__ParseAndValidateConnectResponseAsync_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600348B RID: 13451 RVA: 0x00019679 File Offset: 0x00017879
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700109A RID: 4250
			// (get) Token: 0x0600348C RID: 13452 RVA: 0x000DB6A4 File Offset: 0x000D98A4
			// (set) Token: 0x0600348D RID: 13453 RVA: 0x00019682 File Offset: 0x00017882
			public unsafe string headerValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.__c__DisplayClass30_0.NativeFieldInfoPtr_headerValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle.__c__DisplayClass30_0.NativeFieldInfoPtr_headerValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040027F4 RID: 10228
			private static readonly IntPtr NativeFieldInfoPtr_headerValue;

			// Token: 0x040027F5 RID: 10229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040027F6 RID: 10230
			private static readonly IntPtr NativeMethodInfoPtr__ParseAndValidateConnectResponseAsync_b__0_Internal_Boolean_String_0;
		}

		// Token: 0x0200038E RID: 910
		[ObfuscatedName("System.Net.WebSockets.WebSocketHandle+<ParseAndValidateConnectResponseAsync>d__30")]
		public sealed class _ParseAndValidateConnectResponseAsync_d__30 : ValueType
		{
			// Token: 0x0600348E RID: 13454 RVA: 0x000DB6CC File Offset: 0x000D98CC
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseAndValidateConnectResponseAsync_d__30()
			{
				Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "<ParseAndValidateConnectResponseAsync>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr);
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "<>1__state");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "<>t__builder");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "stream");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "cancellationToken");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_expectedSecWebSocketAccept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "expectedSecWebSocketAccept");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "options");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundUpgrade_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "<foundUpgrade>5__2");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundConnection_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "<foundConnection>5__3");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundSecWebSocketAccept_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "<foundSecWebSocketAccept>5__4");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__subprotocol_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "<subprotocol>5__5");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, "<>u__1");
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, 100669320);
				WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr, 100669321);
			}

			// Token: 0x0600348F RID: 13455 RVA: 0x000DB7FC File Offset: 0x000D99FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493357, XrefRangeEnd = 493442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003490 RID: 13456 RVA: 0x000DB834 File Offset: 0x000D9A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493442, XrefRangeEnd = 493448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003491 RID: 13457 RVA: 0x000196A1 File Offset: 0x000178A1
			public _ParseAndValidateConnectResponseAsync_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003492 RID: 13458 RVA: 0x000196AA File Offset: 0x000178AA
			public _ParseAndValidateConnectResponseAsync_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x1700109B RID: 4251
			// (get) Token: 0x06003493 RID: 13459 RVA: 0x000DB87C File Offset: 0x000D9A7C
			// (set) Token: 0x06003494 RID: 13460 RVA: 0x000196BC File Offset: 0x000178BC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700109C RID: 4252
			// (get) Token: 0x06003495 RID: 13461 RVA: 0x000DB8A4 File Offset: 0x000D9AA4
			// (set) Token: 0x06003496 RID: 13462 RVA: 0x000196D7 File Offset: 0x000178D7
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700109D RID: 4253
			// (get) Token: 0x06003497 RID: 13463 RVA: 0x000DB8D4 File Offset: 0x000D9AD4
			// (set) Token: 0x06003498 RID: 13464 RVA: 0x00019705 File Offset: 0x00017905
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109E RID: 4254
			// (get) Token: 0x06003499 RID: 13465 RVA: 0x000DB904 File Offset: 0x000D9B04
			// (set) Token: 0x0600349A RID: 13466 RVA: 0x00019724 File Offset: 0x00017924
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700109F RID: 4255
			// (get) Token: 0x0600349B RID: 13467 RVA: 0x000DB934 File Offset: 0x000D9B34
			// (set) Token: 0x0600349C RID: 13468 RVA: 0x00019752 File Offset: 0x00017952
			public unsafe string expectedSecWebSocketAccept
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_expectedSecWebSocketAccept);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_expectedSecWebSocketAccept), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010A0 RID: 4256
			// (get) Token: 0x0600349D RID: 13469 RVA: 0x000DB95C File Offset: 0x000D9B5C
			// (set) Token: 0x0600349E RID: 13470 RVA: 0x00019771 File Offset: 0x00017971
			public unsafe ClientWebSocketOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientWebSocketOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A1 RID: 4257
			// (get) Token: 0x0600349F RID: 13471 RVA: 0x000DB98C File Offset: 0x000D9B8C
			// (set) Token: 0x060034A0 RID: 13472 RVA: 0x00019790 File Offset: 0x00017990
			public unsafe bool _foundUpgrade_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundUpgrade_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundUpgrade_5__2)) = value;
				}
			}

			// Token: 0x170010A2 RID: 4258
			// (get) Token: 0x060034A1 RID: 13473 RVA: 0x000DB9B4 File Offset: 0x000D9BB4
			// (set) Token: 0x060034A2 RID: 13474 RVA: 0x000197AB File Offset: 0x000179AB
			public unsafe bool _foundConnection_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundConnection_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundConnection_5__3)) = value;
				}
			}

			// Token: 0x170010A3 RID: 4259
			// (get) Token: 0x060034A3 RID: 13475 RVA: 0x000DB9DC File Offset: 0x000D9BDC
			// (set) Token: 0x060034A4 RID: 13476 RVA: 0x000197C6 File Offset: 0x000179C6
			public unsafe bool _foundSecWebSocketAccept_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundSecWebSocketAccept_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__foundSecWebSocketAccept_5__4)) = value;
				}
			}

			// Token: 0x170010A4 RID: 4260
			// (get) Token: 0x060034A5 RID: 13477 RVA: 0x000DBA04 File Offset: 0x000D9C04
			// (set) Token: 0x060034A6 RID: 13478 RVA: 0x000197E1 File Offset: 0x000179E1
			public unsafe string _subprotocol_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__subprotocol_5__5);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr__subprotocol_5__5), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010A5 RID: 4261
			// (get) Token: 0x060034A7 RID: 13479 RVA: 0x000DBA2C File Offset: 0x000D9C2C
			// (set) Token: 0x060034A8 RID: 13480 RVA: 0x00019800 File Offset: 0x00017A00
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ParseAndValidateConnectResponseAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040027F7 RID: 10231
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040027F8 RID: 10232
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040027F9 RID: 10233
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040027FA RID: 10234
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040027FB RID: 10235
			private static readonly IntPtr NativeFieldInfoPtr_expectedSecWebSocketAccept;

			// Token: 0x040027FC RID: 10236
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x040027FD RID: 10237
			private static readonly IntPtr NativeFieldInfoPtr__foundUpgrade_5__2;

			// Token: 0x040027FE RID: 10238
			private static readonly IntPtr NativeFieldInfoPtr__foundConnection_5__3;

			// Token: 0x040027FF RID: 10239
			private static readonly IntPtr NativeFieldInfoPtr__foundSecWebSocketAccept_5__4;

			// Token: 0x04002800 RID: 10240
			private static readonly IntPtr NativeFieldInfoPtr__subprotocol_5__5;

			// Token: 0x04002801 RID: 10241
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002802 RID: 10242
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002803 RID: 10243
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200038F RID: 911
		[ObfuscatedName("System.Net.WebSockets.WebSocketHandle+<ReadResponseHeaderLineAsync>d__32")]
		public sealed class _ReadResponseHeaderLineAsync_d__32 : ValueType
		{
			// Token: 0x060034A9 RID: 13481 RVA: 0x000DBA5C File Offset: 0x000D9C5C
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadResponseHeaderLineAsync_d__32()
			{
				Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebSocketHandle>.NativeClassPtr, "<ReadResponseHeaderLineAsync>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr);
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "<>1__state");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "<>t__builder");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "stream");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "cancellationToken");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__sb_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "<sb>5__2");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__arr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "<arr>5__3");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__prevChar_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "<prevChar>5__4");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, "<>u__1");
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, 100669322);
				WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr, 100669323);
			}

			// Token: 0x060034AA RID: 13482 RVA: 0x000DBB50 File Offset: 0x000D9D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493448, XrefRangeEnd = 493499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060034AB RID: 13483 RVA: 0x000DBB88 File Offset: 0x000D9D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493499, XrefRangeEnd = 493505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060034AC RID: 13484 RVA: 0x0001982E File Offset: 0x00017A2E
			public _ReadResponseHeaderLineAsync_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060034AD RID: 13485 RVA: 0x00019837 File Offset: 0x00017A37
			public _ReadResponseHeaderLineAsync_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketHandle._ReadResponseHeaderLineAsync_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x170010A6 RID: 4262
			// (get) Token: 0x060034AE RID: 13486 RVA: 0x000DBBD0 File Offset: 0x000D9DD0
			// (set) Token: 0x060034AF RID: 13487 RVA: 0x00019849 File Offset: 0x00017A49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010A7 RID: 4263
			// (get) Token: 0x060034B0 RID: 13488 RVA: 0x000DBBF8 File Offset: 0x000D9DF8
			// (set) Token: 0x060034B1 RID: 13489 RVA: 0x00019864 File Offset: 0x00017A64
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170010A8 RID: 4264
			// (get) Token: 0x060034B2 RID: 13490 RVA: 0x000DBC28 File Offset: 0x000D9E28
			// (set) Token: 0x060034B3 RID: 13491 RVA: 0x00019892 File Offset: 0x00017A92
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A9 RID: 4265
			// (get) Token: 0x060034B4 RID: 13492 RVA: 0x000DBC58 File Offset: 0x000D9E58
			// (set) Token: 0x060034B5 RID: 13493 RVA: 0x000198B1 File Offset: 0x00017AB1
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170010AA RID: 4266
			// (get) Token: 0x060034B6 RID: 13494 RVA: 0x000DBC88 File Offset: 0x000D9E88
			// (set) Token: 0x060034B7 RID: 13495 RVA: 0x000198DF File Offset: 0x00017ADF
			public unsafe StringBuilder _sb_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__sb_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__sb_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AB RID: 4267
			// (get) Token: 0x060034B8 RID: 13496 RVA: 0x000DBCB8 File Offset: 0x000D9EB8
			// (set) Token: 0x060034B9 RID: 13497 RVA: 0x000198FE File Offset: 0x00017AFE
			public unsafe Il2CppStructArray<byte> _arr_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__arr_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__arr_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AC RID: 4268
			// (get) Token: 0x060034BA RID: 13498 RVA: 0x000DBCE8 File Offset: 0x000D9EE8
			// (set) Token: 0x060034BB RID: 13499 RVA: 0x0001991D File Offset: 0x00017B1D
			public unsafe char _prevChar_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__prevChar_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr__prevChar_5__4)) = value;
				}
			}

			// Token: 0x170010AD RID: 4269
			// (get) Token: 0x060034BC RID: 13500 RVA: 0x000DBD10 File Offset: 0x000D9F10
			// (set) Token: 0x060034BD RID: 13501 RVA: 0x00019938 File Offset: 0x00017B38
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketHandle._ReadResponseHeaderLineAsync_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002804 RID: 10244
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002805 RID: 10245
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002806 RID: 10246
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04002807 RID: 10247
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002808 RID: 10248
			private static readonly IntPtr NativeFieldInfoPtr__sb_5__2;

			// Token: 0x04002809 RID: 10249
			private static readonly IntPtr NativeFieldInfoPtr__arr_5__3;

			// Token: 0x0400280A RID: 10250
			private static readonly IntPtr NativeFieldInfoPtr__prevChar_5__4;

			// Token: 0x0400280B RID: 10251
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400280C RID: 10252
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400280D RID: 10253
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
