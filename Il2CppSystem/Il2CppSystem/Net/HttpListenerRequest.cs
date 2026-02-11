using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net
{
	// Token: 0x020001FE RID: 510
	public sealed class HttpListenerRequest : Object
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x000981C0 File Offset: 0x000963C0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerRequest()
		{
			Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpListenerRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr);
			HttpListenerRequest.NativeFieldInfoPtr_accept_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "accept_types");
			HttpListenerRequest.NativeFieldInfoPtr_content_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "content_length");
			HttpListenerRequest.NativeFieldInfoPtr_cl_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "cl_set");
			HttpListenerRequest.NativeFieldInfoPtr_cookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "cookies");
			HttpListenerRequest.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "headers");
			HttpListenerRequest.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "method");
			HttpListenerRequest.NativeFieldInfoPtr_input_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "input_stream");
			HttpListenerRequest.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "version");
			HttpListenerRequest.NativeFieldInfoPtr_query_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "query_string");
			HttpListenerRequest.NativeFieldInfoPtr_raw_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "raw_url");
			HttpListenerRequest.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "url");
			HttpListenerRequest.NativeFieldInfoPtr_referrer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "referrer");
			HttpListenerRequest.NativeFieldInfoPtr_user_languages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "user_languages");
			HttpListenerRequest.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "context");
			HttpListenerRequest.NativeFieldInfoPtr_is_chunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "is_chunked");
			HttpListenerRequest.NativeFieldInfoPtr_ka_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "ka_set");
			HttpListenerRequest.NativeFieldInfoPtr_keep_alive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "keep_alive");
			HttpListenerRequest.NativeFieldInfoPtr__100continue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "_100continue");
			HttpListenerRequest.NativeFieldInfoPtr_separators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, "separators");
			HttpListenerRequest.NativeMethodInfoPtr__ctor_Internal_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668124);
			HttpListenerRequest.NativeMethodInfoPtr_SetRequestLine_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668125);
			HttpListenerRequest.NativeMethodInfoPtr_CreateQueryString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668126);
			HttpListenerRequest.NativeMethodInfoPtr_MaybeUri_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668127);
			HttpListenerRequest.NativeMethodInfoPtr_IsPredefinedScheme_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668128);
			HttpListenerRequest.NativeMethodInfoPtr_FinishInitialization_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668129);
			HttpListenerRequest.NativeMethodInfoPtr_Unquote_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668130);
			HttpListenerRequest.NativeMethodInfoPtr_AddHeader_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668131);
			HttpListenerRequest.NativeMethodInfoPtr_FlushInput_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668132);
			HttpListenerRequest.NativeMethodInfoPtr_get_HasEntityBody_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668133);
			HttpListenerRequest.NativeMethodInfoPtr_get_Headers_Public_get_NameValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668134);
			HttpListenerRequest.NativeMethodInfoPtr_get_InputStream_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668135);
			HttpListenerRequest.NativeMethodInfoPtr_get_IsSecureConnection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668136);
			HttpListenerRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668137);
			HttpListenerRequest.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668138);
			HttpListenerRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668139);
			HttpListenerRequest.NativeMethodInfoPtr_get_QueryString_Public_get_NameValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668140);
			HttpListenerRequest.NativeMethodInfoPtr_get_Url_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668141);
			HttpListenerRequest.NativeMethodInfoPtr_get_UserHostAddress_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668142);
			HttpListenerRequest.NativeMethodInfoPtr_get_UserHostName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr, 100668143);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000984FC File Offset: 0x000966FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480733, XrefRangeEnd = 480745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerRequest(HttpListenerContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr__ctor_Internal_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00098548 File Offset: 0x00096748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480760, RefRangeEnd = 480761, XrefRangeStart = 480745, XrefRangeEnd = 480760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRequestLine(string req)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(req);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_SetRequestLine_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0009858C File Offset: 0x0009678C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480761, XrefRangeEnd = 480786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateQueryString(string query)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(query);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_CreateQueryString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000985D0 File Offset: 0x000967D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480786, XrefRangeEnd = 480792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MaybeUri(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_MaybeUri_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00098614 File Offset: 0x00096814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480805, RefRangeEnd = 480806, XrefRangeStart = 480792, XrefRangeEnd = 480805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPredefinedScheme(string scheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_IsPredefinedScheme_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00098658 File Offset: 0x00096858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480806, XrefRangeEnd = 480832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FinishInitialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_FinishInitialization_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00098694 File Offset: 0x00096894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480832, XrefRangeEnd = 480852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Unquote(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_Unquote_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000986D0 File Offset: 0x000968D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480884, RefRangeEnd = 480885, XrefRangeStart = 480852, XrefRangeEnd = 480884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHeader(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_AddHeader_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00098714 File Offset: 0x00096914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480907, RefRangeEnd = 480908, XrefRangeStart = 480885, XrefRangeEnd = 480907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FlushInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_FlushInput_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x00098750 File Offset: 0x00096950
		public unsafe bool HasEntityBody
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_HasEntityBody_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0009878C File Offset: 0x0009698C
		public unsafe NameValueCollection Headers
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_Headers_Public_get_NameValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x000987CC File Offset: 0x000969CC
		public unsafe Stream InputStream
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 480913, RefRangeEnd = 480915, XrefRangeStart = 480908, XrefRangeEnd = 480913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_InputStream_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x0009880C File Offset: 0x00096A0C
		public unsafe bool IsSecureConnection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_IsSecureConnection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x00098848 File Offset: 0x00096A48
		public unsafe bool KeepAlive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 480932, RefRangeEnd = 480934, XrefRangeStart = 480915, XrefRangeEnd = 480932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x00098884 File Offset: 0x00096A84
		public unsafe IPEndPoint LocalEndPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 480940, RefRangeEnd = 480941, XrefRangeStart = 480934, XrefRangeEnd = 480940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x000988C4 File Offset: 0x00096AC4
		public unsafe Version ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x00098904 File Offset: 0x00096B04
		public unsafe NameValueCollection QueryString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_QueryString_Public_get_NameValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00098944 File Offset: 0x00096B44
		public unsafe Uri Url
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_Url_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x00098984 File Offset: 0x00096B84
		public unsafe string UserHostAddress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480941, XrefRangeEnd = 480943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_UserHostAddress_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x000989BC File Offset: 0x00096BBC
		public unsafe string UserHostName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480943, XrefRangeEnd = 480947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequest.NativeMethodInfoPtr_get_UserHostName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		public HttpListenerRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x000989F4 File Offset: 0x00096BF4
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x0000DA85 File Offset: 0x0000BC85
		public unsafe Il2CppStringArray accept_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_accept_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_accept_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x00098A24 File Offset: 0x00096C24
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
		public unsafe long content_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_content_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_content_length)) = value;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00098A4C File Offset: 0x00096C4C
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x0000DABF File Offset: 0x0000BCBF
		public unsafe bool cl_set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_cl_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_cl_set)) = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00098A74 File Offset: 0x00096C74
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x0000DADA File Offset: 0x0000BCDA
		public unsafe CookieCollection cookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_cookies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_cookies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x00098AA4 File Offset: 0x00096CA4
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x0000DAF9 File Offset: 0x0000BCF9
		public unsafe WebHeaderCollection headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x00098AD4 File Offset: 0x00096CD4
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0000DB18 File Offset: 0x0000BD18
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00098AFC File Offset: 0x00096CFC
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0000DB37 File Offset: 0x0000BD37
		public unsafe Stream input_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_input_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_input_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00098B2C File Offset: 0x00096D2C
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x0000DB56 File Offset: 0x0000BD56
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00098B5C File Offset: 0x00096D5C
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x0000DB75 File Offset: 0x0000BD75
		public unsafe NameValueCollection query_string
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_query_string);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_query_string), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00098B8C File Offset: 0x00096D8C
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x0000DB94 File Offset: 0x0000BD94
		public unsafe string raw_url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_raw_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_raw_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00098BB4 File Offset: 0x00096DB4
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x0000DBB3 File Offset: 0x0000BDB3
		public unsafe Uri url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_url);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_url), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00098BE4 File Offset: 0x00096DE4
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x0000DBD2 File Offset: 0x0000BDD2
		public unsafe Uri referrer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_referrer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_referrer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00098C14 File Offset: 0x00096E14
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x0000DBF1 File Offset: 0x0000BDF1
		public unsafe Il2CppStringArray user_languages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_user_languages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_user_languages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00098C44 File Offset: 0x00096E44
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x0000DC10 File Offset: 0x0000BE10
		public unsafe HttpListenerContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00098C74 File Offset: 0x00096E74
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x0000DC2F File Offset: 0x0000BE2F
		public unsafe bool is_chunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_is_chunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_is_chunked)) = value;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x00098C9C File Offset: 0x00096E9C
		// (set) Token: 0x06002033 RID: 8243 RVA: 0x0000DC4A File Offset: 0x0000BE4A
		public unsafe bool ka_set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_ka_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_ka_set)) = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x00098CC4 File Offset: 0x00096EC4
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x0000DC65 File Offset: 0x0000BE65
		public unsafe bool keep_alive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_keep_alive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequest.NativeFieldInfoPtr_keep_alive)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00098CEC File Offset: 0x00096EEC
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x0000DC80 File Offset: 0x0000BE80
		public unsafe static Il2CppStructArray<byte> _100continue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpListenerRequest.NativeFieldInfoPtr__100continue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpListenerRequest.NativeFieldInfoPtr__100continue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00098D14 File Offset: 0x00096F14
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x0000DC92 File Offset: 0x0000BE92
		public unsafe static Il2CppStructArray<char> separators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpListenerRequest.NativeFieldInfoPtr_separators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpListenerRequest.NativeFieldInfoPtr_separators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeFieldInfoPtr_accept_types;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeFieldInfoPtr_content_length;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeFieldInfoPtr_cl_set;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeFieldInfoPtr_cookies;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeFieldInfoPtr_input_stream;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeFieldInfoPtr_query_string;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeFieldInfoPtr_raw_url;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeFieldInfoPtr_referrer;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeFieldInfoPtr_user_languages;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeFieldInfoPtr_is_chunked;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeFieldInfoPtr_ka_set;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeFieldInfoPtr_keep_alive;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeFieldInfoPtr__100continue;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeFieldInfoPtr_separators;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpListenerContext_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestLine_Internal_Void_String_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryString_Private_Void_String_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_MaybeUri_Private_Static_Boolean_String_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_IsPredefinedScheme_Private_Static_Boolean_String_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitialization_Internal_Boolean_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_Unquote_Internal_Static_String_String_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_AddHeader_Internal_Void_String_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_FlushInput_Internal_Boolean_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_get_HasEntityBody_Public_get_Boolean_0;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_NameValueCollection_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_get_InputStream_Public_get_Stream_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSecureConnection_Public_get_Boolean_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalEndPoint_Public_get_IPEndPoint_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_get_QueryString_Public_get_NameValueCollection_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Public_get_Uri_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_get_UserHostAddress_Public_get_String_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_get_UserHostName_Public_get_String_0;
	}
}
