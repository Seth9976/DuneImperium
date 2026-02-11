using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x02000203 RID: 515
	[Serializable]
	public class HttpWebResponse : WebResponse
	{
		// Token: 0x0600216A RID: 8554 RVA: 0x0009CFB0 File Offset: 0x0009B1B0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebResponse()
		{
			Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpWebResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr);
			HttpWebResponse.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "uri");
			HttpWebResponse.NativeFieldInfoPtr_webHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "webHeaders");
			HttpWebResponse.NativeFieldInfoPtr_cookieCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "cookieCollection");
			HttpWebResponse.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "method");
			HttpWebResponse.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "version");
			HttpWebResponse.NativeFieldInfoPtr_statusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "statusCode");
			HttpWebResponse.NativeFieldInfoPtr_statusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "statusDescription");
			HttpWebResponse.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "contentLength");
			HttpWebResponse.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "contentType");
			HttpWebResponse.NativeFieldInfoPtr_cookie_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "cookie_container");
			HttpWebResponse.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "disposed");
			HttpWebResponse.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, "stream");
			HttpWebResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668289);
			HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_HttpStatusCode_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668290);
			HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_WebResponseStream_CookieContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668291);
			HttpWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668292);
			HttpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668293);
			HttpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668294);
			HttpWebResponse.NativeMethodInfoPtr_get_StatusCode_Public_Virtual_New_get_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668295);
			HttpWebResponse.NativeMethodInfoPtr_get_StatusDescription_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668296);
			HttpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668297);
			HttpWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668298);
			HttpWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668299);
			HttpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668300);
			HttpWebResponse.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668301);
			HttpWebResponse.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668302);
			HttpWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668303);
			HttpWebResponse.NativeMethodInfoPtr_FillCookies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr, 100668304);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x0009D210 File Offset: 0x0009B410
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x0009D24C File Offset: 0x0009B44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482374, XrefRangeEnd = 482385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_HttpStatusCode_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x0009D2CC File Offset: 0x0009B4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482419, RefRangeEnd = 482420, XrefRangeStart = 482385, XrefRangeEnd = 482419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_WebResponseStream_CookieContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x0009D350 File Offset: 0x0009B550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482420, XrefRangeEnd = 482481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x0009D3B4 File Offset: 0x0009B5B4
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x0009D400 File Offset: 0x0009B600
		public unsafe override Uri ResponseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482481, XrefRangeEnd = 482482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x0009D44C File Offset: 0x0009B64C
		public unsafe virtual HttpStatusCode StatusCode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_StatusCode_Public_Virtual_New_get_HttpStatusCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x0009D494 File Offset: 0x0009B694
		public unsafe virtual string StatusDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482482, XrefRangeEnd = 482483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_get_StatusDescription_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0009D4D8 File Offset: 0x0009B6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482483, XrefRangeEnd = 482488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0009D524 File Offset: 0x0009B724
		[CallerCount(0)]
		public new unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0009D580 File Offset: 0x0009B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482488, XrefRangeEnd = 482515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0009D5E4 File Offset: 0x0009B7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482515, XrefRangeEnd = 482516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x0009D620 File Offset: 0x0009B820
		[CallerCount(0)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0009D654 File Offset: 0x0009B854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482516, XrefRangeEnd = 482517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebResponse.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0009D6A0 File Offset: 0x0009B8A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 482517, RefRangeEnd = 482520, XrefRangeStart = 482517, XrefRangeEnd = 482517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0009D6D4 File Offset: 0x0009B8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482534, RefRangeEnd = 482535, XrefRangeStart = 482520, XrefRangeEnd = 482534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillCookies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebResponse.NativeMethodInfoPtr_FillCookies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0000E678 File Offset: 0x0000C878
		public HttpWebResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x0009D708 File Offset: 0x0009B908
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x0000E681 File Offset: 0x0000C881
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x0009D738 File Offset: 0x0009B938
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public unsafe WebHeaderCollection webHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_webHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_webHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x0009D768 File Offset: 0x0009B968
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x0000E6BF File Offset: 0x0000C8BF
		public unsafe CookieCollection cookieCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookieCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookieCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0009D798 File Offset: 0x0009B998
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x0000E6DE File Offset: 0x0000C8DE
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0009D7C0 File Offset: 0x0009B9C0
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x0000E6FD File Offset: 0x0000C8FD
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x0009D7F0 File Offset: 0x0009B9F0
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x0000E71C File Offset: 0x0000C91C
		public unsafe HttpStatusCode statusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusCode)) = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x0009D818 File Offset: 0x0009BA18
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x0000E737 File Offset: 0x0000C937
		public unsafe string statusDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_statusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x0009D840 File Offset: 0x0009BA40
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x0000E756 File Offset: 0x0000C956
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x0009D868 File Offset: 0x0009BA68
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x0000E771 File Offset: 0x0000C971
		public unsafe string contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_contentType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x0009D890 File Offset: 0x0009BA90
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x0000E790 File Offset: 0x0000C990
		public unsafe CookieContainer cookie_container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookie_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_cookie_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x0000E7AF File Offset: 0x0000C9AF
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x0009D8E8 File Offset: 0x0009BAE8
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x0000E7CA File Offset: 0x0000C9CA
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebResponse.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeFieldInfoPtr_webHeaders;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeFieldInfoPtr_cookieCollection;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeFieldInfoPtr_statusCode;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr_statusDescription;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeFieldInfoPtr_cookie_container;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_HttpStatusCode_WebHeaderCollection_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_String_WebResponseStream_CookieContainer_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_Virtual_New_get_HttpStatusCode_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusDescription_Public_Virtual_New_get_String_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Private_Void_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr_FillCookies_Private_Void_0;
	}
}
