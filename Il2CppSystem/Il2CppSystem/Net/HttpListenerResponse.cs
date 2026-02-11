using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x020001FF RID: 511
	public sealed class HttpListenerResponse : Object
	{
		// Token: 0x0600203A RID: 8250 RVA: 0x00098D3C File Offset: 0x00096F3C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerResponse()
		{
			Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpListenerResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr);
			HttpListenerResponse.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "disposed");
			HttpListenerResponse.NativeFieldInfoPtr_content_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "content_encoding");
			HttpListenerResponse.NativeFieldInfoPtr_content_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "content_length");
			HttpListenerResponse.NativeFieldInfoPtr_cl_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "cl_set");
			HttpListenerResponse.NativeFieldInfoPtr_content_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "content_type");
			HttpListenerResponse.NativeFieldInfoPtr_cookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "cookies");
			HttpListenerResponse.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "headers");
			HttpListenerResponse.NativeFieldInfoPtr_keep_alive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "keep_alive");
			HttpListenerResponse.NativeFieldInfoPtr_output_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "output_stream");
			HttpListenerResponse.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "version");
			HttpListenerResponse.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "location");
			HttpListenerResponse.NativeFieldInfoPtr_status_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "status_code");
			HttpListenerResponse.NativeFieldInfoPtr_status_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "status_description");
			HttpListenerResponse.NativeFieldInfoPtr_chunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "chunked");
			HttpListenerResponse.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "context");
			HttpListenerResponse.NativeFieldInfoPtr_HeadersSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "HeadersSent");
			HttpListenerResponse.NativeFieldInfoPtr_headers_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "headers_lock");
			HttpListenerResponse.NativeFieldInfoPtr_force_close_chunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "force_close_chunked");
			HttpListenerResponse.NativeFieldInfoPtr_tspecials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, "tspecials");
			HttpListenerResponse.NativeMethodInfoPtr__ctor_Internal_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668145);
			HttpListenerResponse.NativeMethodInfoPtr_get_ForceCloseChunked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668146);
			HttpListenerResponse.NativeMethodInfoPtr_get_ContentEncoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668147);
			HttpListenerResponse.NativeMethodInfoPtr_set_ContentLength64_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668148);
			HttpListenerResponse.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668149);
			HttpListenerResponse.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668150);
			HttpListenerResponse.NativeMethodInfoPtr_set_KeepAlive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668151);
			HttpListenerResponse.NativeMethodInfoPtr_get_OutputStream_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668152);
			HttpListenerResponse.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668153);
			HttpListenerResponse.NativeMethodInfoPtr_set_SendChunked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668154);
			HttpListenerResponse.NativeMethodInfoPtr_set_StatusCode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668155);
			HttpListenerResponse.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668156);
			HttpListenerResponse.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668157);
			HttpListenerResponse.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668158);
			HttpListenerResponse.NativeMethodInfoPtr_Close_Public_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668159);
			HttpListenerResponse.NativeMethodInfoPtr_SendHeaders_Internal_Void_Boolean_MemoryStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668160);
			HttpListenerResponse.NativeMethodInfoPtr_FormatHeaders_Private_Static_String_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668161);
			HttpListenerResponse.NativeMethodInfoPtr_CookieToClientString_Private_Static_String_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668162);
			HttpListenerResponse.NativeMethodInfoPtr_QuotedString_Private_Static_String_Cookie_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668163);
			HttpListenerResponse.NativeMethodInfoPtr_IsToken_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr, 100668164);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00099078 File Offset: 0x00097278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480947, XrefRangeEnd = 480968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerResponse(HttpListenerContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr__ctor_Internal_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x000990C4 File Offset: 0x000972C4
		public unsafe bool ForceCloseChunked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_get_ForceCloseChunked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x00099100 File Offset: 0x00097300
		public unsafe Encoding ContentEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480968, XrefRangeEnd = 480970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_get_ContentEncoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x00099140 File Offset: 0x00097340
		public unsafe long ContentLength64
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 480970, RefRangeEnd = 480971, XrefRangeStart = 480970, XrefRangeEnd = 480970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_set_ContentLength64_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x00099180 File Offset: 0x00097380
		public unsafe string ContentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480971, XrefRangeEnd = 480986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x000991C4 File Offset: 0x000973C4
		public unsafe WebHeaderCollection Headers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x00099204 File Offset: 0x00097404
		public unsafe bool KeepAlive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 480986, RefRangeEnd = 480987, XrefRangeStart = 480986, XrefRangeEnd = 480986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_set_KeepAlive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x00099244 File Offset: 0x00097444
		public unsafe Stream OutputStream
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 480989, RefRangeEnd = 480991, XrefRangeStart = 480987, XrefRangeEnd = 480989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_get_OutputStream_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x00099284 File Offset: 0x00097484
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x000992C0 File Offset: 0x000974C0
		public unsafe bool SendChunked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 480991, RefRangeEnd = 480992, XrefRangeStart = 480991, XrefRangeEnd = 480991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_set_SendChunked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009FB RID: 2555
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x00099300 File Offset: 0x00097500
		public unsafe int StatusCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481014, RefRangeEnd = 481015, XrefRangeStart = 480992, XrefRangeEnd = 481014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_set_StatusCode_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00099340 File Offset: 0x00097540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481015, XrefRangeEnd = 481024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00099374 File Offset: 0x00097574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481024, XrefRangeEnd = 481026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000993B4 File Offset: 0x000975B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 481027, RefRangeEnd = 481029, XrefRangeStart = 481026, XrefRangeEnd = 481027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000993E8 File Offset: 0x000975E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 481032, RefRangeEnd = 481033, XrefRangeStart = 481029, XrefRangeEnd = 481032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(Il2CppStructArray<byte> responseEntity, bool willBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responseEntity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref willBlock;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_Close_Public_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00099438 File Offset: 0x00097638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 481147, RefRangeEnd = 481148, XrefRangeStart = 481033, XrefRangeEnd = 481147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHeaders(bool closing, MemoryStream ms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closing;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_SendHeaders_Internal_Void_Boolean_MemoryStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00099488 File Offset: 0x00097688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 481176, RefRangeEnd = 481177, XrefRangeStart = 481148, XrefRangeEnd = 481176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHeaders(WebHeaderCollection headers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_FormatHeaders_Private_Static_String_WebHeaderCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000994C4 File Offset: 0x000976C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 481213, RefRangeEnd = 481214, XrefRangeStart = 481177, XrefRangeEnd = 481213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CookieToClientString(Cookie cookie)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_CookieToClientString_Private_Static_String_Cookie_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00099500 File Offset: 0x00097700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 481225, RefRangeEnd = 481227, XrefRangeStart = 481214, XrefRangeEnd = 481225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QuotedString(Cookie cookie, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_QuotedString_Private_Static_String_Cookie_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00099550 File Offset: 0x00097750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481227, XrefRangeEnd = 481233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsToken(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerResponse.NativeMethodInfoPtr_IsToken_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		public HttpListenerResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x00099594 File Offset: 0x00097794
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x0000DCAD File Offset: 0x0000BEAD
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x000995BC File Offset: 0x000977BC
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		public unsafe Encoding content_encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_content_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_content_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x000995EC File Offset: 0x000977EC
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x0000DCE7 File Offset: 0x0000BEE7
		public unsafe long content_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_content_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_content_length)) = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00099614 File Offset: 0x00097814
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x0000DD02 File Offset: 0x0000BF02
		public unsafe bool cl_set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_cl_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_cl_set)) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x0009963C File Offset: 0x0009783C
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x0000DD1D File Offset: 0x0000BF1D
		public unsafe string content_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_content_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_content_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00099664 File Offset: 0x00097864
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		public unsafe CookieCollection cookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_cookies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_cookies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x00099694 File Offset: 0x00097894
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x0000DD5B File Offset: 0x0000BF5B
		public unsafe WebHeaderCollection headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x000996C4 File Offset: 0x000978C4
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x0000DD7A File Offset: 0x0000BF7A
		public unsafe bool keep_alive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_keep_alive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_keep_alive)) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x000996EC File Offset: 0x000978EC
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x0000DD95 File Offset: 0x0000BF95
		public unsafe ResponseStream output_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_output_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResponseStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_output_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0009971C File Offset: 0x0009791C
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0009974C File Offset: 0x0009794C
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x0000DDD3 File Offset: 0x0000BFD3
		public unsafe string location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_location);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_location), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x00099774 File Offset: 0x00097974
		// (set) Token: 0x06002067 RID: 8295 RVA: 0x0000DDF2 File Offset: 0x0000BFF2
		public unsafe int status_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_status_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_status_code)) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x0009979C File Offset: 0x0009799C
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x0000DE0D File Offset: 0x0000C00D
		public unsafe string status_description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_status_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_status_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x000997C4 File Offset: 0x000979C4
		// (set) Token: 0x0600206B RID: 8299 RVA: 0x0000DE2C File Offset: 0x0000C02C
		public unsafe bool chunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_chunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_chunked)) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000997EC File Offset: 0x000979EC
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x0000DE47 File Offset: 0x0000C047
		public unsafe HttpListenerContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0009981C File Offset: 0x00097A1C
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x0000DE66 File Offset: 0x0000C066
		public unsafe bool HeadersSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_HeadersSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_HeadersSent)) = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00099844 File Offset: 0x00097A44
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x0000DE81 File Offset: 0x0000C081
		public unsafe Object headers_lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_headers_lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_headers_lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x00099874 File Offset: 0x00097A74
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
		public unsafe bool force_close_chunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_force_close_chunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerResponse.NativeFieldInfoPtr_force_close_chunked)) = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0009989C File Offset: 0x00097A9C
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x0000DEBB File Offset: 0x0000C0BB
		public unsafe static string tspecials
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpListenerResponse.NativeFieldInfoPtr_tspecials, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpListenerResponse.NativeFieldInfoPtr_tspecials, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeFieldInfoPtr_content_encoding;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeFieldInfoPtr_content_length;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeFieldInfoPtr_cl_set;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeFieldInfoPtr_content_type;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeFieldInfoPtr_cookies;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeFieldInfoPtr_keep_alive;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeFieldInfoPtr_output_stream;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeFieldInfoPtr_status_code;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeFieldInfoPtr_status_description;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeFieldInfoPtr_chunked;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeFieldInfoPtr_HeadersSent;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeFieldInfoPtr_headers_lock;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeFieldInfoPtr_force_close_chunked;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeFieldInfoPtr_tspecials;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpListenerContext_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceCloseChunked_Internal_get_Boolean_0;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentEncoding_Public_get_Encoding_0;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLength64_Public_set_Void_Int64_0;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr_set_KeepAlive_Public_set_Void_Boolean_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputStream_Public_get_Stream_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_set_SendChunked_Public_set_Void_Boolean_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Public_set_Void_Int32_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_SendHeaders_Internal_Void_Boolean_MemoryStream_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_FormatHeaders_Private_Static_String_WebHeaderCollection_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_CookieToClientString_Private_Static_String_Cookie_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_QuotedString_Private_Static_String_Cookie_String_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_IsToken_Private_Static_Boolean_String_0;
	}
}
