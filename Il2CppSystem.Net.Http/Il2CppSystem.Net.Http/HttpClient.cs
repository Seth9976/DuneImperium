using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Http.Headers;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x0200000B RID: 11
	public class HttpClient : HttpMessageInvoker
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00006270 File Offset: 0x00004470
		// Note: this type is marked as 'beforefieldinit'.
		static HttpClient()
		{
			Il2CppClassPointerStore<HttpClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpClient>.NativeClassPtr);
			HttpClient.NativeFieldInfoPtr_TimeoutDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "TimeoutDefault");
			HttpClient.NativeFieldInfoPtr_base_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "base_address");
			HttpClient.NativeFieldInfoPtr_cts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "cts");
			HttpClient.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "disposed");
			HttpClient.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "headers");
			HttpClient.NativeFieldInfoPtr_buffer_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "buffer_size");
			HttpClient.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "timeout");
			HttpClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663365);
			HttpClient.NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663366);
			HttpClient.NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663367);
			HttpClient.NativeMethodInfoPtr_get_DefaultRequestHeaders_Public_get_HttpRequestHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663368);
			HttpClient.NativeMethodInfoPtr_get_MaxResponseContentBufferSize_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663369);
			HttpClient.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663370);
			HttpClient.NativeMethodInfoPtr_GetAsync_Public_Task_1_HttpResponseMessage_String_HttpCompletionOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663371);
			HttpClient.NativeMethodInfoPtr_PostAsync_Public_Task_1_HttpResponseMessage_Uri_HttpContent_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663372);
			HttpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663373);
			HttpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663374);
			HttpClient.NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663375);
			HttpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663376);
			HttpClient.NativeMethodInfoPtr_SendAsyncWorker_Private_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663377);
			HttpClient.NativeMethodInfoPtr_GetStringAsync_Public_Task_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663378);
			HttpClient.NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, 100663380);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006458 File Offset: 0x00004658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1171254, RefRangeEnd = 1171257, XrefRangeStart = 1171249, XrefRangeEnd = 1171254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006494 File Offset: 0x00004694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1171258, RefRangeEnd = 1171260, XrefRangeStart = 1171257, XrefRangeEnd = 1171258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpClient(HttpMessageHandler handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000064E0 File Offset: 0x000046E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1171277, RefRangeEnd = 1171279, XrefRangeStart = 1171260, XrefRangeEnd = 1171277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpClient(HttpMessageHandler handler, bool disposeHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClient>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disposeHandler;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000653C File Offset: 0x0000473C
		public unsafe HttpRequestHeaders DefaultRequestHeaders
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1171287, RefRangeEnd = 1171289, XrefRangeStart = 1171279, XrefRangeEnd = 1171287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_get_DefaultRequestHeaders_Public_get_HttpRequestHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestHeaders>(intPtr3) : null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000657C File Offset: 0x0000477C
		public unsafe long MaxResponseContentBufferSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_get_MaxResponseContentBufferSize_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000065B8 File Offset: 0x000047B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171289, XrefRangeEnd = 1171292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClient.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006604 File Offset: 0x00004804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171292, XrefRangeEnd = 1171314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(requestUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completionOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_GetAsync_Public_Task_1_HttpResponseMessage_String_HttpCompletionOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006664 File Offset: 0x00004864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171327, RefRangeEnd = 1171328, XrefRangeStart = 1171314, XrefRangeEnd = 1171327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_PostAsync_Public_Task_1_HttpResponseMessage_Uri_HttpContent_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000066E0 File Offset: 0x000048E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171333, RefRangeEnd = 1171334, XrefRangeStart = 1171328, XrefRangeEnd = 1171333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006730 File Offset: 0x00004930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171334, XrefRangeEnd = 1171339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completionOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00006790 File Offset: 0x00004990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171339, XrefRangeEnd = 1171340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClient.NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006804 File Offset: 0x00004A04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1171384, RefRangeEnd = 1171390, XrefRangeStart = 1171340, XrefRangeEnd = 1171384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completionOption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000687C File Offset: 0x00004A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171390, XrefRangeEnd = 1171406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completionOption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_SendAsyncWorker_Private_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000068F4 File Offset: 0x00004AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171421, RefRangeEnd = 1171422, XrefRangeStart = 1171406, XrefRangeEnd = 1171421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> GetStringAsync(string requestUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(requestUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr_GetStringAsync_Public_Task_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006944 File Offset: 0x00004B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171422, XrefRangeEnd = 1171429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> __n__0(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient.NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002426 File Offset: 0x00000626
		public HttpClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000069AC File Offset: 0x00004BAC
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000242F File Offset: 0x0000062F
		public unsafe static TimeSpan TimeoutDefault
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(HttpClient.NativeFieldInfoPtr_TimeoutDefault, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpClient.NativeFieldInfoPtr_TimeoutDefault, (void*)(&value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000069C8 File Offset: 0x00004BC8
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000243D File Offset: 0x0000063D
		public unsafe Uri base_address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_base_address);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_base_address), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000069F8 File Offset: 0x00004BF8
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000245C File Offset: 0x0000065C
		public unsafe CancellationTokenSource cts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_cts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_cts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00006A28 File Offset: 0x00004C28
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000247B File Offset: 0x0000067B
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00006A50 File Offset: 0x00004C50
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002496 File Offset: 0x00000696
		public unsafe HttpRequestHeaders headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestHeaders>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00006A80 File Offset: 0x00004C80
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000024B5 File Offset: 0x000006B5
		public unsafe long buffer_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_buffer_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_buffer_size)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00006AA8 File Offset: 0x00004CA8
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000024D0 File Offset: 0x000006D0
		public unsafe TimeSpan timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_TimeoutDefault;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_base_address;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_cts;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_buffer_size;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultRequestHeaders_Public_get_HttpRequestHeaders_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxResponseContentBufferSize_Public_get_Int64_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetAsync_Public_Task_1_HttpResponseMessage_String_HttpCompletionOption_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_PostAsync_Public_Task_1_HttpResponseMessage_Uri_HttpContent_CancellationToken_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_CancellationToken_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_SendAsyncWorker_Private_Task_1_HttpResponseMessage_HttpRequestMessage_HttpCompletionOption_CancellationToken_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetStringAsync_Public_Task_1_String_String_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("System.Net.Http.HttpClient+<SendAsyncWorker>d__47")]
		public sealed class _SendAsyncWorker_d__47 : ValueType
		{
			// Token: 0x060003F8 RID: 1016 RVA: 0x00014820 File Offset: 0x00012A20
			// Note: this type is marked as 'beforefieldinit'.
			static _SendAsyncWorker_d__47()
			{
				Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "<SendAsyncWorker>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr);
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "<>1__state");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "<>t__builder");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "<>4__this");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "cancellationToken");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "request");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_completionOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "completionOption");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr__lcts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "<lcts>5__2");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr__response_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "<response>5__3");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "<>u__1");
				HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, "<>u__2");
				HttpClient._SendAsyncWorker_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, 100663381);
				HttpClient._SendAsyncWorker_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr, 100663382);
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x0001493C File Offset: 0x00012B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171119, XrefRangeEnd = 1171161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient._SendAsyncWorker_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00014974 File Offset: 0x00012B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171161, XrefRangeEnd = 1171167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient._SendAsyncWorker_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x0000375A File Offset: 0x0000195A
			public _SendAsyncWorker_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00003763 File Offset: 0x00001963
			public _SendAsyncWorker_d__47()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClient._SendAsyncWorker_d__47>.NativeClassPtr))
			{
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060003FD RID: 1021 RVA: 0x000149BC File Offset: 0x00012BBC
			// (set) Token: 0x060003FE RID: 1022 RVA: 0x00003775 File Offset: 0x00001975
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060003FF RID: 1023 RVA: 0x000149E4 File Offset: 0x00012BE4
			// (set) Token: 0x06000400 RID: 1024 RVA: 0x00003790 File Offset: 0x00001990
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpResponseMessage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x00014A14 File Offset: 0x00012C14
			// (set) Token: 0x06000402 RID: 1026 RVA: 0x000037BE File Offset: 0x000019BE
			public unsafe HttpClient __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00014A44 File Offset: 0x00012C44
			// (set) Token: 0x06000404 RID: 1028 RVA: 0x000037DD File Offset: 0x000019DD
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000405 RID: 1029 RVA: 0x00014A74 File Offset: 0x00012C74
			// (set) Token: 0x06000406 RID: 1030 RVA: 0x0000380B File Offset: 0x00001A0B
			public unsafe HttpRequestMessage request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x00014AA4 File Offset: 0x00012CA4
			// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000382A File Offset: 0x00001A2A
			public unsafe HttpCompletionOption completionOption
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_completionOption);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr_completionOption)) = value;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x00014ACC File Offset: 0x00012CCC
			// (set) Token: 0x0600040A RID: 1034 RVA: 0x00003845 File Offset: 0x00001A45
			public unsafe CancellationTokenSource _lcts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr__lcts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr__lcts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x00014AFC File Offset: 0x00012CFC
			// (set) Token: 0x0600040C RID: 1036 RVA: 0x00003864 File Offset: 0x00001A64
			public unsafe HttpResponseMessage _response_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr__response_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr__response_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x00014B2C File Offset: 0x00012D2C
			// (set) Token: 0x0600040E RID: 1038 RVA: 0x00003883 File Offset: 0x00001A83
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x0600040F RID: 1039 RVA: 0x00014B5C File Offset: 0x00012D5C
			// (set) Token: 0x06000410 RID: 1040 RVA: 0x000038B1 File Offset: 0x00001AB1
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._SendAsyncWorker_d__47.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002E7 RID: 743
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002E8 RID: 744
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002E9 RID: 745
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002EA RID: 746
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040002EB RID: 747
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040002EC RID: 748
			private static readonly IntPtr NativeFieldInfoPtr_completionOption;

			// Token: 0x040002ED RID: 749
			private static readonly IntPtr NativeFieldInfoPtr__lcts_5__2;

			// Token: 0x040002EE RID: 750
			private static readonly IntPtr NativeFieldInfoPtr__response_5__3;

			// Token: 0x040002EF RID: 751
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002F0 RID: 752
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040002F1 RID: 753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002F2 RID: 754
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("System.Net.Http.HttpClient+<GetStringAsync>d__52")]
		public sealed class _GetStringAsync_d__52 : ValueType
		{
			// Token: 0x06000411 RID: 1041 RVA: 0x00014B8C File Offset: 0x00012D8C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetStringAsync_d__52()
			{
				Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpClient>.NativeClassPtr, "<GetStringAsync>d__52");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr);
				HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, "<>1__state");
				HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, "<>t__builder");
				HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, "<>4__this");
				HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr_requestUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, "requestUri");
				HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr__resp_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, "<resp>5__2");
				HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, "<>u__1");
				HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, "<>u__2");
				HttpClient._GetStringAsync_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, 100663383);
				HttpClient._GetStringAsync_d__52.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr, 100663384);
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x00014C6C File Offset: 0x00012E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171167, XrefRangeEnd = 1171243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient._GetStringAsync_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00014CA4 File Offset: 0x00012EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171243, XrefRangeEnd = 1171249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClient._GetStringAsync_d__52.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x000038DF File Offset: 0x00001ADF
			public _GetStringAsync_d__52(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x000038E8 File Offset: 0x00001AE8
			public _GetStringAsync_d__52()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClient._GetStringAsync_d__52>.NativeClassPtr))
			{
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000416 RID: 1046 RVA: 0x00014CEC File Offset: 0x00012EEC
			// (set) Token: 0x06000417 RID: 1047 RVA: 0x000038FA File Offset: 0x00001AFA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x00014D14 File Offset: 0x00012F14
			// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003915 File Offset: 0x00001B15
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x00014D44 File Offset: 0x00012F44
			// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003943 File Offset: 0x00001B43
			public unsafe HttpClient __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x00014D74 File Offset: 0x00012F74
			// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003962 File Offset: 0x00001B62
			public unsafe string requestUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr_requestUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr_requestUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600041E RID: 1054 RVA: 0x00014D9C File Offset: 0x00012F9C
			// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003981 File Offset: 0x00001B81
			public unsafe HttpResponseMessage _resp_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr__resp_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr__resp_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000420 RID: 1056 RVA: 0x00014DCC File Offset: 0x00012FCC
			// (set) Token: 0x06000421 RID: 1057 RVA: 0x000039A0 File Offset: 0x00001BA0
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x00014DFC File Offset: 0x00012FFC
			// (set) Token: 0x06000423 RID: 1059 RVA: 0x000039CE File Offset: 0x00001BCE
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClient._GetStringAsync_d__52.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002F3 RID: 755
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002F4 RID: 756
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002F5 RID: 757
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002F6 RID: 758
			private static readonly IntPtr NativeFieldInfoPtr_requestUri;

			// Token: 0x040002F7 RID: 759
			private static readonly IntPtr NativeFieldInfoPtr__resp_5__2;

			// Token: 0x040002F8 RID: 760
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002F9 RID: 761
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040002FA RID: 762
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002FB RID: 763
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
