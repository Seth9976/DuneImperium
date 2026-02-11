using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020001F9 RID: 505
	public sealed class HttpConnection : Object
	{
		// Token: 0x06001F47 RID: 8007 RVA: 0x00095BEC File Offset: 0x00093DEC
		// Note: this type is marked as 'beforefieldinit'.
		static HttpConnection()
		{
			Il2CppClassPointerStore<HttpConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr);
			HttpConnection.NativeFieldInfoPtr_onread_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "onread_cb");
			HttpConnection.NativeFieldInfoPtr_sock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "sock");
			HttpConnection.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "stream");
			HttpConnection.NativeFieldInfoPtr_epl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "epl");
			HttpConnection.NativeFieldInfoPtr_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "ms");
			HttpConnection.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "buffer");
			HttpConnection.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "context");
			HttpConnection.NativeFieldInfoPtr_current_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "current_line");
			HttpConnection.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "prefix");
			HttpConnection.NativeFieldInfoPtr_i_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "i_stream");
			HttpConnection.NativeFieldInfoPtr_o_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "o_stream");
			HttpConnection.NativeFieldInfoPtr_chunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "chunked");
			HttpConnection.NativeFieldInfoPtr_reuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "reuses");
			HttpConnection.NativeFieldInfoPtr_context_bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "context_bound");
			HttpConnection.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "secure");
			HttpConnection.NativeFieldInfoPtr_cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "cert");
			HttpConnection.NativeFieldInfoPtr_s_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "s_timeout");
			HttpConnection.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "timer");
			HttpConnection.NativeFieldInfoPtr_local_ep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "local_ep");
			HttpConnection.NativeFieldInfoPtr_last_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "last_listener");
			HttpConnection.NativeFieldInfoPtr_client_cert_errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "client_cert_errors");
			HttpConnection.NativeFieldInfoPtr_client_cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "client_cert");
			HttpConnection.NativeFieldInfoPtr_ssl_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "ssl_stream");
			HttpConnection.NativeFieldInfoPtr_input_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "input_state");
			HttpConnection.NativeFieldInfoPtr_line_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "line_state");
			HttpConnection.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, "position");
			HttpConnection.NativeMethodInfoPtr__ctor_Public_Void_Socket_EndPointListener_Boolean_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668056);
			HttpConnection.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668057);
			HttpConnection.NativeMethodInfoPtr_get_Reuses_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668058);
			HttpConnection.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668059);
			HttpConnection.NativeMethodInfoPtr_get_IsSecure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668060);
			HttpConnection.NativeMethodInfoPtr_set_Prefix_Public_set_Void_ListenerPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668061);
			HttpConnection.NativeMethodInfoPtr_OnTimeout_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668062);
			HttpConnection.NativeMethodInfoPtr_BeginReadRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668063);
			HttpConnection.NativeMethodInfoPtr_GetRequestStream_Public_RequestStream_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668064);
			HttpConnection.NativeMethodInfoPtr_GetResponseStream_Public_ResponseStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668065);
			HttpConnection.NativeMethodInfoPtr_OnRead_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668066);
			HttpConnection.NativeMethodInfoPtr_OnReadInternal_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668067);
			HttpConnection.NativeMethodInfoPtr_RemoveConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668068);
			HttpConnection.NativeMethodInfoPtr_ProcessInput_Private_Boolean_MemoryStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668069);
			HttpConnection.NativeMethodInfoPtr_ReadLine_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668070);
			HttpConnection.NativeMethodInfoPtr_SendError_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668071);
			HttpConnection.NativeMethodInfoPtr_SendError_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668072);
			HttpConnection.NativeMethodInfoPtr_Unbind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668073);
			HttpConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668074);
			HttpConnection.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668075);
			HttpConnection.NativeMethodInfoPtr___ctor_b__24_0_Private_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr, 100668077);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00095FC8 File Offset: 0x000941C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480079, RefRangeEnd = 480080, XrefRangeStart = 480038, XrefRangeEnd = 480079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpConnection(Socket sock, EndPointListener epl, bool secure, X509Certificate cert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpConnection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sock);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cert);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr__ctor_Public_Void_Socket_EndPointListener_Boolean_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00096048 File Offset: 0x00094248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 480093, RefRangeEnd = 480095, XrefRangeStart = 480080, XrefRangeEnd = 480093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x0009607C File Offset: 0x0009427C
		public unsafe int Reuses
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_get_Reuses_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000960B8 File Offset: 0x000942B8
		public unsafe IPEndPoint LocalEndPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480095, XrefRangeEnd = 480101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x000960F8 File Offset: 0x000942F8
		public unsafe bool IsSecure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_get_IsSecure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000998 RID: 2456
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00096134 File Offset: 0x00094334
		public unsafe ListenerPrefix Prefix
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_set_Prefix_Public_set_Void_ListenerPrefix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00096178 File Offset: 0x00094378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480101, XrefRangeEnd = 480103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeout(Object unused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unused);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_OnTimeout_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x000961BC File Offset: 0x000943BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 480116, RefRangeEnd = 480118, XrefRangeStart = 480103, XrefRangeEnd = 480116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginReadRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_BeginReadRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000961F0 File Offset: 0x000943F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480118, XrefRangeEnd = 480125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestStream GetRequestStream(bool chunked, long contentlength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chunked;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentlength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_GetRequestStream_Public_RequestStream_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestStream>(intPtr3) : null;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0009624C File Offset: 0x0009444C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 480130, RefRangeEnd = 480134, XrefRangeStart = 480125, XrefRangeEnd = 480130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResponseStream GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_GetResponseStream_Public_ResponseStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseStream>(intPtr3) : null;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0009628C File Offset: 0x0009448C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480134, XrefRangeEnd = 480142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRead(IAsyncResult ares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_OnRead_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x000962C4 File Offset: 0x000944C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480150, RefRangeEnd = 480151, XrefRangeStart = 480142, XrefRangeEnd = 480150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReadInternal(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_OnReadInternal_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00096308 File Offset: 0x00094508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480151, XrefRangeEnd = 480153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_RemoveConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x0009633C File Offset: 0x0009453C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480172, RefRangeEnd = 480173, XrefRangeStart = 480153, XrefRangeEnd = 480172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessInput(MemoryStream ms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ms);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_ProcessInput_Private_Boolean_MemoryStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0009638C File Offset: 0x0009458C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480173, XrefRangeEnd = 480182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadLine(Il2CppStructArray<byte> buffer, int offset, int len, ref int used)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &used;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_ReadLine_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00096400 File Offset: 0x00094600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 480199, RefRangeEnd = 480201, XrefRangeStart = 480182, XrefRangeEnd = 480199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendError(string msg, int status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_SendError_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00096450 File Offset: 0x00094650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480201, XrefRangeEnd = 480203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_SendError_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00096484 File Offset: 0x00094684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480204, RefRangeEnd = 480205, XrefRangeStart = 480203, XrefRangeEnd = 480204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unbind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_Unbind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000964B8 File Offset: 0x000946B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 480211, RefRangeEnd = 480213, XrefRangeStart = 480205, XrefRangeEnd = 480211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x000964EC File Offset: 0x000946EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 480228, RefRangeEnd = 480236, XrefRangeStart = 480213, XrefRangeEnd = 480228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool force_close)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force_close;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0009652C File Offset: 0x0009472C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480236, XrefRangeEnd = 480246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool __ctor_b__24_0(Object t, X509Certificate c, X509Chain ch, SslPolicyErrors e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ch);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpConnection.NativeMethodInfoPtr___ctor_b__24_0_Private_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0000D425 File Offset: 0x0000B625
		public HttpConnection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x000965AC File Offset: 0x000947AC
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000D42E File Offset: 0x0000B62E
		public unsafe static AsyncCallback onread_cb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpConnection.NativeFieldInfoPtr_onread_cb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpConnection.NativeFieldInfoPtr_onread_cb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x000965D4 File Offset: 0x000947D4
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0000D440 File Offset: 0x0000B640
		public unsafe Socket sock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_sock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_sock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00096604 File Offset: 0x00094804
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0000D45F File Offset: 0x0000B65F
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00096634 File Offset: 0x00094834
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x0000D47E File Offset: 0x0000B67E
		public unsafe EndPointListener epl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_epl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPointListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_epl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00096664 File Offset: 0x00094864
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0000D49D File Offset: 0x0000B69D
		public unsafe MemoryStream ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_ms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_ms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00096694 File Offset: 0x00094894
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0000D4BC File Offset: 0x0000B6BC
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x000966C4 File Offset: 0x000948C4
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0000D4DB File Offset: 0x0000B6DB
		public unsafe HttpListenerContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x000966F4 File Offset: 0x000948F4
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0000D4FA File Offset: 0x0000B6FA
		public unsafe StringBuilder current_line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_current_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_current_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00096724 File Offset: 0x00094924
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x0000D519 File Offset: 0x0000B719
		public unsafe ListenerPrefix prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_prefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListenerPrefix>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_prefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00096754 File Offset: 0x00094954
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x0000D538 File Offset: 0x0000B738
		public unsafe RequestStream i_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_i_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_i_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00096784 File Offset: 0x00094984
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x0000D557 File Offset: 0x0000B757
		public unsafe ResponseStream o_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_o_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResponseStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_o_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x000967B4 File Offset: 0x000949B4
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0000D576 File Offset: 0x0000B776
		public unsafe bool chunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_chunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_chunked)) = value;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x000967DC File Offset: 0x000949DC
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0000D591 File Offset: 0x0000B791
		public unsafe int reuses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_reuses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_reuses)) = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00096804 File Offset: 0x00094A04
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		public unsafe bool context_bound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_context_bound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_context_bound)) = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0009682C File Offset: 0x00094A2C
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x0000D5C7 File Offset: 0x0000B7C7
		public unsafe bool secure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_secure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_secure)) = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00096854 File Offset: 0x00094A54
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x0000D5E2 File Offset: 0x0000B7E2
		public unsafe X509Certificate cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00096884 File Offset: 0x00094A84
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0000D601 File Offset: 0x0000B801
		public unsafe int s_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_s_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_s_timeout)) = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x000968AC File Offset: 0x00094AAC
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x0000D61C File Offset: 0x0000B81C
		public unsafe Timer timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000968DC File Offset: 0x00094ADC
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x0000D63B File Offset: 0x0000B83B
		public unsafe IPEndPoint local_ep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_local_ep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_local_ep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x0009690C File Offset: 0x00094B0C
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0000D65A File Offset: 0x0000B85A
		public unsafe HttpListener last_listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_last_listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_last_listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0009693C File Offset: 0x00094B3C
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x0000D679 File Offset: 0x0000B879
		public unsafe Il2CppStructArray<int> client_cert_errors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_client_cert_errors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_client_cert_errors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x0009696C File Offset: 0x00094B6C
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x0000D698 File Offset: 0x0000B898
		public unsafe X509Certificate2 client_cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_client_cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_client_cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x0009699C File Offset: 0x00094B9C
		// (set) Token: 0x06001F8B RID: 8075 RVA: 0x0000D6B7 File Offset: 0x0000B8B7
		public unsafe SslStream ssl_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_ssl_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_ssl_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x000969CC File Offset: 0x00094BCC
		// (set) Token: 0x06001F8D RID: 8077 RVA: 0x0000D6D6 File Offset: 0x0000B8D6
		public unsafe HttpConnection.InputState input_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_input_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_input_state)) = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x000969F4 File Offset: 0x00094BF4
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x0000D6F1 File Offset: 0x0000B8F1
		public unsafe HttpConnection.LineState line_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_line_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_line_state)) = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00096A1C File Offset: 0x00094C1C
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x0000D70C File Offset: 0x0000B90C
		public unsafe int position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpConnection.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeFieldInfoPtr_onread_cb;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeFieldInfoPtr_sock;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeFieldInfoPtr_epl;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeFieldInfoPtr_ms;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeFieldInfoPtr_current_line;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeFieldInfoPtr_i_stream;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeFieldInfoPtr_o_stream;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeFieldInfoPtr_chunked;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeFieldInfoPtr_reuses;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeFieldInfoPtr_context_bound;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeFieldInfoPtr_secure;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeFieldInfoPtr_cert;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeFieldInfoPtr_s_timeout;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeFieldInfoPtr_local_ep;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeFieldInfoPtr_last_listener;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeFieldInfoPtr_client_cert_errors;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeFieldInfoPtr_client_cert;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeFieldInfoPtr_ssl_stream;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeFieldInfoPtr_input_state;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeFieldInfoPtr_line_state;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Socket_EndPointListener_Boolean_X509Certificate_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_get_Reuses_Public_get_Int32_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalEndPoint_Public_get_IPEndPoint_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSecure_Public_get_Boolean_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_set_Void_ListenerPrefix_0;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeout_Private_Void_Object_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr_BeginReadRequest_Public_Void_0;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStream_Public_RequestStream_Boolean_Int64_0;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_ResponseStream_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_OnRead_Private_Static_Void_IAsyncResult_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_OnReadInternal_Private_Void_IAsyncResult_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Private_Void_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInput_Private_Boolean_MemoryStream_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_SendError_Public_Void_String_Int32_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_SendError_Public_Void_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_Unbind_Private_Void_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_CloseSocket_Private_Void_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_Boolean_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_0_Private_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;

		// Token: 0x02000337 RID: 823
		public enum InputState
		{
			// Token: 0x0400253E RID: 9534
			RequestLine,
			// Token: 0x0400253F RID: 9535
			Headers
		}

		// Token: 0x02000338 RID: 824
		public enum LineState
		{
			// Token: 0x04002541 RID: 9537
			None,
			// Token: 0x04002542 RID: 9538
			CR,
			// Token: 0x04002543 RID: 9539
			LF
		}
	}
}
