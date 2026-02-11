using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000202 RID: 514
	[Serializable]
	public class HttpWebRequest : WebRequest
	{
		// Token: 0x06002097 RID: 8343 RVA: 0x00099E90 File Offset: 0x00098090
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebRequest()
		{
			Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpWebRequest");
			HttpWebRequest.NativeFieldInfoPtr_requestUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "requestUri");
			HttpWebRequest.NativeFieldInfoPtr_actualUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "actualUri");
			HttpWebRequest.NativeFieldInfoPtr_hostChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "hostChanged");
			HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "allowAutoRedirect");
			HttpWebRequest.NativeFieldInfoPtr_allowBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "allowBuffering");
			HttpWebRequest.NativeFieldInfoPtr_certificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "certificates");
			HttpWebRequest.NativeFieldInfoPtr_connectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "connectionGroup");
			HttpWebRequest.NativeFieldInfoPtr_haveContentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "haveContentLength");
			HttpWebRequest.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "contentLength");
			HttpWebRequest.NativeFieldInfoPtr_continueDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "continueDelegate");
			HttpWebRequest.NativeFieldInfoPtr_cookieContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "cookieContainer");
			HttpWebRequest.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "credentials");
			HttpWebRequest.NativeFieldInfoPtr_haveResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "haveResponse");
			HttpWebRequest.NativeFieldInfoPtr_requestSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "requestSent");
			HttpWebRequest.NativeFieldInfoPtr_webHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "webHeaders");
			HttpWebRequest.NativeFieldInfoPtr_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "keepAlive");
			HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "maxAutoRedirect");
			HttpWebRequest.NativeFieldInfoPtr_mediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "mediaType");
			HttpWebRequest.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "method");
			HttpWebRequest.NativeFieldInfoPtr_initialMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "initialMethod");
			HttpWebRequest.NativeFieldInfoPtr_pipelined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "pipelined");
			HttpWebRequest.NativeFieldInfoPtr_preAuthenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "preAuthenticate");
			HttpWebRequest.NativeFieldInfoPtr_usedPreAuth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "usedPreAuth");
			HttpWebRequest.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "version");
			HttpWebRequest.NativeFieldInfoPtr_force_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "force_version");
			HttpWebRequest.NativeFieldInfoPtr_actualVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "actualVersion");
			HttpWebRequest.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "proxy");
			HttpWebRequest.NativeFieldInfoPtr_sendChunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "sendChunked");
			HttpWebRequest.NativeFieldInfoPtr_servicePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "servicePoint");
			HttpWebRequest.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "timeout");
			HttpWebRequest.NativeFieldInfoPtr_continueTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "continueTimeout");
			HttpWebRequest.NativeFieldInfoPtr_writeStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "writeStream");
			HttpWebRequest.NativeFieldInfoPtr_webResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "webResponse");
			HttpWebRequest.NativeFieldInfoPtr_responseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "responseTask");
			HttpWebRequest.NativeFieldInfoPtr_currentOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "currentOperation");
			HttpWebRequest.NativeFieldInfoPtr_aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "aborted");
			HttpWebRequest.NativeFieldInfoPtr_gotRequestStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "gotRequestStream");
			HttpWebRequest.NativeFieldInfoPtr_redirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "redirects");
			HttpWebRequest.NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "expectContinue");
			HttpWebRequest.NativeFieldInfoPtr_getResponseCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "getResponseCalled");
			HttpWebRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "locker");
			HttpWebRequest.NativeFieldInfoPtr_finished_reading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "finished_reading");
			HttpWebRequest.NativeFieldInfoPtr_auto_decomp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "auto_decomp");
			HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "defaultMaxResponseHeadersLength");
			HttpWebRequest.NativeFieldInfoPtr_defaultMaximumErrorResponseLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "defaultMaximumErrorResponseLength");
			HttpWebRequest.NativeFieldInfoPtr_defaultCachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "defaultCachePolicy");
			HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "readWriteTimeout");
			HttpWebRequest.NativeFieldInfoPtr_tlsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "tlsProvider");
			HttpWebRequest.NativeFieldInfoPtr_tlsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "tlsSettings");
			HttpWebRequest.NativeFieldInfoPtr_certValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "certValidationCallback");
			HttpWebRequest.NativeFieldInfoPtr_hostHasPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "hostHasPort");
			HttpWebRequest.NativeFieldInfoPtr_hostUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "hostUri");
			HttpWebRequest.NativeFieldInfoPtr_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "auth_state");
			HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "proxy_auth_state");
			HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "ResendContentFactory");
			HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<ThrowOnError>k__BackingField");
			HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "unsafe_auth_blah");
			HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668176);
			HttpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_MobileTlsProvider_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668177);
			HttpWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668178);
			HttpWebRequest.NativeMethodInfoPtr_ResetAuthorization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668179);
			HttpWebRequest.NativeMethodInfoPtr_get_Address_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668180);
			HttpWebRequest.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668181);
			HttpWebRequest.NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668182);
			HttpWebRequest.NativeMethodInfoPtr_set_AllowWriteStreamBuffering_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668183);
			HttpWebRequest.NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668184);
			HttpWebRequest.NativeMethodInfoPtr_set_AutomaticDecompression_Public_set_Void_DecompressionMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668185);
			HttpWebRequest.NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668186);
			HttpWebRequest.NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668187);
			HttpWebRequest.NativeMethodInfoPtr_get_TlsProvider_Internal_get_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668188);
			HttpWebRequest.NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668189);
			HttpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668190);
			HttpWebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668191);
			HttpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668192);
			HttpWebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668193);
			HttpWebRequest.NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668194);
			HttpWebRequest.NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668195);
			HttpWebRequest.NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668196);
			HttpWebRequest.NativeMethodInfoPtr_set_CookieContainer_Public_Virtual_New_set_Void_CookieContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668197);
			HttpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668198);
			HttpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668199);
			HttpWebRequest.NativeMethodInfoPtr_get_DefaultMaximumErrorResponseLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668200);
			HttpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668201);
			HttpWebRequest.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668202);
			HttpWebRequest.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668203);
			HttpWebRequest.NativeMethodInfoPtr_TryGetHostUri_Private_Boolean_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668204);
			HttpWebRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668205);
			HttpWebRequest.NativeMethodInfoPtr_set_KeepAlive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668206);
			HttpWebRequest.NativeMethodInfoPtr_set_MaximumAutomaticRedirections_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668207);
			HttpWebRequest.NativeMethodInfoPtr_get_DefaultMaximumResponseHeadersLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668208);
			HttpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668209);
			HttpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668210);
			HttpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668211);
			HttpWebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668212);
			HttpWebRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668213);
			HttpWebRequest.NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668214);
			HttpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668215);
			HttpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668216);
			HttpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668217);
			HttpWebRequest.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668218);
			HttpWebRequest.NativeMethodInfoPtr_set_SendChunked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668219);
			HttpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668220);
			HttpWebRequest.NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668221);
			HttpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668222);
			HttpWebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668223);
			HttpWebRequest.NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668224);
			HttpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668225);
			HttpWebRequest.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668226);
			HttpWebRequest.NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668227);
			HttpWebRequest.NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668228);
			HttpWebRequest.NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668229);
			HttpWebRequest.NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668230);
			HttpWebRequest.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668231);
			HttpWebRequest.NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_get_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668232);
			HttpWebRequest.NativeMethodInfoPtr_set_ServerCertificateValidationCallback_Public_set_Void_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668233);
			HttpWebRequest.NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668234);
			HttpWebRequest.NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668235);
			HttpWebRequest.NativeMethodInfoPtr_MyGetRequestStreamAsync_Private_Task_1_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668236);
			HttpWebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668237);
			HttpWebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668238);
			HttpWebRequest.NativeMethodInfoPtr_GetRequestStreamAsync_Public_Virtual_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668239);
			HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_Func_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668240);
			HttpWebRequest.NativeMethodInfoPtr_RunWithTimeoutWorker_Private_Static_Task_1_T_Task_1_T_Int32_Action_Func_1_Boolean_CancellationTokenSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668241);
			HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668242);
			HttpWebRequest.NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668243);
			HttpWebRequest.NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668244);
			HttpWebRequest.NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668245);
			HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668246);
			HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_Static_WebException_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668247);
			HttpWebRequest.NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668248);
			HttpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668249);
			HttpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668250);
			HttpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668251);
			HttpWebRequest.NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668252);
			HttpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668253);
			HttpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668254);
			HttpWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668255);
			HttpWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668256);
			HttpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668257);
			HttpWebRequest.NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668258);
			HttpWebRequest.NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668259);
			HttpWebRequest.NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668260);
			HttpWebRequest.NativeMethodInfoPtr_GetHeaders_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668261);
			HttpWebRequest.NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668262);
			HttpWebRequest.NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668263);
			HttpWebRequest.NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668264);
			HttpWebRequest.NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668265);
			HttpWebRequest.NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668266);
			HttpWebRequest.NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668267);
			HttpWebRequest.NativeMethodInfoPtr__RunWithTimeout_b__242_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668268);
			HttpWebRequest.NativeMethodInfoPtr__GetRewriteHandler_b__271_0_Private_Task_1_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668269);
			HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100668270);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0009AA98 File Offset: 0x00098C98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 481631, RefRangeEnd = 481634, XrefRangeStart = 481594, XrefRangeEnd = 481631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x0009AAE4 File Offset: 0x00098CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 481637, RefRangeEnd = 481638, XrefRangeStart = 481634, XrefRangeEnd = 481637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tlsProvider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_MobileTlsProvider_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0009AB54 File Offset: 0x00098D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481638, XrefRangeEnd = 481664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0009ABB8 File Offset: 0x00098DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481664, XrefRangeEnd = 481668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAuthorization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_ResetAuthorization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0009ABEC File Offset: 0x00098DEC
		public unsafe Uri Address
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Address_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (set) Token: 0x0600209D RID: 8349 RVA: 0x0009AC2C File Offset: 0x00098E2C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0009AC78 File Offset: 0x00098E78
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x0009ACC0 File Offset: 0x00098EC0
		public unsafe virtual bool AllowWriteStreamBuffering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_AllowWriteStreamBuffering_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0009AD0C File Offset: 0x00098F0C
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x0009AD48 File Offset: 0x00098F48
		public unsafe DecompressionMethods AutomaticDecompression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481668, RefRangeEnd = 481669, XrefRangeStart = 481668, XrefRangeEnd = 481668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_AutomaticDecompression_Public_set_Void_DecompressionMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x0009AD88 File Offset: 0x00098F88
		public unsafe bool InternalAllowBuffering
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481669, RefRangeEnd = 481670, XrefRangeStart = 481669, XrefRangeEnd = 481669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0009ADC4 File Offset: 0x00098FC4
		public unsafe bool MethodWithBuffer
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 481685, RefRangeEnd = 481687, XrefRangeStart = 481670, XrefRangeEnd = 481685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0009AE00 File Offset: 0x00099000
		public unsafe MobileTlsProvider TlsProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TlsProvider_Internal_get_MobileTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr3) : null;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0009AE40 File Offset: 0x00099040
		public unsafe MonoTlsSettings TlsSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0009AE80 File Offset: 0x00099080
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481692, RefRangeEnd = 481693, XrefRangeStart = 481687, XrefRangeEnd = 481692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x0009AEC0 File Offset: 0x000990C0
		public unsafe override string ConnectionGroupName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0009AF10 File Offset: 0x00099110
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x0009AF58 File Offset: 0x00099158
		public unsafe override long ContentLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x0009AFA4 File Offset: 0x000991A4
		public unsafe long InternalContentLength
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0009AFE4 File Offset: 0x000991E4
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x0009B020 File Offset: 0x00099220
		public unsafe bool ThrowOnError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x0009B060 File Offset: 0x00099260
		public unsafe virtual CookieContainer CookieContainer
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_CookieContainer_Public_Virtual_New_set_Void_CookieContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0009B0B0 File Offset: 0x000992B0
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0009B0FC File Offset: 0x000992FC
		public unsafe override ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0009B14C File Offset: 0x0009934C
		public unsafe static int DefaultMaximumErrorResponseLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481693, XrefRangeEnd = 481697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_DefaultMaximumErrorResponseLength_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0009B17C File Offset: 0x0009937C
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0009B1C8 File Offset: 0x000993C8
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x0009B200 File Offset: 0x00099400
		public unsafe string Host
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 481704, RefRangeEnd = 481707, XrefRangeStart = 481697, XrefRangeEnd = 481704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481722, RefRangeEnd = 481723, XrefRangeStart = 481707, XrefRangeEnd = 481722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0009B244 File Offset: 0x00099444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481723, XrefRangeEnd = 481733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetHostUri(string hostName, out Uri hostUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_TryGetHostUri_Private_Boolean_String_byref_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			hostUri = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0009B2B4 File Offset: 0x000994B4
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0009B2F0 File Offset: 0x000994F0
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_KeepAlive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x0009B330 File Offset: 0x00099530
		public unsafe int MaximumAutomaticRedirections
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481733, RefRangeEnd = 481734, XrefRangeStart = 481733, XrefRangeEnd = 481733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_MaximumAutomaticRedirections_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0009B370 File Offset: 0x00099570
		public unsafe static int DefaultMaximumResponseHeadersLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481734, XrefRangeEnd = 481738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_DefaultMaximumResponseHeadersLength_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0009B3A0 File Offset: 0x000995A0
		public unsafe int ReadWriteTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0009B3DC File Offset: 0x000995DC
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x0009B420 File Offset: 0x00099620
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481738, XrefRangeEnd = 481770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0009B470 File Offset: 0x00099670
		public unsafe override bool PreAuthenticate
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0009B4BC File Offset: 0x000996BC
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0009B4FC File Offset: 0x000996FC
		public unsafe Version ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481787, RefRangeEnd = 481788, XrefRangeStart = 481770, XrefRangeEnd = 481787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0009B540 File Offset: 0x00099740
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x0009B58C File Offset: 0x0009978C
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481788, XrefRangeEnd = 481797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0009B5DC File Offset: 0x000997DC
		public unsafe override Uri RequestUri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0009B628 File Offset: 0x00099828
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x0009B664 File Offset: 0x00099864
		public unsafe bool SendChunked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481797, RefRangeEnd = 481798, XrefRangeStart = 481797, XrefRangeEnd = 481797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_SendChunked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0009B6A4 File Offset: 0x000998A4
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 481799, RefRangeEnd = 481804, XrefRangeStart = 481798, XrefRangeEnd = 481799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0009B6E4 File Offset: 0x000998E4
		public unsafe ServicePoint ServicePointNoLock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x0009B724 File Offset: 0x00099924
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x0009B76C File Offset: 0x0009996C
		public unsafe override int Timeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0009B7B8 File Offset: 0x000999B8
		public unsafe string TransferEncoding
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481808, RefRangeEnd = 481809, XrefRangeStart = 481804, XrefRangeEnd = 481808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0009B7F0 File Offset: 0x000999F0
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481809, XrefRangeEnd = 481813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x0009B838 File Offset: 0x00099A38
		public unsafe bool UnsafeAuthenticatedConnectionSharing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0009B874 File Offset: 0x00099A74
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x0009B8B0 File Offset: 0x00099AB0
		public unsafe bool ExpectContinue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0009B8F0 File Offset: 0x00099AF0
		public unsafe Uri AuthUri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0009B930 File Offset: 0x00099B30
		public unsafe bool ProxyQuery
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481813, RefRangeEnd = 481814, XrefRangeStart = 481813, XrefRangeEnd = 481813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0009B96C File Offset: 0x00099B6C
		public unsafe ServerCertValidationCallback ServerCertValidationCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0009B9AC File Offset: 0x00099BAC
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0009B9EC File Offset: 0x00099BEC
		public unsafe RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481814, RefRangeEnd = 481815, XrefRangeStart = 481814, XrefRangeEnd = 481814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_get_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 481827, RefRangeEnd = 481828, XrefRangeStart = 481815, XrefRangeEnd = 481827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ServerCertificateValidationCallback_Public_set_Void_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0009BA30 File Offset: 0x00099C30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 481837, RefRangeEnd = 481840, XrefRangeStart = 481828, XrefRangeEnd = 481837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint GetServicePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0009BA70 File Offset: 0x00099C70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 481854, RefRangeEnd = 481856, XrefRangeStart = 481840, XrefRangeEnd = 481854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref redirecting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr3) : null;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0009BAE8 File Offset: 0x00099CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481856, XrefRangeEnd = 481882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_MyGetRequestStreamAsync_Private_Task_1_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
			}
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0009BB40 File Offset: 0x00099D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481882, XrefRangeEnd = 481892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginGetRequestStream(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x0009BBB0 File Offset: 0x00099DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481892, XrefRangeEnd = 481895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0009BC0C File Offset: 0x00099E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481895, XrefRangeEnd = 481904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Stream> GetRequestStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_GetRequestStreamAsync_Public_Virtual_Task_1_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0009BC58 File Offset: 0x00099E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 481924, RefRangeEnd = 481925, XrefRangeStart = 481904, XrefRangeEnd = 481924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abort);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aborted);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_Func_1_Boolean_CancellationToken_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0009BCE8 File Offset: 0x00099EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481925, XrefRangeEnd = 481936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abort);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aborted);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric_RunWithTimeoutWorker_Private_Static_Task_1_T_Task_1_T_Int32_Action_Func_1_Boolean_CancellationTokenSource_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0009BD74 File Offset: 0x00099F74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 481964, RefRangeEnd = 481967, XrefRangeStart = 481936, XrefRangeEnd = 481964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0009BDC4 File Offset: 0x00099FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481967, XrefRangeEnd = 481983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpWebResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0009BE1C File Offset: 0x0009A01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481983, XrefRangeEnd = 481999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>(intPtr3) : null;
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x0009BE84 File Offset: 0x0009A084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 482006, RefRangeEnd = 482008, XrefRangeStart = 481999, XrefRangeEnd = 482006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FlattenException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x0009BEC8 File Offset: 0x0009A0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482013, RefRangeEnd = 482014, XrefRangeStart = 482008, XrefRangeEnd = 482013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException GetWebException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
			}
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0009BF18 File Offset: 0x0009A118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482034, RefRangeEnd = 482035, XrefRangeStart = 482014, XrefRangeEnd = 482034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebException GetWebException(Exception e, bool aborted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aborted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_Static_WebException_Exception_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0009BF6C File Offset: 0x0009A16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482045, RefRangeEnd = 482046, XrefRangeStart = 482035, XrefRangeEnd = 482045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebException CreateRequestAbortedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0009BFA0 File Offset: 0x0009A1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482046, XrefRangeEnd = 482076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginGetResponse(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0009C010 File Offset: 0x0009A210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482076, XrefRangeEnd = 482079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x0009C06C File Offset: 0x0009A26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482079, XrefRangeEnd = 482082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x17000A6A RID: 2666
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0009C0B8 File Offset: 0x0009A2B8
		public unsafe bool FinishedReading
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0009C0F8 File Offset: 0x0009A2F8
		public unsafe bool Aborted
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 482083, RefRangeEnd = 482094, XrefRangeStart = 482082, XrefRangeEnd = 482083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0009C134 File Offset: 0x0009A334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482094, XrefRangeEnd = 482101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x0009C170 File Offset: 0x0009A370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482101, XrefRangeEnd = 482106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0009C1CC File Offset: 0x0009A3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482106, XrefRangeEnd = 482111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x0009C230 File Offset: 0x0009A430
		[CallerCount(0)]
		public unsafe void CheckRequestStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0009C264 File Offset: 0x0009A464
		[CallerCount(0)]
		public unsafe void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0009C2B4 File Offset: 0x0009A4B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482118, RefRangeEnd = 482119, XrefRangeStart = 482111, XrefRangeEnd = 482118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RewriteRedirectToGet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0009C2E8 File Offset: 0x0009A4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482119, XrefRangeEnd = 482139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Redirect(HttpStatusCode code, WebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0009C344 File Offset: 0x0009A544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482236, RefRangeEnd = 482237, XrefRangeStart = 482139, XrefRangeEnd = 482236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetHeaders_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0009C37C File Offset: 0x0009A57C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482257, RefRangeEnd = 482258, XrefRangeStart = 482237, XrefRangeEnd = 482257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPreAuthenticate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x0009C3B0 File Offset: 0x0009A5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482296, RefRangeEnd = 482297, XrefRangeStart = 482258, XrefRangeEnd = 482296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetRequestHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0009C3F0 File Offset: 0x0009A5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482317, RefRangeEnd = 482318, XrefRangeStart = 482297, XrefRangeEnd = 482317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<WebOperation, bool>(intPtr);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0009C474 File Offset: 0x0009A674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482318, XrefRangeEnd = 482320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0009C4D0 File Offset: 0x0009A6D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482331, RefRangeEnd = 482332, XrefRangeStart = 482320, XrefRangeEnd = 482331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref redirect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Task<BufferOffsetSize>, WebException>(intPtr);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0009C528 File Offset: 0x0009A728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482350, RefRangeEnd = 482351, XrefRangeStart = 482332, XrefRangeEnd = 482350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(intPtr);
			}
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x0009C570 File Offset: 0x0009A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482351, XrefRangeEnd = 482357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RunWithTimeout_b__242_0<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric__RunWithTimeout_b__242_0_Private_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0009C5AC File Offset: 0x0009A7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482357, XrefRangeEnd = 482371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<BufferOffsetSize> _GetRewriteHandler_b__271_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__GetRewriteHandler_b__271_0_Private_Task_1_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<BufferOffsetSize>>(intPtr3) : null;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x0009C5EC File Offset: 0x0009A7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482371, XrefRangeEnd = 482374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0000E005 File Offset: 0x0000C205
		public HttpWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0009C628 File Offset: 0x0009A828
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0000E00E File Offset: 0x0000C20E
		public unsafe Uri requestUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0009C658 File Offset: 0x0009A858
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x0000E02D File Offset: 0x0000C22D
		public unsafe Uri actualUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0009C688 File Offset: 0x0009A888
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x0000E04C File Offset: 0x0000C24C
		public unsafe bool hostChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostChanged)) = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0009C6B0 File Offset: 0x0009A8B0
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x0000E067 File Offset: 0x0000C267
		public unsafe bool allowAutoRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect)) = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x0009C6D8 File Offset: 0x0009A8D8
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x0000E082 File Offset: 0x0000C282
		public unsafe bool allowBuffering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowBuffering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowBuffering)) = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x0009C700 File Offset: 0x0009A900
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x0000E09D File Offset: 0x0000C29D
		public unsafe X509CertificateCollection certificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x0009C730 File Offset: 0x0009A930
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x0000E0BC File Offset: 0x0000C2BC
		public unsafe string connectionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_connectionGroup);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_connectionGroup), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x0009C758 File Offset: 0x0009A958
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000E0DB File Offset: 0x0000C2DB
		public unsafe bool haveContentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveContentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveContentLength)) = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x0009C780 File Offset: 0x0009A980
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x0009C7A8 File Offset: 0x0009A9A8
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x0000E111 File Offset: 0x0000C311
		public unsafe HttpContinueDelegate continueDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContinueDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x0009C7D8 File Offset: 0x0009A9D8
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x0000E130 File Offset: 0x0000C330
		public unsafe CookieContainer cookieContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_cookieContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_cookieContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x0009C808 File Offset: 0x0009AA08
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x0000E14F File Offset: 0x0000C34F
		public unsafe ICredentials credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0009C838 File Offset: 0x0009AA38
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x0000E16E File Offset: 0x0000C36E
		public unsafe bool haveResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveResponse)) = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x0009C860 File Offset: 0x0009AA60
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0000E189 File Offset: 0x0000C389
		public unsafe bool requestSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestSent)) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x0009C888 File Offset: 0x0009AA88
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		public unsafe WebHeaderCollection webHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x0009C8B8 File Offset: 0x0009AAB8
		// (set) Token: 0x06002117 RID: 8471 RVA: 0x0000E1C3 File Offset: 0x0000C3C3
		public unsafe bool keepAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_keepAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_keepAlive)) = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x0009C8E0 File Offset: 0x0009AAE0
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x0000E1DE File Offset: 0x0000C3DE
		public unsafe int maxAutoRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect)) = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x0009C908 File Offset: 0x0009AB08
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x0000E1F9 File Offset: 0x0000C3F9
		public unsafe string mediaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_mediaType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_mediaType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0009C930 File Offset: 0x0009AB30
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x0000E218 File Offset: 0x0000C418
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x0009C958 File Offset: 0x0009AB58
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x0000E237 File Offset: 0x0000C437
		public unsafe string initialMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_initialMethod);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_initialMethod), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0009C980 File Offset: 0x0009AB80
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0000E256 File Offset: 0x0000C456
		public unsafe bool pipelined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_pipelined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_pipelined)) = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x0009C9A8 File Offset: 0x0009ABA8
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x0000E271 File Offset: 0x0000C471
		public unsafe bool preAuthenticate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_preAuthenticate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_preAuthenticate)) = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x0009C9D0 File Offset: 0x0009ABD0
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x0000E28C File Offset: 0x0000C48C
		public unsafe bool usedPreAuth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_usedPreAuth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_usedPreAuth)) = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x0009C9F8 File Offset: 0x0009ABF8
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x0000E2A7 File Offset: 0x0000C4A7
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x0009CA28 File Offset: 0x0009AC28
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x0000E2C6 File Offset: 0x0000C4C6
		public unsafe bool force_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_force_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_force_version)) = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x0009CA50 File Offset: 0x0009AC50
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x0000E2E1 File Offset: 0x0000C4E1
		public unsafe Version actualVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0009CA80 File Offset: 0x0009AC80
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x0000E300 File Offset: 0x0000C500
		public unsafe IWebProxy proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0009CAB0 File Offset: 0x0009ACB0
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x0000E31F File Offset: 0x0000C51F
		public unsafe bool sendChunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_sendChunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_sendChunked)) = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x0009CAD8 File Offset: 0x0009ACD8
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x0000E33A File Offset: 0x0000C53A
		public unsafe ServicePoint servicePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_servicePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_servicePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x0009CB08 File Offset: 0x0009AD08
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x0000E359 File Offset: 0x0000C559
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0009CB30 File Offset: 0x0009AD30
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x0000E374 File Offset: 0x0000C574
		public unsafe int continueTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueTimeout)) = value;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0009CB58 File Offset: 0x0009AD58
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0000E38F File Offset: 0x0000C58F
		public unsafe WebRequestStream writeStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_writeStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_writeStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0009CB88 File Offset: 0x0009AD88
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x0000E3AE File Offset: 0x0000C5AE
		public unsafe HttpWebResponse webResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x0009CBB8 File Offset: 0x0009ADB8
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x0000E3CD File Offset: 0x0000C5CD
		public unsafe WebCompletionSource responseTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_responseTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_responseTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x0009CBE8 File Offset: 0x0009ADE8
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		public unsafe WebOperation currentOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_currentOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_currentOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0009CC18 File Offset: 0x0009AE18
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x0000E40B File Offset: 0x0000C60B
		public unsafe int aborted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_aborted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_aborted)) = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0009CC40 File Offset: 0x0009AE40
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0000E426 File Offset: 0x0000C626
		public unsafe bool gotRequestStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_gotRequestStream);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_gotRequestStream)) = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x0009CC68 File Offset: 0x0009AE68
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x0000E441 File Offset: 0x0000C641
		public unsafe int redirects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_redirects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_redirects)) = value;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x0009CC90 File Offset: 0x0009AE90
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x0000E45C File Offset: 0x0000C65C
		public unsafe bool expectContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_expectContinue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_expectContinue)) = value;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x0009CCB8 File Offset: 0x0009AEB8
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x0000E477 File Offset: 0x0000C677
		public unsafe bool getResponseCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_getResponseCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_getResponseCalled)) = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x0009CCE0 File Offset: 0x0009AEE0
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x0000E492 File Offset: 0x0000C692
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x0009CD10 File Offset: 0x0009AF10
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x0000E4B1 File Offset: 0x0000C6B1
		public unsafe bool finished_reading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_finished_reading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_finished_reading)) = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x0009CD38 File Offset: 0x0009AF38
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		public unsafe DecompressionMethods auto_decomp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auto_decomp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auto_decomp)) = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x0009CD60 File Offset: 0x0009AF60
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x0000E4E7 File Offset: 0x0000C6E7
		public unsafe static int defaultMaxResponseHeadersLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength, (void*)(&value));
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x0009CD7C File Offset: 0x0009AF7C
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x0000E4F5 File Offset: 0x0000C6F5
		public unsafe static int defaultMaximumErrorResponseLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaximumErrorResponseLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaximumErrorResponseLength, (void*)(&value));
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x0009CD98 File Offset: 0x0009AF98
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x0000E503 File Offset: 0x0000C703
		public unsafe static RequestCachePolicy defaultCachePolicy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.NativeFieldInfoPtr_defaultCachePolicy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.NativeFieldInfoPtr_defaultCachePolicy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x0009CDC0 File Offset: 0x0009AFC0
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x0000E515 File Offset: 0x0000C715
		public unsafe int readWriteTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout)) = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x0009CDE8 File Offset: 0x0009AFE8
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x0000E530 File Offset: 0x0000C730
		public unsafe MobileTlsProvider tlsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x0009CE18 File Offset: 0x0009B018
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x0000E54F File Offset: 0x0000C74F
		public unsafe MonoTlsSettings tlsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x0009CE48 File Offset: 0x0009B048
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x0000E56E File Offset: 0x0000C76E
		public unsafe ServerCertValidationCallback certValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0009CE78 File Offset: 0x0009B078
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x0000E58D File Offset: 0x0000C78D
		public unsafe bool hostHasPort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostHasPort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostHasPort)) = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0009CEA0 File Offset: 0x0009B0A0
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		public unsafe Uri hostUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0009CED0 File Offset: 0x0009B0D0
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x0000E5C7 File Offset: 0x0000C7C7
		public HttpWebRequest.AuthorizationState auth_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auth_state);
				return new HttpWebRequest.AuthorizationState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auth_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x0009CF00 File Offset: 0x0009B100
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x0000E5F5 File Offset: 0x0000C7F5
		public HttpWebRequest.AuthorizationState proxy_auth_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state);
				return new HttpWebRequest.AuthorizationState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x0009CF30 File Offset: 0x0009B130
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x0000E623 File Offset: 0x0000C823
		public unsafe Func<Stream, Task> ResendContentFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x0009CF60 File Offset: 0x0009B160
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x0000E642 File Offset: 0x0000C842
		public unsafe bool _ThrowOnError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0009CF88 File Offset: 0x0009B188
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x0000E65D File Offset: 0x0000C85D
		public unsafe bool unsafe_auth_blah
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah)) = value;
			}
		}

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeFieldInfoPtr_requestUri;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeFieldInfoPtr_actualUri;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeFieldInfoPtr_hostChanged;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeFieldInfoPtr_allowAutoRedirect;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeFieldInfoPtr_allowBuffering;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr_certificates;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeFieldInfoPtr_connectionGroup;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeFieldInfoPtr_haveContentLength;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeFieldInfoPtr_continueDelegate;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeFieldInfoPtr_cookieContainer;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeFieldInfoPtr_credentials;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeFieldInfoPtr_haveResponse;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeFieldInfoPtr_requestSent;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeFieldInfoPtr_webHeaders;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeFieldInfoPtr_keepAlive;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeFieldInfoPtr_maxAutoRedirect;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeFieldInfoPtr_mediaType;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeFieldInfoPtr_initialMethod;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeFieldInfoPtr_pipelined;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeFieldInfoPtr_preAuthenticate;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeFieldInfoPtr_usedPreAuth;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeFieldInfoPtr_force_version;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeFieldInfoPtr_actualVersion;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeFieldInfoPtr_proxy;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeFieldInfoPtr_sendChunked;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeFieldInfoPtr_servicePoint;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeFieldInfoPtr_continueTimeout;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeFieldInfoPtr_writeStream;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeFieldInfoPtr_webResponse;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeFieldInfoPtr_responseTask;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeFieldInfoPtr_currentOperation;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeFieldInfoPtr_aborted;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeFieldInfoPtr_gotRequestStream;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeFieldInfoPtr_redirects;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeFieldInfoPtr_expectContinue;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr_getResponseCalled;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeFieldInfoPtr_finished_reading;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_auto_decomp;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_defaultMaxResponseHeadersLength;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_defaultMaximumErrorResponseLength;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr_defaultCachePolicy;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_readWriteTimeout;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeFieldInfoPtr_tlsProvider;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeFieldInfoPtr_tlsSettings;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr_certValidationCallback;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_hostHasPort;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr_hostUri;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeFieldInfoPtr_auth_state;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeFieldInfoPtr_proxy_auth_state;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeFieldInfoPtr_ResendContentFactory;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeFieldInfoPtr__ThrowOnError_k__BackingField;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeFieldInfoPtr_unsafe_auth_blah;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_MobileTlsProvider_MonoTlsSettings_0;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_ResetAuthorization_Private_Void_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Uri_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowWriteStreamBuffering_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_set_AutomaticDecompression_Public_set_Void_DecompressionMethods_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_get_TlsProvider_Internal_get_MobileTlsProvider_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr_set_CookieContainer_Public_Virtual_New_set_Void_CookieContainer_0;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultMaximumErrorResponseLength_Public_Static_get_Int32_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeMethodInfoPtr_set_Host_Public_set_Void_String_0;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeMethodInfoPtr_TryGetHostUri_Private_Boolean_String_byref_Uri_0;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_set_KeepAlive_Public_set_Void_Boolean_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_set_MaximumAutomaticRedirections_Public_set_Void_Int32_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultMaximumResponseHeadersLength_Public_Static_get_Int32_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_Version_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_set_SendChunked_Public_set_Void_Boolean_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_get_RemoteCertificateValidationCallback_0;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerCertificateValidationCallback_Public_set_Void_RemoteCertificateValidationCallback_0;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_MyGetRequestStreamAsync_Private_Task_1_Stream_CancellationToken_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStreamAsync_Public_Virtual_Task_1_Stream_0;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_Func_1_Boolean_CancellationToken_0;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeMethodInfoPtr_RunWithTimeoutWorker_Private_Static_Task_1_T_Task_1_T_Int32_Action_Func_1_Boolean_CancellationTokenSource_0;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_GetWebException_Private_Static_WebException_Exception_Boolean_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_GetHeaders_Private_String_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr__RunWithTimeout_b__242_0_Private_Boolean_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr__GetRewriteHandler_b__271_0_Private_Task_1_BufferOffsetSize_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000339 RID: 825
		public enum NtlmAuthState
		{
			// Token: 0x04002545 RID: 9541
			None,
			// Token: 0x04002546 RID: 9542
			Challenge,
			// Token: 0x04002547 RID: 9543
			Response
		}

		// Token: 0x0200033A RID: 826
		public sealed class AuthorizationState : ValueType
		{
			// Token: 0x06002FA2 RID: 12194 RVA: 0x000CF098 File Offset: 0x000CD298
			// Note: this type is marked as 'beforefieldinit'.
			static AuthorizationState()
			{
				Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "AuthorizationState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr);
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "request");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "isProxy");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "isCompleted");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "ntlm_auth_state");
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100668271);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100668272);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100668273);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100668274);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100668275);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100668276);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100668277);
			}

			// Token: 0x17000EE8 RID: 3816
			// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000CF1A0 File Offset: 0x000CD3A0
			public unsafe bool IsCompleted
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EE9 RID: 3817
			// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x000CF1E4 File Offset: 0x000CD3E4
			public unsafe HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EEA RID: 3818
			// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x000CF228 File Offset: 0x000CD428
			public unsafe bool IsNtlmAuthenticated
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 481269, RefRangeEnd = 481270, XrefRangeStart = 481269, XrefRangeEnd = 481269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002FA6 RID: 12198 RVA: 0x000CF26C File Offset: 0x000CD46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481270, XrefRangeEnd = 481271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AuthorizationState(HttpWebRequest request, bool isProxy)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isProxy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA7 RID: 12199 RVA: 0x000CF2CC File Offset: 0x000CD4CC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 481298, RefRangeEnd = 481301, XrefRangeStart = 481271, XrefRangeEnd = 481298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002FA8 RID: 12200 RVA: 0x000CF32C File Offset: 0x000CD52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481301, XrefRangeEnd = 481307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x000CF364 File Offset: 0x000CD564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481307, XrefRangeEnd = 481320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06002FAA RID: 12202 RVA: 0x00015730 File Offset: 0x00013930
			public AuthorizationState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FAB RID: 12203 RVA: 0x00015739 File Offset: 0x00013939
			public AuthorizationState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr))
			{
			}

			// Token: 0x17000EE4 RID: 3812
			// (get) Token: 0x06002FAC RID: 12204 RVA: 0x000CF3A0 File Offset: 0x000CD5A0
			// (set) Token: 0x06002FAD RID: 12205 RVA: 0x0001574B File Offset: 0x0001394B
			public unsafe HttpWebRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EE5 RID: 3813
			// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000CF3D0 File Offset: 0x000CD5D0
			// (set) Token: 0x06002FAF RID: 12207 RVA: 0x0001576A File Offset: 0x0001396A
			public unsafe bool isProxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy)) = value;
				}
			}

			// Token: 0x17000EE6 RID: 3814
			// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x000CF3F8 File Offset: 0x000CD5F8
			// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x00015785 File Offset: 0x00013985
			public unsafe bool isCompleted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted)) = value;
				}
			}

			// Token: 0x17000EE7 RID: 3815
			// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000CF420 File Offset: 0x000CD620
			// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x000157A0 File Offset: 0x000139A0
			public unsafe HttpWebRequest.NtlmAuthState ntlm_auth_state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state)) = value;
				}
			}

			// Token: 0x04002548 RID: 9544
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04002549 RID: 9545
			private static readonly IntPtr NativeFieldInfoPtr_isProxy;

			// Token: 0x0400254A RID: 9546
			private static readonly IntPtr NativeFieldInfoPtr_isCompleted;

			// Token: 0x0400254B RID: 9547
			private static readonly IntPtr NativeFieldInfoPtr_ntlm_auth_state;

			// Token: 0x0400254C RID: 9548
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x0400254D RID: 9549
			private static readonly IntPtr NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0;

			// Token: 0x0400254E RID: 9550
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0;

			// Token: 0x0400254F RID: 9551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0;

			// Token: 0x04002550 RID: 9552
			private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0;

			// Token: 0x04002551 RID: 9553
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x04002552 RID: 9554
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x0200033B RID: 827
		[ObfuscatedName("System.Net.HttpWebRequest+<>c__241`1")]
		[Serializable]
		public sealed class __c__241<T> : Object
		{
			// Token: 0x06002FB4 RID: 12212 RVA: 0x000CF448 File Offset: 0x000CD648
			// Note: this type is marked as 'beforefieldinit'.
			static __c__241()
			{
				Il2CppClassPointerStore<HttpWebRequest.__c__241<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<>c__241`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.__c__241<T>>.NativeClassPtr);
				HttpWebRequest.__c__241<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__c__241<T>>.NativeClassPtr, "<>9");
				HttpWebRequest.__c__241<T>.NativeFieldInfoPtr___9__241_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__c__241<T>>.NativeClassPtr, "<>9__241_0");
				HttpWebRequest.__c__241<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__c__241<T>>.NativeClassPtr, 100668279);
				HttpWebRequest.__c__241<T>.NativeMethodInfoPtr__RunWithTimeoutWorker_b__241_0_Internal_Nullable_1_Int32_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__c__241<T>>.NativeClassPtr, 100668280);
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x000CF500 File Offset: 0x000CD700
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__241()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.__c__241<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__c__241<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FB6 RID: 12214 RVA: 0x000CF53C File Offset: 0x000CD73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481320, XrefRangeEnd = 481324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _RunWithTimeoutWorker_b__241_0(Task<T> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__c__241<T>.NativeMethodInfoPtr__RunWithTimeoutWorker_b__241_0_Internal_Nullable_1_Int32_Task_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06002FB7 RID: 12215 RVA: 0x000157BB File Offset: 0x000139BB
			public __c__241(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EEB RID: 3819
			// (get) Token: 0x06002FB8 RID: 12216 RVA: 0x000CF584 File Offset: 0x000CD784
			// (set) Token: 0x06002FB9 RID: 12217 RVA: 0x000157C4 File Offset: 0x000139C4
			public unsafe static HttpWebRequest.__c__241<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.__c__241<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest.__c__241<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.__c__241<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EEC RID: 3820
			// (get) Token: 0x06002FBA RID: 12218 RVA: 0x000CF5AC File Offset: 0x000CD7AC
			// (set) Token: 0x06002FBB RID: 12219 RVA: 0x000157D6 File Offset: 0x000139D6
			public unsafe static Func<Task<T>, Nullable<int>> __9__241_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.__c__241<T>.NativeFieldInfoPtr___9__241_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<T>, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.__c__241<T>.NativeFieldInfoPtr___9__241_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002553 RID: 9555
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002554 RID: 9556
			private static readonly IntPtr NativeFieldInfoPtr___9__241_0;

			// Token: 0x04002555 RID: 9557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002556 RID: 9558
			private static readonly IntPtr NativeMethodInfoPtr__RunWithTimeoutWorker_b__241_0_Internal_Nullable_1_Int32_Task_1_T_0;
		}

		// Token: 0x0200033C RID: 828
		[ObfuscatedName("System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1")]
		public sealed class _RunWithTimeoutWorker_d__241<T> : ValueType
		{
			// Token: 0x06002FBC RID: 12220 RVA: 0x000CF5D4 File Offset: 0x000CD7D4
			// Note: this type is marked as 'beforefieldinit'.
			static _RunWithTimeoutWorker_d__241()
			{
				Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<RunWithTimeoutWorker>d__241`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr);
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "<>1__state");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_workerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "workerTask");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "timeout");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_cts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "cts");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_abort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "abort");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "aborted");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, "<>u__1");
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, 100668281);
				HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr, 100668282);
			}

			// Token: 0x06002FBD RID: 12221 RVA: 0x000CF704 File Offset: 0x000CD904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481324, XrefRangeEnd = 481344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FBE RID: 12222 RVA: 0x000CF73C File Offset: 0x000CD93C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481344, XrefRangeEnd = 481349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FBF RID: 12223 RVA: 0x000157E8 File Offset: 0x000139E8
			public _RunWithTimeoutWorker_d__241(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FC0 RID: 12224 RVA: 0x000157F1 File Offset: 0x000139F1
			public _RunWithTimeoutWorker_d__241()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeoutWorker_d__241<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000EED RID: 3821
			// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000CF784 File Offset: 0x000CD984
			// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x00015803 File Offset: 0x00013A03
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EEE RID: 3822
			// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x000CF7AC File Offset: 0x000CD9AC
			// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x0001581E File Offset: 0x00013A1E
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EEF RID: 3823
			// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000CF7DC File Offset: 0x000CD9DC
			// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x0001584C File Offset: 0x00013A4C
			public unsafe Task<T> workerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_workerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_workerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF0 RID: 3824
			// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x000CF80C File Offset: 0x000CDA0C
			// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x0001586B File Offset: 0x00013A6B
			public unsafe int timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_timeout)) = value;
				}
			}

			// Token: 0x17000EF1 RID: 3825
			// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x000CF834 File Offset: 0x000CDA34
			// (set) Token: 0x06002FCA RID: 12234 RVA: 0x00015886 File Offset: 0x00013A86
			public unsafe CancellationTokenSource cts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_cts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_cts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF2 RID: 3826
			// (get) Token: 0x06002FCB RID: 12235 RVA: 0x000CF864 File Offset: 0x000CDA64
			// (set) Token: 0x06002FCC RID: 12236 RVA: 0x000158A5 File Offset: 0x00013AA5
			public unsafe Action abort
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_abort);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_abort), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF3 RID: 3827
			// (get) Token: 0x06002FCD RID: 12237 RVA: 0x000CF894 File Offset: 0x000CDA94
			// (set) Token: 0x06002FCE RID: 12238 RVA: 0x000158C4 File Offset: 0x00013AC4
			public unsafe Func<bool> aborted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_aborted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr_aborted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF4 RID: 3828
			// (get) Token: 0x06002FCF RID: 12239 RVA: 0x000CF8C4 File Offset: 0x000CDAC4
			// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x000158E3 File Offset: 0x00013AE3
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeoutWorker_d__241<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002557 RID: 9559
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002558 RID: 9560
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002559 RID: 9561
			private static readonly IntPtr NativeFieldInfoPtr_workerTask;

			// Token: 0x0400255A RID: 9562
			private static readonly IntPtr NativeFieldInfoPtr_timeout;

			// Token: 0x0400255B RID: 9563
			private static readonly IntPtr NativeFieldInfoPtr_cts;

			// Token: 0x0400255C RID: 9564
			private static readonly IntPtr NativeFieldInfoPtr_abort;

			// Token: 0x0400255D RID: 9565
			private static readonly IntPtr NativeFieldInfoPtr_aborted;

			// Token: 0x0400255E RID: 9566
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400255F RID: 9567
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002560 RID: 9568
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200033D RID: 829
		[ObfuscatedName("System.Net.HttpWebRequest+<MyGetResponseAsync>d__243")]
		public sealed class _MyGetResponseAsync_d__243 : ValueType
		{
			// Token: 0x06002FD1 RID: 12241 RVA: 0x000CF8F4 File Offset: 0x000CDAF4
			// Note: this type is marked as 'beforefieldinit'.
			static _MyGetResponseAsync_d__243()
			{
				Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<MyGetResponseAsync>d__243");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr);
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<>1__state");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<>4__this");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "cancellationToken");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__completion_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<completion>5__2");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__operation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<operation>5__3");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__throwMe_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<throwMe>5__4");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__response_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<response>5__5");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__stream_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<stream>5__6");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__redirect_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<redirect>5__7");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__mustReadAll_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<mustReadAll>5__8");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__ntlm_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<ntlm>5__9");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__writeBuffer_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<writeBuffer>5__10");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<>u__1");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<>u__2");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<>u__3");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, "<>u__4");
				HttpWebRequest._MyGetResponseAsync_d__243.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, 100668283);
				HttpWebRequest._MyGetResponseAsync_d__243.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr, 100668284);
			}

			// Token: 0x06002FD2 RID: 12242 RVA: 0x000CFA9C File Offset: 0x000CDC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481349, XrefRangeEnd = 481488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._MyGetResponseAsync_d__243.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FD3 RID: 12243 RVA: 0x000CFAD4 File Offset: 0x000CDCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481488, XrefRangeEnd = 481494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._MyGetResponseAsync_d__243.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FD4 RID: 12244 RVA: 0x00015911 File Offset: 0x00013B11
			public _MyGetResponseAsync_d__243(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FD5 RID: 12245 RVA: 0x0001591A File Offset: 0x00013B1A
			public _MyGetResponseAsync_d__243()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__243>.NativeClassPtr))
			{
			}

			// Token: 0x17000EF5 RID: 3829
			// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x000CFB1C File Offset: 0x000CDD1C
			// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x0001592C File Offset: 0x00013B2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EF6 RID: 3830
			// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x000CFB44 File Offset: 0x000CDD44
			// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x00015947 File Offset: 0x00013B47
			public AsyncTaskMethodBuilder<HttpWebResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpWebResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpWebResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpWebResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EF7 RID: 3831
			// (get) Token: 0x06002FDA RID: 12250 RVA: 0x000CFB74 File Offset: 0x000CDD74
			// (set) Token: 0x06002FDB RID: 12251 RVA: 0x00015975 File Offset: 0x00013B75
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x06002FDC RID: 12252 RVA: 0x000CFBA4 File Offset: 0x000CDDA4
			// (set) Token: 0x06002FDD RID: 12253 RVA: 0x00015994 File Offset: 0x00013B94
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x06002FDE RID: 12254 RVA: 0x000CFBD4 File Offset: 0x000CDDD4
			// (set) Token: 0x06002FDF RID: 12255 RVA: 0x000159C2 File Offset: 0x00013BC2
			public unsafe WebCompletionSource _completion_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__completion_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__completion_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFA RID: 3834
			// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x000CFC04 File Offset: 0x000CDE04
			// (set) Token: 0x06002FE1 RID: 12257 RVA: 0x000159E1 File Offset: 0x00013BE1
			public unsafe WebOperation _operation_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__operation_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__operation_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFB RID: 3835
			// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x000CFC34 File Offset: 0x000CDE34
			// (set) Token: 0x06002FE3 RID: 12259 RVA: 0x00015A00 File Offset: 0x00013C00
			public unsafe WebException _throwMe_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__throwMe_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__throwMe_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFC RID: 3836
			// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x000CFC64 File Offset: 0x000CDE64
			// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x00015A1F File Offset: 0x00013C1F
			public unsafe HttpWebResponse _response_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__response_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__response_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFD RID: 3837
			// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x000CFC94 File Offset: 0x000CDE94
			// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00015A3E File Offset: 0x00013C3E
			public unsafe WebResponseStream _stream_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__stream_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__stream_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFE RID: 3838
			// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x000CFCC4 File Offset: 0x000CDEC4
			// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00015A5D File Offset: 0x00013C5D
			public unsafe bool _redirect_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__redirect_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__redirect_5__7)) = value;
				}
			}

			// Token: 0x17000EFF RID: 3839
			// (get) Token: 0x06002FEA RID: 12266 RVA: 0x000CFCEC File Offset: 0x000CDEEC
			// (set) Token: 0x06002FEB RID: 12267 RVA: 0x00015A78 File Offset: 0x00013C78
			public unsafe bool _mustReadAll_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__mustReadAll_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__mustReadAll_5__8)) = value;
				}
			}

			// Token: 0x17000F00 RID: 3840
			// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000CFD14 File Offset: 0x000CDF14
			// (set) Token: 0x06002FED RID: 12269 RVA: 0x00015A93 File Offset: 0x00013C93
			public unsafe WebOperation _ntlm_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__ntlm_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__ntlm_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F01 RID: 3841
			// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000CFD44 File Offset: 0x000CDF44
			// (set) Token: 0x06002FEF RID: 12271 RVA: 0x00015AB2 File Offset: 0x00013CB2
			public unsafe BufferOffsetSize _writeBuffer_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__writeBuffer_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr__writeBuffer_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F02 RID: 3842
			// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000CFD74 File Offset: 0x000CDF74
			// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x00015AD1 File Offset: 0x00013CD1
			public ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F03 RID: 3843
			// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x000CFDA4 File Offset: 0x000CDFA4
			// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x00015AFF File Offset: 0x00013CFF
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F04 RID: 3844
			// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x000CFDD4 File Offset: 0x000CDFD4
			// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x00015B2D File Offset: 0x00013D2D
			public TaskAwaiter<WebResponseStream> __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__3);
					return new TaskAwaiter<WebResponseStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebResponseStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebResponseStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F05 RID: 3845
			// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000CFE04 File Offset: 0x000CE004
			// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x00015B5B File Offset: 0x00013D5B
			public ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__243.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002561 RID: 9569
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002562 RID: 9570
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002563 RID: 9571
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002564 RID: 9572
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002565 RID: 9573
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__2;

			// Token: 0x04002566 RID: 9574
			private static readonly IntPtr NativeFieldInfoPtr__operation_5__3;

			// Token: 0x04002567 RID: 9575
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__4;

			// Token: 0x04002568 RID: 9576
			private static readonly IntPtr NativeFieldInfoPtr__response_5__5;

			// Token: 0x04002569 RID: 9577
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__6;

			// Token: 0x0400256A RID: 9578
			private static readonly IntPtr NativeFieldInfoPtr__redirect_5__7;

			// Token: 0x0400256B RID: 9579
			private static readonly IntPtr NativeFieldInfoPtr__mustReadAll_5__8;

			// Token: 0x0400256C RID: 9580
			private static readonly IntPtr NativeFieldInfoPtr__ntlm_5__9;

			// Token: 0x0400256D RID: 9581
			private static readonly IntPtr NativeFieldInfoPtr__writeBuffer_5__10;

			// Token: 0x0400256E RID: 9582
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400256F RID: 9583
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002570 RID: 9584
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04002571 RID: 9585
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x04002572 RID: 9586
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002573 RID: 9587
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200033E RID: 830
		[ObfuscatedName("System.Net.HttpWebRequest+<GetResponseFromData>d__244")]
		public sealed class _GetResponseFromData_d__244 : ValueType
		{
			// Token: 0x06002FF8 RID: 12280 RVA: 0x000CFE34 File Offset: 0x000CE034
			// Note: this type is marked as 'beforefieldinit'.
			static _GetResponseFromData_d__244()
			{
				Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<GetResponseFromData>d__244");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr);
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<>1__state");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<>4__this");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "stream");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "cancellationToken");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__response_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<response>5__2");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__throwMe_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<throwMe>5__3");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__redirect_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<redirect>5__4");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__mustReadAll_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<mustReadAll>5__5");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<>u__1");
				HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, "<>u__2");
				HttpWebRequest._GetResponseFromData_d__244.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, 100668285);
				HttpWebRequest._GetResponseFromData_d__244.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr, 100668286);
			}

			// Token: 0x06002FF9 RID: 12281 RVA: 0x000CFF64 File Offset: 0x000CE164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481494, XrefRangeEnd = 481559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._GetResponseFromData_d__244.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FFA RID: 12282 RVA: 0x000CFF9C File Offset: 0x000CE19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481559, XrefRangeEnd = 481565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._GetResponseFromData_d__244.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FFB RID: 12283 RVA: 0x00015B89 File Offset: 0x00013D89
			public _GetResponseFromData_d__244(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FFC RID: 12284 RVA: 0x00015B92 File Offset: 0x00013D92
			public _GetResponseFromData_d__244()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__244>.NativeClassPtr))
			{
			}

			// Token: 0x17000F06 RID: 3846
			// (get) Token: 0x06002FFD RID: 12285 RVA: 0x000CFFE4 File Offset: 0x000CE1E4
			// (set) Token: 0x06002FFE RID: 12286 RVA: 0x00015BA4 File Offset: 0x00013DA4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F07 RID: 3847
			// (get) Token: 0x06002FFF RID: 12287 RVA: 0x000D000C File Offset: 0x000CE20C
			// (set) Token: 0x06003000 RID: 12288 RVA: 0x00015BBF File Offset: 0x00013DBF
			public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F08 RID: 3848
			// (get) Token: 0x06003001 RID: 12289 RVA: 0x000D003C File Offset: 0x000CE23C
			// (set) Token: 0x06003002 RID: 12290 RVA: 0x00015BED File Offset: 0x00013DED
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F09 RID: 3849
			// (get) Token: 0x06003003 RID: 12291 RVA: 0x000D006C File Offset: 0x000CE26C
			// (set) Token: 0x06003004 RID: 12292 RVA: 0x00015C0C File Offset: 0x00013E0C
			public unsafe WebResponseStream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F0A RID: 3850
			// (get) Token: 0x06003005 RID: 12293 RVA: 0x000D009C File Offset: 0x000CE29C
			// (set) Token: 0x06003006 RID: 12294 RVA: 0x00015C2B File Offset: 0x00013E2B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F0B RID: 3851
			// (get) Token: 0x06003007 RID: 12295 RVA: 0x000D00CC File Offset: 0x000CE2CC
			// (set) Token: 0x06003008 RID: 12296 RVA: 0x00015C59 File Offset: 0x00013E59
			public unsafe HttpWebResponse _response_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__response_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__response_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F0C RID: 3852
			// (get) Token: 0x06003009 RID: 12297 RVA: 0x000D00FC File Offset: 0x000CE2FC
			// (set) Token: 0x0600300A RID: 12298 RVA: 0x00015C78 File Offset: 0x00013E78
			public unsafe WebException _throwMe_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__throwMe_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__throwMe_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F0D RID: 3853
			// (get) Token: 0x0600300B RID: 12299 RVA: 0x000D012C File Offset: 0x000CE32C
			// (set) Token: 0x0600300C RID: 12300 RVA: 0x00015C97 File Offset: 0x00013E97
			public unsafe bool _redirect_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__redirect_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__redirect_5__4)) = value;
				}
			}

			// Token: 0x17000F0E RID: 3854
			// (get) Token: 0x0600300D RID: 12301 RVA: 0x000D0154 File Offset: 0x000CE354
			// (set) Token: 0x0600300E RID: 12302 RVA: 0x00015CB2 File Offset: 0x00013EB2
			public unsafe bool _mustReadAll_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__mustReadAll_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr__mustReadAll_5__5)) = value;
				}
			}

			// Token: 0x17000F0F RID: 3855
			// (get) Token: 0x0600300F RID: 12303 RVA: 0x000D017C File Offset: 0x000CE37C
			// (set) Token: 0x06003010 RID: 12304 RVA: 0x00015CCD File Offset: 0x00013ECD
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F10 RID: 3856
			// (get) Token: 0x06003011 RID: 12305 RVA: 0x000D01AC File Offset: 0x000CE3AC
			// (set) Token: 0x06003012 RID: 12306 RVA: 0x00015CFB File Offset: 0x00013EFB
			public ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__244.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002574 RID: 9588
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002575 RID: 9589
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002576 RID: 9590
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002577 RID: 9591
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04002578 RID: 9592
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002579 RID: 9593
			private static readonly IntPtr NativeFieldInfoPtr__response_5__2;

			// Token: 0x0400257A RID: 9594
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__3;

			// Token: 0x0400257B RID: 9595
			private static readonly IntPtr NativeFieldInfoPtr__redirect_5__4;

			// Token: 0x0400257C RID: 9596
			private static readonly IntPtr NativeFieldInfoPtr__mustReadAll_5__5;

			// Token: 0x0400257D RID: 9597
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400257E RID: 9598
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400257F RID: 9599
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002580 RID: 9600
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200033F RID: 831
		[ObfuscatedName("System.Net.HttpWebRequest+<<GetRewriteHandler>b__271_0>d")]
		public sealed class __GetRewriteHandler_b__271_0_d : ValueType
		{
			// Token: 0x06003013 RID: 12307 RVA: 0x000D01DC File Offset: 0x000CE3DC
			// Note: this type is marked as 'beforefieldinit'.
			static __GetRewriteHandler_b__271_0_d()
			{
				Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<<GetRewriteHandler>b__271_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr);
				HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr, "<>1__state");
				HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr, "<>t__builder");
				HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr, "<>4__this");
				HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr__ms_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr, "<ms>5__2");
				HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr, "<>u__1");
				HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr, 100668287);
				HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr, 100668288);
			}

			// Token: 0x06003014 RID: 12308 RVA: 0x000D0294 File Offset: 0x000CE494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481565, XrefRangeEnd = 481588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003015 RID: 12309 RVA: 0x000D02CC File Offset: 0x000CE4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481588, XrefRangeEnd = 481594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003016 RID: 12310 RVA: 0x00015D29 File Offset: 0x00013F29
			public __GetRewriteHandler_b__271_0_d(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003017 RID: 12311 RVA: 0x00015D32 File Offset: 0x00013F32
			public __GetRewriteHandler_b__271_0_d()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__271_0_d>.NativeClassPtr))
			{
			}

			// Token: 0x17000F11 RID: 3857
			// (get) Token: 0x06003018 RID: 12312 RVA: 0x000D0314 File Offset: 0x000CE514
			// (set) Token: 0x06003019 RID: 12313 RVA: 0x00015D44 File Offset: 0x00013F44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F12 RID: 3858
			// (get) Token: 0x0600301A RID: 12314 RVA: 0x000D033C File Offset: 0x000CE53C
			// (set) Token: 0x0600301B RID: 12315 RVA: 0x00015D5F File Offset: 0x00013F5F
			public AsyncTaskMethodBuilder<BufferOffsetSize> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<BufferOffsetSize>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<BufferOffsetSize>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<BufferOffsetSize>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F13 RID: 3859
			// (get) Token: 0x0600301C RID: 12316 RVA: 0x000D036C File Offset: 0x000CE56C
			// (set) Token: 0x0600301D RID: 12317 RVA: 0x00015D8D File Offset: 0x00013F8D
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F14 RID: 3860
			// (get) Token: 0x0600301E RID: 12318 RVA: 0x000D039C File Offset: 0x000CE59C
			// (set) Token: 0x0600301F RID: 12319 RVA: 0x00015DAC File Offset: 0x00013FAC
			public unsafe MemoryStream _ms_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr__ms_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr__ms_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F15 RID: 3861
			// (get) Token: 0x06003020 RID: 12320 RVA: 0x000D03CC File Offset: 0x000CE5CC
			// (set) Token: 0x06003021 RID: 12321 RVA: 0x00015DCB File Offset: 0x00013FCB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__271_0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002581 RID: 9601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002582 RID: 9602
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002583 RID: 9603
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002584 RID: 9604
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__2;

			// Token: 0x04002585 RID: 9605
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002586 RID: 9606
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002587 RID: 9607
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000340 RID: 832
		private sealed class MethodInfoStoreGeneric_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_Func_1_Boolean_CancellationToken_0<T>
		{
			// Token: 0x04002588 RID: 9608
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_Func_1_Boolean_CancellationToken_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000341 RID: 833
		private sealed class MethodInfoStoreGeneric_RunWithTimeoutWorker_Private_Static_Task_1_T_Task_1_T_Int32_Action_Func_1_Boolean_CancellationTokenSource_0<T>
		{
			// Token: 0x04002589 RID: 9609
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr_RunWithTimeoutWorker_Private_Static_Task_1_T_Task_1_T_Int32_Action_Func_1_Boolean_CancellationTokenSource_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000342 RID: 834
		private sealed class MethodInfoStoreGeneric_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0<T>
		{
			// Token: 0x0400258A RID: 9610
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000343 RID: 835
		private sealed class MethodInfoStoreGeneric__RunWithTimeout_b__242_0_Private_Boolean_0<T>
		{
			// Token: 0x0400258B RID: 9611
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr__RunWithTimeout_b__242_0_Private_Boolean_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
