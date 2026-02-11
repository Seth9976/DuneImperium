using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Net.Http.Headers;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Security.Principal;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000005 RID: 5
	public class MonoWebRequestHandler : Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00004D28 File Offset: 0x00002F28
		// Note: this type is marked as 'beforefieldinit'.
		static MonoWebRequestHandler()
		{
			Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "MonoWebRequestHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr);
			MonoWebRequestHandler.NativeFieldInfoPtr_groupCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "groupCounter");
			MonoWebRequestHandler.NativeFieldInfoPtr_allowAutoRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "allowAutoRedirect");
			MonoWebRequestHandler.NativeFieldInfoPtr_automaticDecompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "automaticDecompression");
			MonoWebRequestHandler.NativeFieldInfoPtr_cookieContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "cookieContainer");
			MonoWebRequestHandler.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "credentials");
			MonoWebRequestHandler.NativeFieldInfoPtr_maxAutomaticRedirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "maxAutomaticRedirections");
			MonoWebRequestHandler.NativeFieldInfoPtr_maxRequestContentBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "maxRequestContentBufferSize");
			MonoWebRequestHandler.NativeFieldInfoPtr_preAuthenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "preAuthenticate");
			MonoWebRequestHandler.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "proxy");
			MonoWebRequestHandler.NativeFieldInfoPtr_useCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "useCookies");
			MonoWebRequestHandler.NativeFieldInfoPtr_useProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "useProxy");
			MonoWebRequestHandler.NativeFieldInfoPtr_sslOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "sslOptions");
			MonoWebRequestHandler.NativeFieldInfoPtr_allowPipelining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "allowPipelining");
			MonoWebRequestHandler.NativeFieldInfoPtr_cachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "cachePolicy");
			MonoWebRequestHandler.NativeFieldInfoPtr_authenticationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "authenticationLevel");
			MonoWebRequestHandler.NativeFieldInfoPtr_continueTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "continueTimeout");
			MonoWebRequestHandler.NativeFieldInfoPtr_impersonationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "impersonationLevel");
			MonoWebRequestHandler.NativeFieldInfoPtr_maxResponseHeadersLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "maxResponseHeadersLength");
			MonoWebRequestHandler.NativeFieldInfoPtr_readWriteTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "readWriteTimeout");
			MonoWebRequestHandler.NativeFieldInfoPtr_serverCertificateValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "serverCertificateValidationCallback");
			MonoWebRequestHandler.NativeFieldInfoPtr_unsafeAuthenticatedConnectionSharing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "unsafeAuthenticatedConnectionSharing");
			MonoWebRequestHandler.NativeFieldInfoPtr_sentRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "sentRequest");
			MonoWebRequestHandler.NativeFieldInfoPtr_connectionGroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "connectionGroupName");
			MonoWebRequestHandler.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "timeout");
			MonoWebRequestHandler.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "disposed");
			MonoWebRequestHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663324);
			MonoWebRequestHandler.NativeMethodInfoPtr_EnsureModifiability_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663325);
			MonoWebRequestHandler.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663326);
			MonoWebRequestHandler.NativeMethodInfoPtr_set_AutomaticDecompression_Public_Virtual_Final_New_set_Void_DecompressionMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663327);
			MonoWebRequestHandler.NativeMethodInfoPtr_get_CookieContainer_Public_Virtual_Final_New_get_CookieContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663328);
			MonoWebRequestHandler.NativeMethodInfoPtr_get_MaxRequestContentBufferSize_Public_Virtual_Final_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663329);
			MonoWebRequestHandler.NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663330);
			MonoWebRequestHandler.NativeMethodInfoPtr_get_SslOptions_Public_Virtual_Final_New_get_SslClientAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663331);
			MonoWebRequestHandler.NativeMethodInfoPtr_set_SslOptions_Public_Virtual_Final_New_set_Void_SslClientAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663332);
			MonoWebRequestHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663333);
			MonoWebRequestHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663334);
			MonoWebRequestHandler.NativeMethodInfoPtr_GetConnectionKeepAlive_Private_Boolean_HttpRequestHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663335);
			MonoWebRequestHandler.NativeMethodInfoPtr_CreateWebRequest_Internal_Virtual_New_HttpWebRequest_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663336);
			MonoWebRequestHandler.NativeMethodInfoPtr_CreateResponseMessage_Private_HttpResponseMessage_HttpWebResponse_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663337);
			MonoWebRequestHandler.NativeMethodInfoPtr_MethodHasBody_Private_Static_Boolean_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663338);
			MonoWebRequestHandler.NativeMethodInfoPtr_SendAsync_Public_Virtual_Final_New_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663339);
			MonoWebRequestHandler.NativeMethodInfoPtr_System_Net_Http_IMonoHttpClientHandler_SetWebRequestTimeout_Private_Virtual_Final_New_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663340);
			MonoWebRequestHandler.NativeMethodInfoPtr__CreateWebRequest_b__96_0_Private_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000050B4 File Offset: 0x000032B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170622, XrefRangeEnd = 1170648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoWebRequestHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000050F0 File Offset: 0x000032F0
		[CallerCount(0)]
		public unsafe void EnsureModifiability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_EnsureModifiability_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000026 RID: 38
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00005124 File Offset: 0x00003324
		public unsafe virtual bool AllowAutoRedirect
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00005164 File Offset: 0x00003364
		public unsafe virtual DecompressionMethods AutomaticDecompression
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_set_AutomaticDecompression_Public_Virtual_Final_New_set_Void_DecompressionMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000051A4 File Offset: 0x000033A4
		public unsafe virtual CookieContainer CookieContainer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170648, XrefRangeEnd = 1170653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_get_CookieContainer_Public_Virtual_Final_New_get_CookieContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr3) : null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000051E4 File Offset: 0x000033E4
		public unsafe virtual long MaxRequestContentBufferSize
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_get_MaxRequestContentBufferSize_Public_Virtual_Final_New_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00005220 File Offset: 0x00003420
		public unsafe virtual bool SupportsAutomaticDecompression
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoWebRequestHandler.NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00005268 File Offset: 0x00003468
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000052A8 File Offset: 0x000034A8
		public unsafe virtual SslClientAuthenticationOptions SslOptions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170653, XrefRangeEnd = 1170658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_get_SslOptions_Public_Virtual_Final_New_get_SslClientAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SslClientAuthenticationOptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170658, XrefRangeEnd = 1170665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_set_SslOptions_Public_Virtual_Final_New_set_Void_SslClientAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000052EC File Offset: 0x000034EC
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005320 File Offset: 0x00003520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170665, XrefRangeEnd = 1170670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoWebRequestHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000536C File Offset: 0x0000356C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170670, XrefRangeEnd = 1170694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetConnectionKeepAlive(HttpRequestHeaders headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_GetConnectionKeepAlive_Private_Boolean_HttpRequestHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000053BC File Offset: 0x000035BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170694, XrefRangeEnd = 1170902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoWebRequestHandler.NativeMethodInfoPtr_CreateWebRequest_Internal_Virtual_New_HttpWebRequest_HttpRequestMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005418 File Offset: 0x00003618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170902, XrefRangeEnd = 1170932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_CreateResponseMessage_Private_HttpResponseMessage_HttpWebResponse_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr3) : null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005494 File Offset: 0x00003694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170932, XrefRangeEnd = 1170947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MethodHasBody(HttpMethod method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_MethodHasBody_Private_Static_Boolean_HttpMethod_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000054D8 File Offset: 0x000036D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170947, XrefRangeEnd = 1170964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_SendAsync_Public_Virtual_Final_New_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005540 File Offset: 0x00003740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170964, XrefRangeEnd = 1170967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Net_Http_IMonoHttpClientHandler_SetWebRequestTimeout(TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr_System_Net_Http_IMonoHttpClientHandler_SetWebRequestTimeout_Private_Virtual_Final_New_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005580 File Offset: 0x00003780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170967, XrefRangeEnd = 1170972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate _CreateWebRequest_b__96_0(string t, X509CertificateCollection lc, X509Certificate rc, Il2CppStringArray ai)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rc);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ai);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.NativeMethodInfoPtr__CreateWebRequest_b__96_0_Private_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020A5 File Offset: 0x000002A5
		public MonoWebRequestHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00005608 File Offset: 0x00003808
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000020AE File Offset: 0x000002AE
		public unsafe static long groupCounter
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(MonoWebRequestHandler.NativeFieldInfoPtr_groupCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoWebRequestHandler.NativeFieldInfoPtr_groupCounter, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00005624 File Offset: 0x00003824
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000020BC File Offset: 0x000002BC
		public unsafe bool allowAutoRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_allowAutoRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_allowAutoRedirect)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000564C File Offset: 0x0000384C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000020D7 File Offset: 0x000002D7
		public unsafe DecompressionMethods automaticDecompression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_automaticDecompression);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_automaticDecompression)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005674 File Offset: 0x00003874
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000020F2 File Offset: 0x000002F2
		public unsafe CookieContainer cookieContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_cookieContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_cookieContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000056A4 File Offset: 0x000038A4
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002111 File Offset: 0x00000311
		public unsafe ICredentials credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000056D4 File Offset: 0x000038D4
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002130 File Offset: 0x00000330
		public unsafe int maxAutomaticRedirections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_maxAutomaticRedirections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_maxAutomaticRedirections)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000056FC File Offset: 0x000038FC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000214B File Offset: 0x0000034B
		public unsafe long maxRequestContentBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_maxRequestContentBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_maxRequestContentBufferSize)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005724 File Offset: 0x00003924
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002166 File Offset: 0x00000366
		public unsafe bool preAuthenticate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_preAuthenticate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_preAuthenticate)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000574C File Offset: 0x0000394C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002181 File Offset: 0x00000381
		public unsafe IWebProxy proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000577C File Offset: 0x0000397C
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000021A0 File Offset: 0x000003A0
		public unsafe bool useCookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_useCookies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_useCookies)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000057A4 File Offset: 0x000039A4
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000021BB File Offset: 0x000003BB
		public unsafe bool useProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_useProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_useProxy)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000057CC File Offset: 0x000039CC
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000021D6 File Offset: 0x000003D6
		public unsafe SslClientAuthenticationOptions sslOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_sslOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslClientAuthenticationOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_sslOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000057FC File Offset: 0x000039FC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000021F5 File Offset: 0x000003F5
		public unsafe bool allowPipelining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_allowPipelining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_allowPipelining)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00005824 File Offset: 0x00003A24
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002210 File Offset: 0x00000410
		public unsafe RequestCachePolicy cachePolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_cachePolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_cachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005854 File Offset: 0x00003A54
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000222F File Offset: 0x0000042F
		public unsafe AuthenticationLevel authenticationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_authenticationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_authenticationLevel)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000587C File Offset: 0x00003A7C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000224A File Offset: 0x0000044A
		public unsafe TimeSpan continueTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_continueTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_continueTimeout)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000058A4 File Offset: 0x00003AA4
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002265 File Offset: 0x00000465
		public unsafe TokenImpersonationLevel impersonationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_impersonationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_impersonationLevel)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000058CC File Offset: 0x00003ACC
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002280 File Offset: 0x00000480
		public unsafe int maxResponseHeadersLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_maxResponseHeadersLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_maxResponseHeadersLength)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000058F4 File Offset: 0x00003AF4
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000229B File Offset: 0x0000049B
		public unsafe int readWriteTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_readWriteTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_readWriteTimeout)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000591C File Offset: 0x00003B1C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000022B6 File Offset: 0x000004B6
		public unsafe RemoteCertificateValidationCallback serverCertificateValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_serverCertificateValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_serverCertificateValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000594C File Offset: 0x00003B4C
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000022D5 File Offset: 0x000004D5
		public unsafe bool unsafeAuthenticatedConnectionSharing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_unsafeAuthenticatedConnectionSharing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_unsafeAuthenticatedConnectionSharing)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00005974 File Offset: 0x00003B74
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000022F0 File Offset: 0x000004F0
		public unsafe bool sentRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_sentRequest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_sentRequest)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000599C File Offset: 0x00003B9C
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000230B File Offset: 0x0000050B
		public unsafe string connectionGroupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_connectionGroupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_connectionGroupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000059C4 File Offset: 0x00003BC4
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000232A File Offset: 0x0000052A
		public Nullable<TimeSpan> timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_timeout);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_timeout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000059F4 File Offset: 0x00003BF4
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002358 File Offset: 0x00000558
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_groupCounter;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_allowAutoRedirect;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_automaticDecompression;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_cookieContainer;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_credentials;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_maxAutomaticRedirections;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_maxRequestContentBufferSize;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_preAuthenticate;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_proxy;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_useCookies;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_useProxy;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_sslOptions;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_allowPipelining;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_cachePolicy;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_authenticationLevel;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_continueTimeout;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_impersonationLevel;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_maxResponseHeadersLength;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_readWriteTimeout;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_serverCertificateValidationCallback;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_unsafeAuthenticatedConnectionSharing;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_sentRequest;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_connectionGroupName;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_EnsureModifiability_Internal_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_set_AutomaticDecompression_Public_Virtual_Final_New_set_Void_DecompressionMethods_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_CookieContainer_Public_Virtual_Final_New_get_CookieContainer_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxRequestContentBufferSize_Public_Virtual_Final_New_get_Int64_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_SslOptions_Public_Virtual_Final_New_get_SslClientAuthenticationOptions_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_set_SslOptions_Public_Virtual_Final_New_set_Void_SslClientAuthenticationOptions_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionKeepAlive_Private_Boolean_HttpRequestHeaders_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_CreateWebRequest_Internal_Virtual_New_HttpWebRequest_HttpRequestMessage_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_CreateResponseMessage_Private_HttpResponseMessage_HttpWebResponse_HttpRequestMessage_CancellationToken_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_MethodHasBody_Private_Static_Boolean_HttpMethod_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Virtual_Final_New_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_System_Net_Http_IMonoHttpClientHandler_SetWebRequestTimeout_Private_Virtual_Final_New_Void_TimeSpan_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__CreateWebRequest_b__96_0_Private_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;

		// Token: 0x0200003D RID: 61
		[ObfuscatedName("System.Net.Http.MonoWebRequestHandler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060003C9 RID: 969 RVA: 0x00014110 File Offset: 0x00012310
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr);
				MonoWebRequestHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, "<>9");
				MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__95_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, "<>9__95_0");
				MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__96_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, "<>9__96_1");
				MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__99_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, "<>9__99_0");
				MonoWebRequestHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, 100663343);
				MonoWebRequestHandler.__c.NativeMethodInfoPtr__GetConnectionKeepAlive_b__95_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, 100663344);
				MonoWebRequestHandler.__c.NativeMethodInfoPtr__CreateWebRequest_b__96_1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, 100663345);
				MonoWebRequestHandler.__c.NativeMethodInfoPtr__SendAsync_b__99_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr, 100663346);
			}

			// Token: 0x060003CA RID: 970 RVA: 0x000141DC File Offset: 0x000123DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoWebRequestHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00014218 File Offset: 0x00012418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170299, XrefRangeEnd = 1170302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConnectionKeepAlive_b__95_0(string l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.__c.NativeMethodInfoPtr__GetConnectionKeepAlive_b__95_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00014268 File Offset: 0x00012468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170302, XrefRangeEnd = 1170305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateWebRequest_b__96_1(string l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.__c.NativeMethodInfoPtr__CreateWebRequest_b__96_1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003CD RID: 973 RVA: 0x000142B8 File Offset: 0x000124B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170305, XrefRangeEnd = 1170309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendAsync_b__99_0(Object l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler.__c.NativeMethodInfoPtr__SendAsync_b__99_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003CE RID: 974 RVA: 0x000034D7 File Offset: 0x000016D7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060003CF RID: 975 RVA: 0x000142FC File Offset: 0x000124FC
			// (set) Token: 0x060003D0 RID: 976 RVA: 0x000034E0 File Offset: 0x000016E0
			public unsafe static MonoWebRequestHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoWebRequestHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x00014324 File Offset: 0x00012524
			// (set) Token: 0x060003D2 RID: 978 RVA: 0x000034F2 File Offset: 0x000016F2
			public unsafe static Func<string, bool> __9__95_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__95_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__95_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x0001434C File Offset: 0x0001254C
			// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003504 File Offset: 0x00001704
			public unsafe static Func<string, bool> __9__96_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__96_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__96_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x00014374 File Offset: 0x00012574
			// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003516 File Offset: 0x00001716
			public unsafe static Action<Object> __9__99_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__99_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MonoWebRequestHandler.__c.NativeFieldInfoPtr___9__99_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002CF RID: 719
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002D0 RID: 720
			private static readonly IntPtr NativeFieldInfoPtr___9__95_0;

			// Token: 0x040002D1 RID: 721
			private static readonly IntPtr NativeFieldInfoPtr___9__96_1;

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeFieldInfoPtr___9__99_0;

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeMethodInfoPtr__GetConnectionKeepAlive_b__95_0_Internal_Boolean_String_0;

			// Token: 0x040002D5 RID: 725
			private static readonly IntPtr NativeMethodInfoPtr__CreateWebRequest_b__96_1_Internal_Boolean_String_0;

			// Token: 0x040002D6 RID: 726
			private static readonly IntPtr NativeMethodInfoPtr__SendAsync_b__99_0_Internal_Void_Object_0;
		}

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99")]
		public sealed class _SendAsync_d__99 : ValueType
		{
			// Token: 0x060003D7 RID: 983 RVA: 0x0001439C File Offset: 0x0001259C
			// Note: this type is marked as 'beforefieldinit'.
			static _SendAsync_d__99()
			{
				Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoWebRequestHandler>.NativeClassPtr, "<SendAsync>d__99");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr);
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>1__state");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>t__builder");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>4__this");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "cancellationToken");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "request");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__wrequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<wrequest>5__2");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__wresponse_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<wresponse>5__3");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>7__wrap3");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__content_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<content>5__5");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>u__1");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__stream_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<stream>5__6");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>u__2");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>u__3");
				MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, "<>u__4");
				MonoWebRequestHandler._SendAsync_d__99.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, 100663347);
				MonoWebRequestHandler._SendAsync_d__99.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr, 100663348);
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00014508 File Offset: 0x00012708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170309, XrefRangeEnd = 1170616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler._SendAsync_d__99.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x00014540 File Offset: 0x00012740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170616, XrefRangeEnd = 1170622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoWebRequestHandler._SendAsync_d__99.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00003528 File Offset: 0x00001728
			public _SendAsync_d__99(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00003531 File Offset: 0x00001731
			public _SendAsync_d__99()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoWebRequestHandler._SendAsync_d__99>.NativeClassPtr))
			{
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060003DC RID: 988 RVA: 0x00014588 File Offset: 0x00012788
			// (set) Token: 0x060003DD RID: 989 RVA: 0x00003543 File Offset: 0x00001743
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060003DE RID: 990 RVA: 0x000145B0 File Offset: 0x000127B0
			// (set) Token: 0x060003DF RID: 991 RVA: 0x0000355E File Offset: 0x0000175E
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpResponseMessage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x000145E0 File Offset: 0x000127E0
			// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000358C File Offset: 0x0000178C
			public unsafe MonoWebRequestHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoWebRequestHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00014610 File Offset: 0x00012810
			// (set) Token: 0x060003E3 RID: 995 RVA: 0x000035AB File Offset: 0x000017AB
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00014640 File Offset: 0x00012840
			// (set) Token: 0x060003E5 RID: 997 RVA: 0x000035D9 File Offset: 0x000017D9
			public unsafe HttpRequestMessage request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x00014670 File Offset: 0x00012870
			// (set) Token: 0x060003E7 RID: 999 RVA: 0x000035F8 File Offset: 0x000017F8
			public unsafe HttpWebRequest _wrequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__wrequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__wrequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000146A0 File Offset: 0x000128A0
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003617 File Offset: 0x00001817
			public unsafe HttpWebResponse _wresponse_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__wresponse_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__wresponse_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x000146D0 File Offset: 0x000128D0
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003636 File Offset: 0x00001836
			public CancellationTokenRegistration __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___7__wrap3);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x00014700 File Offset: 0x00012900
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003664 File Offset: 0x00001864
			public unsafe HttpContent _content_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__content_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__content_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x00014730 File Offset: 0x00012930
			// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003683 File Offset: 0x00001883
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00014760 File Offset: 0x00012960
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x000036B1 File Offset: 0x000018B1
			public unsafe Stream _stream_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__stream_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr__stream_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00014790 File Offset: 0x00012990
			// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000036D0 File Offset: 0x000018D0
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000147C0 File Offset: 0x000129C0
			// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000036FE File Offset: 0x000018FE
			public ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000147F0 File Offset: 0x000129F0
			// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0000372C File Offset: 0x0000192C
			public TaskAwaiter<HttpResponseMessage> __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__4);
					return new TaskAwaiter<HttpResponseMessage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<HttpResponseMessage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoWebRequestHandler._SendAsync_d__99.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<HttpResponseMessage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002D7 RID: 727
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002D8 RID: 728
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002D9 RID: 729
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040002DB RID: 731
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeFieldInfoPtr__wrequest_5__2;

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeFieldInfoPtr__wresponse_5__3;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeFieldInfoPtr__content_5__5;

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__6;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
