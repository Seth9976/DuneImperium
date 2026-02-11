using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace UnityEngine.Networking
{
	// Token: 0x0200000A RID: 10
	public class UnityWebRequest : Object
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00004A10 File Offset: 0x00002C10
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequest()
		{
			Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UnityWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr);
			UnityWebRequest.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Ptr");
			UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_DownloadHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_UploadHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_CertificateHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_Uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Uri");
			UnityWebRequest.NativeFieldInfoPtr_kHttpVerbGET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "kHttpVerbGET");
			UnityWebRequest.NativeFieldInfoPtr_kHttpVerbHEAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "kHttpVerbHEAD");
			UnityWebRequest.NativeFieldInfoPtr_kHttpVerbPOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "kHttpVerbPOST");
			UnityWebRequest.NativeFieldInfoPtr_kHttpVerbPUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "kHttpVerbPUT");
			UnityWebRequest.NativeFieldInfoPtr_kHttpVerbCREATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "kHttpVerbCREATE");
			UnityWebRequest.NativeFieldInfoPtr_kHttpVerbDELETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "kHttpVerbDELETE");
			UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeCertificateHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeDownloadHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeUploadHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663367);
			UnityWebRequest.NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663368);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663369);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663370);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663371);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663372);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663373);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663374);
			UnityWebRequest.NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663375);
			UnityWebRequest.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663376);
			UnityWebRequest.NativeMethodInfoPtr_InternalDestroy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663377);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663378);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663379);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663380);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663381);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663382);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_DownloadHandler_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663383);
			UnityWebRequest.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663384);
			UnityWebRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663385);
			UnityWebRequest.NativeMethodInfoPtr_DisposeHandlers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663386);
			UnityWebRequest.NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663387);
			UnityWebRequest.NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663388);
			UnityWebRequest.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663389);
			UnityWebRequest.NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663390);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663391);
			UnityWebRequest.NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663392);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663393);
			UnityWebRequest.NativeMethodInfoPtr_GetMethod_Internal_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663394);
			UnityWebRequest.NativeMethodInfoPtr_GetCustomMethod_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663395);
			UnityWebRequest.NativeMethodInfoPtr_get_method_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663396);
			UnityWebRequest.NativeMethodInfoPtr_set_method_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663397);
			UnityWebRequest.NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663398);
			UnityWebRequest.NativeMethodInfoPtr_get_error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663399);
			UnityWebRequest.NativeMethodInfoPtr_get_url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663400);
			UnityWebRequest.NativeMethodInfoPtr_set_url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663401);
			UnityWebRequest.NativeMethodInfoPtr_set_uri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663402);
			UnityWebRequest.NativeMethodInfoPtr_GetUrl_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663403);
			UnityWebRequest.NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663404);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663405);
			UnityWebRequest.NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663406);
			UnityWebRequest.NativeMethodInfoPtr_GetUploadProgress_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663407);
			UnityWebRequest.NativeMethodInfoPtr_IsExecuting_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663408);
			UnityWebRequest.NativeMethodInfoPtr_get_uploadProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663409);
			UnityWebRequest.NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663410);
			UnityWebRequest.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663411);
			UnityWebRequest.NativeMethodInfoPtr_get_result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663412);
			UnityWebRequest.NativeMethodInfoPtr_GetDownloadProgress_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663413);
			UnityWebRequest.NativeMethodInfoPtr_get_downloadProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663414);
			UnityWebRequest.NativeMethodInfoPtr_get_downloadedBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663415);
			UnityWebRequest.NativeMethodInfoPtr_SetRedirectLimitFromScripting_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663416);
			UnityWebRequest.NativeMethodInfoPtr_set_redirectLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663417);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663418);
			UnityWebRequest.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663419);
			UnityWebRequest.NativeMethodInfoPtr_GetResponseHeader_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663420);
			UnityWebRequest.NativeMethodInfoPtr_GetResponseHeaderKeys_Internal_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663421);
			UnityWebRequest.NativeMethodInfoPtr_GetResponseHeaders_Public_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663422);
			UnityWebRequest.NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663423);
			UnityWebRequest.NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663424);
			UnityWebRequest.NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663425);
			UnityWebRequest.NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663426);
			UnityWebRequest.NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663427);
			UnityWebRequest.NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663428);
			UnityWebRequest.NativeMethodInfoPtr_SetCertificateHandler_Private_UnityWebRequestError_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663429);
			UnityWebRequest.NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663430);
			UnityWebRequest.NativeMethodInfoPtr_set_certificateHandler_Public_set_Void_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663431);
			UnityWebRequest.NativeMethodInfoPtr_SetTimeoutMsec_Private_UnityWebRequestError_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663432);
			UnityWebRequest.NativeMethodInfoPtr_set_timeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663433);
			UnityWebRequest.NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663434);
			UnityWebRequest.NativeMethodInfoPtr_Put_Public_Static_UnityWebRequest_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663435);
			UnityWebRequest.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663436);
			UnityWebRequest.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663437);
			UnityWebRequest.ClearCookieCacheDelegateField = IL2CPP.ResolveICall<UnityWebRequest.ClearCookieCacheDelegate>("UnityEngine.Networking.UnityWebRequest::ClearCookieCache");
			UnityWebRequest.get_use100ContinueDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_use100ContinueDelegate>("UnityEngine.Networking.UnityWebRequest::get_use100Continue");
			UnityWebRequest.set_use100ContinueDelegateField = IL2CPP.ResolveICall<UnityWebRequest.set_use100ContinueDelegate>("UnityEngine.Networking.UnityWebRequest::set_use100Continue");
			UnityWebRequest.get_uploadedBytesDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_uploadedBytesDelegate>("UnityEngine.Networking.UnityWebRequest::get_uploadedBytes");
			UnityWebRequest.GetRedirectLimitDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetRedirectLimitDelegate>("UnityEngine.Networking.UnityWebRequest::GetRedirectLimit");
			UnityWebRequest.GetChunkedDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetChunkedDelegate>("UnityEngine.Networking.UnityWebRequest::GetChunked");
			UnityWebRequest.SetChunkedDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetChunkedDelegate>("UnityEngine.Networking.UnityWebRequest::SetChunked");
			UnityWebRequest.GetRequestHeaderDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetRequestHeaderDelegate>("UnityEngine.Networking.UnityWebRequest::GetRequestHeader");
			UnityWebRequest.GetTimeoutMsecDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetTimeoutMsecDelegate>("UnityEngine.Networking.UnityWebRequest::GetTimeoutMsec");
			UnityWebRequest.GetSuppressErrorsToConsoleDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetSuppressErrorsToConsoleDelegate>("UnityEngine.Networking.UnityWebRequest::GetSuppressErrorsToConsole");
			UnityWebRequest.SetSuppressErrorsToConsoleDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetSuppressErrorsToConsoleDelegate>("UnityEngine.Networking.UnityWebRequest::SetSuppressErrorsToConsole");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000518C File Offset: 0x0000338C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247238, RefRangeEnd = 1247241, XrefRangeStart = 1247236, XrefRangeEnd = 1247238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000051C4 File Offset: 0x000033C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247241, XrefRangeEnd = 1247243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHTTPStatusString(long responseCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref responseCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000051FC File Offset: 0x000033FC
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00005238 File Offset: 0x00003438
		public unsafe bool disposeCertificateHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005278 File Offset: 0x00003478
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000052B4 File Offset: 0x000034B4
		public unsafe bool disposeDownloadHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000052F4 File Offset: 0x000034F4
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00005330 File Offset: 0x00003530
		public unsafe bool disposeUploadHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005370 File Offset: 0x00003570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247243, XrefRangeEnd = 1247245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000053A0 File Offset: 0x000035A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247245, XrefRangeEnd = 1247247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000053D4 File Offset: 0x000035D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247252, RefRangeEnd = 1247254, XrefRangeStart = 1247247, XrefRangeEnd = 1247252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalDestroy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005408 File Offset: 0x00003608
		[CallerCount(0)]
		public unsafe void InternalSetDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000543C File Offset: 0x0000363C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247254, XrefRangeEnd = 1247257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005478 File Offset: 0x00003678
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1247261, RefRangeEnd = 1247265, XrefRangeStart = 1247257, XrefRangeEnd = 1247261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(string url)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000054C4 File Offset: 0x000036C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247270, RefRangeEnd = 1247271, XrefRangeStart = 1247265, XrefRangeEnd = 1247270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(string url, string method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005524 File Offset: 0x00003724
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1247278, RefRangeEnd = 1247288, XrefRangeStart = 1247271, XrefRangeEnd = 1247278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uploadHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000055A8 File Offset: 0x000037A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247309, RefRangeEnd = 1247312, XrefRangeStart = 1247288, XrefRangeEnd = 1247309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uploadHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_DownloadHandler_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000562C File Offset: 0x0000382C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247312, XrefRangeEnd = 1247317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityWebRequest.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005668 File Offset: 0x00003868
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1247323, RefRangeEnd = 1247329, XrefRangeStart = 1247317, XrefRangeEnd = 1247323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000569C File Offset: 0x0000389C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247332, RefRangeEnd = 1247334, XrefRangeStart = 1247329, XrefRangeEnd = 1247332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_DisposeHandlers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000056D0 File Offset: 0x000038D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247334, XrefRangeEnd = 1247336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation BeginWebRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005710 File Offset: 0x00003910
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1247339, RefRangeEnd = 1247350, XrefRangeStart = 1247336, XrefRangeEnd = 1247339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation SendWebRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005750 File Offset: 0x00003950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247352, RefRangeEnd = 1247353, XrefRangeStart = 1247350, XrefRangeEnd = 1247352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005784 File Offset: 0x00003984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247353, XrefRangeEnd = 1247355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000057D0 File Offset: 0x000039D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247359, RefRangeEnd = 1247360, XrefRangeStart = 1247355, XrefRangeEnd = 1247359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005810 File Offset: 0x00003A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247360, XrefRangeEnd = 1247362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005860 File Offset: 0x00003A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247362, XrefRangeEnd = 1247366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetCustomMethod(string customMethodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000058A4 File Offset: 0x00003AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247366, XrefRangeEnd = 1247368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestMethod GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetMethod_Internal_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000058E0 File Offset: 0x00003AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247368, XrefRangeEnd = 1247370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCustomMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetCustomMethod_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005918 File Offset: 0x00003B18
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00005950 File Offset: 0x00003B50
		public unsafe string method
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1247379, RefRangeEnd = 1247380, XrefRangeStart = 1247370, XrefRangeEnd = 1247379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_method_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1247389, RefRangeEnd = 1247397, XrefRangeStart = 1247380, XrefRangeEnd = 1247389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_method_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005994 File Offset: 0x00003B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247397, XrefRangeEnd = 1247399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError GetError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000059D0 File Offset: 0x00003BD0
		public unsafe string error
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1247403, RefRangeEnd = 1247425, XrefRangeStart = 1247399, XrefRangeEnd = 1247403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00005A08 File Offset: 0x00003C08
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00005A40 File Offset: 0x00003C40
		public unsafe string url
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1247427, RefRangeEnd = 1247433, XrefRangeStart = 1247425, XrefRangeEnd = 1247427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1247440, RefRangeEnd = 1247443, XrefRangeStart = 1247433, XrefRangeEnd = 1247440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_url_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00005A84 File Offset: 0x00003C84
		public unsafe Uri uri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247443, XrefRangeEnd = 1247458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_uri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005AC8 File Offset: 0x00003CC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1247427, RefRangeEnd = 1247433, XrefRangeStart = 1247427, XrefRangeEnd = 1247433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUrl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetUrl_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005B00 File Offset: 0x00003D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247458, XrefRangeEnd = 1247460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005B50 File Offset: 0x00003D50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247464, RefRangeEnd = 1247467, XrefRangeStart = 1247460, XrefRangeEnd = 1247464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00005B94 File Offset: 0x00003D94
		public unsafe long responseCode
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1247469, RefRangeEnd = 1247481, XrefRangeStart = 1247467, XrefRangeEnd = 1247469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005BD0 File Offset: 0x00003DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247481, XrefRangeEnd = 1247483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetUploadProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetUploadProgress_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005C0C File Offset: 0x00003E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247483, XrefRangeEnd = 1247485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExecuting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_IsExecuting_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005C48 File Offset: 0x00003E48
		public unsafe float uploadProgress
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1247489, RefRangeEnd = 1247491, XrefRangeStart = 1247485, XrefRangeEnd = 1247489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_uploadProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00005C84 File Offset: 0x00003E84
		public unsafe bool isModifiable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247491, XrefRangeEnd = 1247493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005CC0 File Offset: 0x00003EC0
		public unsafe bool isDone
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1247495, RefRangeEnd = 1247501, XrefRangeStart = 1247493, XrefRangeEnd = 1247495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005CFC File Offset: 0x00003EFC
		public unsafe UnityWebRequest.Result result
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1247503, RefRangeEnd = 1247513, XrefRangeStart = 1247501, XrefRangeEnd = 1247503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_result_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005D38 File Offset: 0x00003F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247513, XrefRangeEnd = 1247515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDownloadProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetDownloadProgress_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005D74 File Offset: 0x00003F74
		public unsafe float downloadProgress
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1247519, RefRangeEnd = 1247526, XrefRangeStart = 1247515, XrefRangeEnd = 1247519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_downloadProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005DB0 File Offset: 0x00003FB0
		public unsafe ulong downloadedBytes
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1247528, RefRangeEnd = 1247533, XrefRangeStart = 1247526, XrefRangeEnd = 1247528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_downloadedBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005DEC File Offset: 0x00003FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247535, RefRangeEnd = 1247536, XrefRangeStart = 1247533, XrefRangeEnd = 1247535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRedirectLimitFromScripting(int limit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref limit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetRedirectLimitFromScripting_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000066D0 File Offset: 0x000048D0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00005E2C File Offset: 0x0000402C
		public unsafe int redirectLimit
		{
			get
			{
				return this.GetRedirectLimit();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1247535, RefRangeEnd = 1247536, XrefRangeStart = 1247535, XrefRangeEnd = 1247536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_redirectLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005E6C File Offset: 0x0000406C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247536, XrefRangeEnd = 1247538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005ECC File Offset: 0x000040CC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1247543, RefRangeEnd = 1247574, XrefRangeStart = 1247538, XrefRangeEnd = 1247543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRequestHeader(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005F20 File Offset: 0x00004120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247576, RefRangeEnd = 1247577, XrefRangeStart = 1247574, XrefRangeEnd = 1247576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetResponseHeader(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetResponseHeader_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005F68 File Offset: 0x00004168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247577, XrefRangeEnd = 1247579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetResponseHeaderKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetResponseHeaderKeys_Internal_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005FA8 File Offset: 0x000041A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247600, RefRangeEnd = 1247603, XrefRangeStart = 1247579, XrefRangeEnd = 1247600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> GetResponseHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetResponseHeaders_Public_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005FE8 File Offset: 0x000041E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247603, XrefRangeEnd = 1247605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00006038 File Offset: 0x00004238
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00006078 File Offset: 0x00004278
		public unsafe UploadHandler uploadHandler
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1247622, RefRangeEnd = 1247627, XrefRangeStart = 1247605, XrefRangeEnd = 1247622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000060BC File Offset: 0x000042BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247627, XrefRangeEnd = 1247629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000610C File Offset: 0x0000430C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000614C File Offset: 0x0000434C
		public unsafe DownloadHandler downloadHandler
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1247646, RefRangeEnd = 1247652, XrefRangeStart = 1247629, XrefRangeEnd = 1247646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006190 File Offset: 0x00004390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247652, XrefRangeEnd = 1247654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetCertificateHandler_Private_UnityWebRequestError_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000061E0 File Offset: 0x000043E0
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00006220 File Offset: 0x00004420
		public unsafe CertificateHandler certificateHandler
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318860, RefRangeEnd = 318862, XrefRangeStart = 318860, XrefRangeEnd = 318862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1247671, RefRangeEnd = 1247672, XrefRangeStart = 1247654, XrefRangeEnd = 1247671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_certificateHandler_Public_set_Void_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006264 File Offset: 0x00004464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247672, XrefRangeEnd = 1247674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetTimeoutMsec_Private_UnityWebRequestError_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006770 File Offset: 0x00004970
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000062B0 File Offset: 0x000044B0
		public unsafe int timeout
		{
			get
			{
				return this.GetTimeoutMsec() / 1000;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1247682, RefRangeEnd = 1247685, XrefRangeStart = 1247674, XrefRangeEnd = 1247682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_timeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000062F0 File Offset: 0x000044F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247697, RefRangeEnd = 1247698, XrefRangeStart = 1247685, XrefRangeEnd = 1247697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest Get(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006334 File Offset: 0x00004534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247728, RefRangeEnd = 1247729, XrefRangeStart = 1247698, XrefRangeEnd = 1247728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest Put(string uri, string bodyData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bodyData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Put_Public_Static_UnityWebRequest_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000638C File Offset: 0x0000458C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247743, RefRangeEnd = 1247746, XrefRangeStart = 1247729, XrefRangeEnd = 1247743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeURL(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000063C8 File Offset: 0x000045C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247746, XrefRangeEnd = 1247759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeURL(string s, Encoding e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000235A File Offset: 0x0000055A
		public UnityWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00006418 File Offset: 0x00004618
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002363 File Offset: 0x00000563
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00006440 File Offset: 0x00004640
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000237E File Offset: 0x0000057E
		public unsafe DownloadHandler m_DownloadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00006470 File Offset: 0x00004670
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000239D File Offset: 0x0000059D
		public unsafe UploadHandler m_UploadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000064A0 File Offset: 0x000046A0
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000023BC File Offset: 0x000005BC
		public unsafe CertificateHandler m_CertificateHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000064D0 File Offset: 0x000046D0
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000023DB File Offset: 0x000005DB
		public unsafe Uri m_Uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00006500 File Offset: 0x00004700
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000023FA File Offset: 0x000005FA
		public unsafe static string kHttpVerbGET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbGET, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbGET, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00006520 File Offset: 0x00004720
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000240C File Offset: 0x0000060C
		public unsafe static string kHttpVerbHEAD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbHEAD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbHEAD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00006540 File Offset: 0x00004740
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000241E File Offset: 0x0000061E
		public unsafe static string kHttpVerbPOST
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbPOST, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbPOST, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00006560 File Offset: 0x00004760
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002430 File Offset: 0x00000630
		public unsafe static string kHttpVerbPUT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbPUT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbPUT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00006580 File Offset: 0x00004780
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002442 File Offset: 0x00000642
		public unsafe static string kHttpVerbCREATE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbCREATE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbCREATE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000065A0 File Offset: 0x000047A0
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002454 File Offset: 0x00000654
		public unsafe static string kHttpVerbDELETE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbDELETE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityWebRequest.NativeFieldInfoPtr_kHttpVerbDELETE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000065C0 File Offset: 0x000047C0
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002466 File Offset: 0x00000666
		public unsafe bool _disposeCertificateHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000065E8 File Offset: 0x000047E8
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002481 File Offset: 0x00000681
		public unsafe bool _disposeDownloadHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00006610 File Offset: 0x00004810
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe bool _disposeUploadHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000024B7 File Offset: 0x000006B7
		public static void ClearCookieCache()
		{
			UnityWebRequest.ClearCookieCache(null, null);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000024C2 File Offset: 0x000006C2
		public static void ClearCookieCache(string domain, string path)
		{
			UnityWebRequest.ClearCookieCacheDelegateField(IL2CPP.ManagedStringToIl2Cpp(domain), IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006638 File Offset: 0x00004838
		public AsyncOperation Send()
		{
			return this.SendWebRequest();
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000024DA File Offset: 0x000006DA
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000024EC File Offset: 0x000006EC
		public bool use100Continue
		{
			get
			{
				return UnityWebRequest.get_use100ContinueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				UnityWebRequest.set_use100ContinueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00006650 File Offset: 0x00004850
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00006668 File Offset: 0x00004868
		public bool useHttpContinue
		{
			get
			{
				return this.use100Continue;
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent and its 100-Continue setting cannot be altered");
				}
				this.use100Continue = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00006698 File Offset: 0x00004898
		public bool isNetworkError
		{
			get
			{
				return this.result == UnityWebRequest.Result.ConnectionError;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000066B4 File Offset: 0x000048B4
		public bool isHttpError
		{
			get
			{
				return this.result == UnityWebRequest.Result.ProtocolError;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000024FF File Offset: 0x000006FF
		public ulong uploadedBytes
		{
			get
			{
				return UnityWebRequest.get_uploadedBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002511 File Offset: 0x00000711
		public int GetRedirectLimit()
		{
			return UnityWebRequest.GetRedirectLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002523 File Offset: 0x00000723
		public bool GetChunked()
		{
			return UnityWebRequest.GetChunkedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002535 File Offset: 0x00000735
		public UnityWebRequest.UnityWebRequestError SetChunked(bool chunked)
		{
			return UnityWebRequest.SetChunkedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), chunked);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000066E8 File Offset: 0x000048E8
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00006700 File Offset: 0x00004900
		public bool chunkedTransfer
		{
			get
			{
				return this.GetChunked();
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent and its chunked transfer encoding setting cannot be altered");
				}
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetChunked(value);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006744 File Offset: 0x00004944
		public string GetRequestHeader(string name)
		{
			IntPtr intPtr = UnityWebRequest.GetRequestHeaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002548 File Offset: 0x00000748
		public int GetTimeoutMsec()
		{
			return UnityWebRequest.GetTimeoutMsecDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000255A File Offset: 0x0000075A
		public bool GetSuppressErrorsToConsole()
		{
			return UnityWebRequest.GetSuppressErrorsToConsoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000256C File Offset: 0x0000076C
		public UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(bool suppress)
		{
			return UnityWebRequest.SetSuppressErrorsToConsoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), suppress);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006790 File Offset: 0x00004990
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000067A8 File Offset: 0x000049A8
		public bool suppressErrorsToConsole
		{
			get
			{
				return this.GetSuppressErrorsToConsole();
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent; cannot modify the timeout");
				}
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetSuppressErrorsToConsole(value);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000067EC File Offset: 0x000049EC
		public static UnityWebRequest Delete(string uri)
		{
			return new UnityWebRequest(uri, "DELETE");
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000680C File Offset: 0x00004A0C
		public static UnityWebRequest Head(string uri)
		{
			return new UnityWebRequest(uri, "HEAD");
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000257F File Offset: 0x0000077F
		public static UnityWebRequest GetTexture(string uri)
		{
			throw new NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000258C File Offset: 0x0000078C
		public static UnityWebRequest GetTexture(string uri, bool nonReadable)
		{
			throw new NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000682C File Offset: 0x00004A2C
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType)
		{
			return null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006840 File Offset: 0x00004A40
		public static UnityWebRequest GetAssetBundle(string uri)
		{
			return null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006854 File Offset: 0x00004A54
		public static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			return null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006868 File Offset: 0x00004A68
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			return null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000687C File Offset: 0x00004A7C
		public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc)
		{
			return null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006890 File Offset: 0x00004A90
		public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc)
		{
			return null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000068A4 File Offset: 0x00004AA4
		public static UnityWebRequest Put(string uri, Il2CppStructArray<byte> bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000068D0 File Offset: 0x00004AD0
		public static UnityWebRequest Post(string uri, string postData)
		{
			return UnityWebRequest.PostWwwForm(uri, postData);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000068EC File Offset: 0x00004AEC
		public static UnityWebRequest PostWwwForm(string uri, string form)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPostWwwForm(unityWebRequest, form);
			return unityWebRequest;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006914 File Offset: 0x00004B14
		public static void SetupPostWwwForm(UnityWebRequest request, string postData)
		{
			request.downloadHandler = new DownloadHandlerBuffer();
			bool flag = String.IsNullOrEmpty(postData);
			if (!flag)
			{
				string text = WWWTranscoder.DataEncode(postData, Encoding.UTF8);
				Il2CppStructArray<byte> bytes = Encoding.UTF8.GetBytes(text);
				request.uploadHandler = new UploadHandlerRaw(bytes);
				request.uploadHandler.contentType = "application/x-www-form-urlencoded";
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006974 File Offset: 0x00004B74
		public static UnityWebRequest Post(string uri, string postData, string contentType)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, postData, contentType);
			return unityWebRequest;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000699C File Offset: 0x00004B9C
		public static void SetupPost(UnityWebRequest request, string postData, string contentType)
		{
			request.downloadHandler = new DownloadHandlerBuffer();
			bool flag = String.IsNullOrEmpty(postData);
			if (flag)
			{
				request.SetRequestHeader("Content-Type", contentType);
			}
			else
			{
				Il2CppStructArray<byte> bytes = Encoding.UTF8.GetBytes(postData);
				request.uploadHandler = new UploadHandlerRaw(bytes);
				request.uploadHandler.contentType = contentType;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000069F8 File Offset: 0x00004BF8
		public static UnityWebRequest Post(string uri, WWWForm formData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formData);
			return unityWebRequest;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006A20 File Offset: 0x00004C20
		public static void SetupPost(UnityWebRequest request, WWWForm formData)
		{
			request.downloadHandler = new DownloadHandlerBuffer();
			bool flag = formData == null;
			if (!flag)
			{
				Il2CppStructArray<byte> il2CppStructArray = formData.data;
				bool flag2 = il2CppStructArray.Length == 0;
				if (flag2)
				{
					il2CppStructArray = null;
				}
				bool flag3 = il2CppStructArray != null;
				if (flag3)
				{
					request.uploadHandler = new UploadHandlerRaw(il2CppStructArray);
				}
				Dictionary<string, string> headers = formData.headers;
				Dictionary<string, string>.Enumerator enumerator = headers.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						request.SetRequestHeader(keyValuePair.Key, keyValuePair.Value);
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006AD0 File Offset: 0x00004CD0
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections)
		{
			Il2CppStructArray<byte> il2CppStructArray = UnityWebRequest.GenerateBoundary();
			return UnityWebRequest.Post(uri, multipartFormSections, il2CppStructArray);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, multipartFormSections, boundary);
			return unityWebRequest;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006B18 File Offset: 0x00004D18
		public static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			request.downloadHandler = new DownloadHandlerBuffer();
			Il2CppStructArray<byte> il2CppStructArray = null;
			bool flag = multipartFormSections != null && multipartFormSections.Count != 0;
			if (flag)
			{
				il2CppStructArray = UnityWebRequest.SerializeFormSections(multipartFormSections, boundary);
			}
			bool flag2 = il2CppStructArray == null;
			if (!flag2)
			{
				request.uploadHandler = new UploadHandlerRaw(il2CppStructArray)
				{
					contentType = String.Concat("multipart/form-data; boundary=", Encoding.UTF8.GetString(boundary, 0, boundary.Length))
				};
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006B8C File Offset: 0x00004D8C
		public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formFields);
			return unityWebRequest;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public static void SetupPost(UnityWebRequest request, Dictionary<string, string> formFields)
		{
			request.downloadHandler = new DownloadHandlerBuffer();
			Il2CppStructArray<byte> il2CppStructArray = null;
			bool flag = formFields != null && formFields.Count != 0;
			if (flag)
			{
				il2CppStructArray = UnityWebRequest.SerializeSimpleForm(formFields);
			}
			bool flag2 = il2CppStructArray == null;
			if (!flag2)
			{
				request.uploadHandler = new UploadHandlerRaw(il2CppStructArray)
				{
					contentType = "application/x-www-form-urlencoded"
				};
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006C10 File Offset: 0x00004E10
		public static string UnEscapeURL(string s)
		{
			return UnityWebRequest.UnEscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006C30 File Offset: 0x00004E30
		public static string UnEscapeURL(string s, Encoding e)
		{
			bool flag = s == null;
			string text;
			if (flag)
			{
				text = null;
			}
			else
			{
				bool flag2 = s.IndexOf('%') == -1 && s.IndexOf('+') == -1;
				if (flag2)
				{
					text = s;
				}
				else
				{
					Il2CppStructArray<byte> bytes = e.GetBytes(s);
					Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.URLDecode(bytes);
					text = e.GetString(il2CppStructArray);
				}
			}
			return text;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006C88 File Offset: 0x00004E88
		public static Il2CppStructArray<byte> SerializeFormSections(List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			bool flag = multipartFormSections == null || multipartFormSections.Count == 0;
			Il2CppStructArray<byte> il2CppStructArray;
			if (flag)
			{
				il2CppStructArray = null;
			}
			else
			{
				Il2CppStructArray<byte> bytes = Encoding.UTF8.GetBytes("\r\n");
				Il2CppStructArray<byte> bytes2 = WWWForm.DefaultEncoding.GetBytes("--");
				int num = 0;
				List<IMultipartFormSection>.Enumerator enumerator = multipartFormSections.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						IMultipartFormSection multipartFormSection = enumerator.Current;
						num += 64 + multipartFormSection.sectionData.Length;
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				List<byte> list = new List<byte>(num);
				List<IMultipartFormSection>.Enumerator enumerator2 = multipartFormSections.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						IMultipartFormSection multipartFormSection2 = enumerator2.Current;
						string text = "form-data";
						string sectionName = multipartFormSection2.sectionName;
						string fileName = multipartFormSection2.fileName;
						string text2 = String.Concat("Content-Disposition: ", text);
						bool flag2 = !String.IsNullOrEmpty(sectionName);
						if (flag2)
						{
							text2 = String.Concat(text2, "; name=\"", sectionName, "\"");
						}
						bool flag3 = !String.IsNullOrEmpty(fileName);
						if (flag3)
						{
							text2 = String.Concat(text2, "; filename=\"", fileName, "\"");
						}
						text2 = String.Concat(text2, "\r\n");
						string contentType = multipartFormSection2.contentType;
						bool flag4 = !String.IsNullOrEmpty(contentType);
						if (flag4)
						{
							text2 = String.Concat(text2, "Content-Type: ", contentType, "\r\n");
						}
						list.AddRange(bytes);
						list.AddRange(bytes2);
						list.AddRange(boundary);
						list.AddRange(bytes);
						list.AddRange(Encoding.UTF8.GetBytes(text2));
						list.AddRange(bytes);
						list.AddRange(multipartFormSection2.sectionData);
					}
				}
				finally
				{
					enumerator2.Dispose();
				}
				list.AddRange(bytes);
				list.AddRange(bytes2);
				list.AddRange(boundary);
				list.AddRange(bytes2);
				list.AddRange(bytes);
				il2CppStructArray = list.ToArray();
			}
			return il2CppStructArray;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002599 File Offset: 0x00000799
		public static Il2CppStructArray<byte> GenerateBoundary()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006EBC File Offset: 0x000050BC
		public static Il2CppStructArray<byte> SerializeSimpleForm(Dictionary<string, string> formFields)
		{
			string text = "";
			Dictionary<string, string>.Enumerator enumerator = formFields.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					bool flag = text.Length > 0;
					if (flag)
					{
						text = String.Concat(text, "&");
					}
					text = String.Concat(text, WWWTranscoder.DataEncode(keyValuePair.Key), "=", WWWTranscoder.DataEncode(keyValuePair.Value));
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return Encoding.UTF8.GetBytes(text);
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_m_DownloadHandler;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_m_UploadHandler;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_CertificateHandler;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_m_Uri;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_kHttpVerbGET;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_kHttpVerbHEAD;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_kHttpVerbPOST;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_kHttpVerbPUT;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_kHttpVerbCREATE;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_kHttpVerbDELETE;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Internal_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_String_DownloadHandler_UploadHandler_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_DisposeHandlers_Private_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Internal_UnityWebRequestMethod_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomMethod_Internal_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_method_Public_get_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_set_method_Public_set_Void_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Public_get_String_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_url_Public_get_String_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_set_url_Public_set_Void_String_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_uri_Public_set_Void_Uri_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_GetUrl_Private_String_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_GetUploadProgress_Private_Single_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_IsExecuting_Private_Boolean_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_uploadProgress_Public_get_Single_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_result_Public_get_Result_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadProgress_Private_Single_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_get_downloadProgress_Public_get_Single_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_get_downloadedBytes_Public_get_UInt64_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_SetRedirectLimitFromScripting_Private_Void_Int32_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_set_redirectLimit_Public_set_Void_Int32_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseHeader_Public_String_String_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseHeaderKeys_Internal_Il2CppStringArray_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseHeaders_Public_Dictionary_2_String_String_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_SetCertificateHandler_Private_UnityWebRequestError_CertificateHandler_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_set_certificateHandler_Public_set_Void_CertificateHandler_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeoutMsec_Private_UnityWebRequestError_Int32_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_set_timeout_Public_set_Void_Int32_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Put_Public_Static_UnityWebRequest_String_String_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0;

		// Token: 0x040000B6 RID: 182
		private static readonly UnityWebRequest.ClearCookieCacheDelegate ClearCookieCacheDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly UnityWebRequest.get_use100ContinueDelegate get_use100ContinueDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly UnityWebRequest.set_use100ContinueDelegate set_use100ContinueDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly UnityWebRequest.get_uploadedBytesDelegate get_uploadedBytesDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly UnityWebRequest.GetRedirectLimitDelegate GetRedirectLimitDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly UnityWebRequest.GetChunkedDelegate GetChunkedDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly UnityWebRequest.SetChunkedDelegate SetChunkedDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly UnityWebRequest.GetRequestHeaderDelegate GetRequestHeaderDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly UnityWebRequest.GetTimeoutMsecDelegate GetTimeoutMsecDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly UnityWebRequest.GetSuppressErrorsToConsoleDelegate GetSuppressErrorsToConsoleDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly UnityWebRequest.SetSuppressErrorsToConsoleDelegate SetSuppressErrorsToConsoleDelegateField;

		// Token: 0x02000014 RID: 20
		public enum UnityWebRequestMethod
		{
			// Token: 0x040000D9 RID: 217
			Get,
			// Token: 0x040000DA RID: 218
			Post,
			// Token: 0x040000DB RID: 219
			Put,
			// Token: 0x040000DC RID: 220
			Head,
			// Token: 0x040000DD RID: 221
			Custom
		}

		// Token: 0x02000015 RID: 21
		public enum UnityWebRequestError
		{
			// Token: 0x040000DF RID: 223
			OK,
			// Token: 0x040000E0 RID: 224
			OKCached,
			// Token: 0x040000E1 RID: 225
			Unknown,
			// Token: 0x040000E2 RID: 226
			SDKError,
			// Token: 0x040000E3 RID: 227
			UnsupportedProtocol,
			// Token: 0x040000E4 RID: 228
			MalformattedUrl,
			// Token: 0x040000E5 RID: 229
			CannotResolveProxy,
			// Token: 0x040000E6 RID: 230
			CannotResolveHost,
			// Token: 0x040000E7 RID: 231
			CannotConnectToHost,
			// Token: 0x040000E8 RID: 232
			AccessDenied,
			// Token: 0x040000E9 RID: 233
			GenericHttpError,
			// Token: 0x040000EA RID: 234
			WriteError,
			// Token: 0x040000EB RID: 235
			ReadError,
			// Token: 0x040000EC RID: 236
			OutOfMemory,
			// Token: 0x040000ED RID: 237
			Timeout,
			// Token: 0x040000EE RID: 238
			HTTPPostError,
			// Token: 0x040000EF RID: 239
			SSLCannotConnect,
			// Token: 0x040000F0 RID: 240
			Aborted,
			// Token: 0x040000F1 RID: 241
			TooManyRedirects,
			// Token: 0x040000F2 RID: 242
			ReceivedNoData,
			// Token: 0x040000F3 RID: 243
			SSLNotSupported,
			// Token: 0x040000F4 RID: 244
			FailedToSendData,
			// Token: 0x040000F5 RID: 245
			FailedToReceiveData,
			// Token: 0x040000F6 RID: 246
			SSLCertificateError,
			// Token: 0x040000F7 RID: 247
			SSLCipherNotAvailable,
			// Token: 0x040000F8 RID: 248
			SSLCACertError,
			// Token: 0x040000F9 RID: 249
			UnrecognizedContentEncoding,
			// Token: 0x040000FA RID: 250
			LoginFailed,
			// Token: 0x040000FB RID: 251
			SSLShutdownFailed,
			// Token: 0x040000FC RID: 252
			RedirectLimitInvalid,
			// Token: 0x040000FD RID: 253
			InvalidRedirect,
			// Token: 0x040000FE RID: 254
			CannotModifyRequest,
			// Token: 0x040000FF RID: 255
			HeaderNameContainsInvalidCharacters,
			// Token: 0x04000100 RID: 256
			HeaderValueContainsInvalidCharacters,
			// Token: 0x04000101 RID: 257
			CannotOverrideSystemHeaders,
			// Token: 0x04000102 RID: 258
			AlreadySent,
			// Token: 0x04000103 RID: 259
			InvalidMethod,
			// Token: 0x04000104 RID: 260
			NotImplemented,
			// Token: 0x04000105 RID: 261
			NoInternetConnection,
			// Token: 0x04000106 RID: 262
			DataProcessingError,
			// Token: 0x04000107 RID: 263
			InsecureConnectionNotAllowed
		}

		// Token: 0x02000016 RID: 22
		public enum Result
		{
			// Token: 0x04000109 RID: 265
			InProgress,
			// Token: 0x0400010A RID: 266
			Success,
			// Token: 0x0400010B RID: 267
			ConnectionError,
			// Token: 0x0400010C RID: 268
			ProtocolError,
			// Token: 0x0400010D RID: 269
			DataProcessingError
		}

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate void ClearCookieCacheDelegate(IntPtr domain, IntPtr path);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate bool get_use100ContinueDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate void set_use100ContinueDelegate(IntPtr @this, bool value);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate ulong get_uploadedBytesDelegate(IntPtr @this);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate int GetRedirectLimitDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate bool GetChunkedDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate UnityWebRequest.UnityWebRequestError SetChunkedDelegate(IntPtr @this, bool chunked);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate IntPtr GetRequestHeaderDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate int GetTimeoutMsecDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate bool GetSuppressErrorsToConsoleDelegate(IntPtr @this);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsoleDelegate(IntPtr @this, bool suppress);
	}
}
