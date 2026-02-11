using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A1 RID: 417
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x060019CC RID: 6604 RVA: 0x000818F8 File Offset: 0x0007FAF8
		// Note: this type is marked as 'beforefieldinit'.
		static FtpWebRequest()
		{
			Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr);
			FtpWebRequest.NativeFieldInfoPtr__syncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_syncObject");
			FtpWebRequest.NativeFieldInfoPtr__authInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_authInfo");
			FtpWebRequest.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_uri");
			FtpWebRequest.NativeFieldInfoPtr__methodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_methodInfo");
			FtpWebRequest.NativeFieldInfoPtr__renameTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_renameTo");
			FtpWebRequest.NativeFieldInfoPtr__getRequestStreamStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_getRequestStreamStarted");
			FtpWebRequest.NativeFieldInfoPtr__getResponseStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_getResponseStarted");
			FtpWebRequest.NativeFieldInfoPtr__startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_startTime");
			FtpWebRequest.NativeFieldInfoPtr__timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_timeout");
			FtpWebRequest.NativeFieldInfoPtr__remainingTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_remainingTimeout");
			FtpWebRequest.NativeFieldInfoPtr__contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_contentLength");
			FtpWebRequest.NativeFieldInfoPtr__contentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_contentOffset");
			FtpWebRequest.NativeFieldInfoPtr__clientCertificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_clientCertificates");
			FtpWebRequest.NativeFieldInfoPtr__passive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_passive");
			FtpWebRequest.NativeFieldInfoPtr__binary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_binary");
			FtpWebRequest.NativeFieldInfoPtr__connectionGroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_connectionGroupName");
			FtpWebRequest.NativeFieldInfoPtr__async = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_async");
			FtpWebRequest.NativeFieldInfoPtr__aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_aborted");
			FtpWebRequest.NativeFieldInfoPtr__timedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_timedOut");
			FtpWebRequest.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_exception");
			FtpWebRequest.NativeFieldInfoPtr__timerQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_timerQueue");
			FtpWebRequest.NativeFieldInfoPtr__timerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_timerCallback");
			FtpWebRequest.NativeFieldInfoPtr__enableSsl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_enableSsl");
			FtpWebRequest.NativeFieldInfoPtr__connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_connection");
			FtpWebRequest.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_stream");
			FtpWebRequest.NativeFieldInfoPtr__requestStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_requestStage");
			FtpWebRequest.NativeFieldInfoPtr__onceFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_onceFailed");
			FtpWebRequest.NativeFieldInfoPtr__ftpRequestHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_ftpRequestHeaders");
			FtpWebRequest.NativeFieldInfoPtr__ftpWebResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_ftpWebResponse");
			FtpWebRequest.NativeFieldInfoPtr__readWriteTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_readWriteTimeout");
			FtpWebRequest.NativeFieldInfoPtr__writeAsyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_writeAsyncResult");
			FtpWebRequest.NativeFieldInfoPtr__readAsyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_readAsyncResult");
			FtpWebRequest.NativeFieldInfoPtr__requestCompleteAsyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "_requestCompleteAsyncResult");
			FtpWebRequest.NativeFieldInfoPtr_s_defaultFtpNetworkCredential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "s_defaultFtpNetworkCredential");
			FtpWebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "s_DefaultTimerQueue");
			FtpWebRequest.NativeMethodInfoPtr_get_MethodInfo_Internal_get_FtpMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667337);
			FtpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667338);
			FtpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667339);
			FtpWebRequest.NativeMethodInfoPtr_get_RenameTo_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667340);
			FtpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667341);
			FtpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667342);
			FtpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667343);
			FtpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667344);
			FtpWebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667345);
			FtpWebRequest.NativeMethodInfoPtr_get_RemainingTimeout_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667346);
			FtpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667347);
			FtpWebRequest.NativeMethodInfoPtr_get_ContentOffset_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667348);
			FtpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667349);
			FtpWebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667350);
			FtpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667351);
			FtpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667352);
			FtpWebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667353);
			FtpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667354);
			FtpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667355);
			FtpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667356);
			FtpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667357);
			FtpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667358);
			FtpWebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667359);
			FtpWebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667360);
			FtpWebRequest.NativeMethodInfoPtr_SubmitRequest_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667361);
			FtpWebRequest.NativeMethodInfoPtr_TranslateConnectException_Private_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667362);
			FtpWebRequest.NativeMethodInfoPtr_CreateConnectionAsync_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667363);
			FtpWebRequest.NativeMethodInfoPtr_CreateConnection_Private_FtpControlStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667364);
			FtpWebRequest.NativeMethodInfoPtr_TimedSubmitRequestHelper_Private_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667365);
			FtpWebRequest.NativeMethodInfoPtr_TimerCallback_Private_Void_Timer_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667366);
			FtpWebRequest.NativeMethodInfoPtr_get_TimerQueue_Private_get_Queue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667367);
			FtpWebRequest.NativeMethodInfoPtr_AttemptedRecovery_Private_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667368);
			FtpWebRequest.NativeMethodInfoPtr_SetException_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667369);
			FtpWebRequest.NativeMethodInfoPtr_CheckError_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667370);
			FtpWebRequest.NativeMethodInfoPtr_RequestCallback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667371);
			FtpWebRequest.NativeMethodInfoPtr_SyncRequestCallback_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667372);
			FtpWebRequest.NativeMethodInfoPtr_AsyncRequestCallback_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667373);
			FtpWebRequest.NativeMethodInfoPtr_FinishRequestStage_Private_RequestStage_RequestStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667374);
			FtpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667375);
			FtpWebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_set_Void_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667376);
			FtpWebRequest.NativeMethodInfoPtr_get_UseBinary_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667377);
			FtpWebRequest.NativeMethodInfoPtr_get_UsePassive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667378);
			FtpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667379);
			FtpWebRequest.NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667380);
			FtpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667381);
			FtpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667382);
			FtpWebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667383);
			FtpWebRequest.NativeMethodInfoPtr_get_InUse_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667384);
			FtpWebRequest.NativeMethodInfoPtr_EnsureFtpWebResponse_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667385);
			FtpWebRequest.NativeMethodInfoPtr_DataStreamClosed_Internal_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100667386);
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00081FCC File Offset: 0x000801CC
		public unsafe FtpMethodInfo MethodInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_MethodInfo_Internal_get_FtpMethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpMethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0008200C File Offset: 0x0008020C
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00082044 File Offset: 0x00080244
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472960, XrefRangeEnd = 472966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00082088 File Offset: 0x00080288
		public unsafe string RenameTo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_RenameTo_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x000820C0 File Offset: 0x000802C0
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x00082100 File Offset: 0x00080300
		public unsafe override ICredentials Credentials
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472966, XrefRangeEnd = 472990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x00082144 File Offset: 0x00080344
		public unsafe override Uri RequestUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00082184 File Offset: 0x00080384
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x000821C0 File Offset: 0x000803C0
		public unsafe override int Timeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472990, XrefRangeEnd = 472991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00082200 File Offset: 0x00080400
		public unsafe int RemainingTimeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_RemainingTimeout_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0008223C File Offset: 0x0008043C
		public unsafe int ReadWriteTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00082278 File Offset: 0x00080478
		public unsafe long ContentOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ContentOffset_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x000822B4 File Offset: 0x000804B4
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x000822F0 File Offset: 0x000804F0
		public unsafe override long ContentLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x00082330 File Offset: 0x00080530
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x00082370 File Offset: 0x00080570
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CB RID: 1995
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x000823B4 File Offset: 0x000805B4
		public unsafe override string ConnectionGroupName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472991, XrefRangeEnd = 472998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x000823F8 File Offset: 0x000805F8
		public unsafe bool Aborted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00082434 File Offset: 0x00080634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473072, RefRangeEnd = 473073, XrefRangeStart = 472998, XrefRangeEnd = 473072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00082480 File Offset: 0x00080680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473073, XrefRangeEnd = 473147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x000824C0 File Offset: 0x000806C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473147, XrefRangeEnd = 473205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00082524 File Offset: 0x00080724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473205, XrefRangeEnd = 473225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00082574 File Offset: 0x00080774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473225, XrefRangeEnd = 473266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x000825D8 File Offset: 0x000807D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473266, XrefRangeEnd = 473286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00082628 File Offset: 0x00080828
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 473343, RefRangeEnd = 473346, XrefRangeStart = 473286, XrefRangeEnd = 473343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitRequest(bool isAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isAsync;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SubmitRequest_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00082668 File Offset: 0x00080868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473360, RefRangeEnd = 473361, XrefRangeStart = 473346, XrefRangeEnd = 473360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception TranslateConnectException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_TranslateConnectException_Private_Exception_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000826B8 File Offset: 0x000808B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473361, XrefRangeEnd = 473367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateConnectionAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CreateConnectionAsync_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000826EC File Offset: 0x000808EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 473378, RefRangeEnd = 473380, XrefRangeStart = 473367, XrefRangeEnd = 473378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpControlStream CreateConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CreateConnection_Private_FtpControlStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpControlStream>(intPtr3) : null;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0008272C File Offset: 0x0008092C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 473393, RefRangeEnd = 473395, XrefRangeStart = 473380, XrefRangeEnd = 473393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream TimedSubmitRequestHelper(bool isAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isAsync;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_TimedSubmitRequestHelper_Private_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00082778 File Offset: 0x00080978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473395, XrefRangeEnd = 473422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimerCallback(TimerThread.Timer timer, int timeNoticed, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeNoticed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_TimerCallback_Private_Void_Timer_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x000827DC File Offset: 0x000809DC
		public unsafe TimerThread.Queue TimerQueue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473422, XrefRangeEnd = 473427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_TimerQueue_Private_get_Queue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr3) : null;
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0008281C File Offset: 0x00080A1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 473454, RefRangeEnd = 473456, XrefRangeStart = 473427, XrefRangeEnd = 473454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AttemptedRecovery(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_AttemptedRecovery_Private_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0008286C File Offset: 0x00080A6C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 473498, RefRangeEnd = 473504, XrefRangeStart = 473456, XrefRangeEnd = 473498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetException_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000828B0 File Offset: 0x00080AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473504, XrefRangeEnd = 473505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CheckError_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000828E4 File Offset: 0x00080AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473505, XrefRangeEnd = 473506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCallback(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_RequestCallback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00082928 File Offset: 0x00080B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 473558, RefRangeEnd = 473559, XrefRangeStart = 473506, XrefRangeEnd = 473558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncRequestCallback(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SyncRequestCallback_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0008296C File Offset: 0x00080B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 473688, RefRangeEnd = 473690, XrefRangeStart = 473559, XrefRangeEnd = 473688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AsyncRequestCallback(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_AsyncRequestCallback_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x000829B0 File Offset: 0x00080BB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 473734, RefRangeEnd = 473741, XrefRangeStart = 473690, XrefRangeEnd = 473734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_FinishRequestStage_Private_RequestStage_RequestStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000829FC File Offset: 0x00080BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473741, XrefRangeEnd = 473782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007CE RID: 1998
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x00082A30 File Offset: 0x00080C30
		public unsafe override RequestCachePolicy CachePolicy
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_set_Void_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00082A74 File Offset: 0x00080C74
		public unsafe bool UseBinary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_UseBinary_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00082AB0 File Offset: 0x00080CB0
		public unsafe bool UsePassive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_UsePassive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00082AEC File Offset: 0x00080CEC
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 473800, RefRangeEnd = 473802, XrefRangeStart = 473782, XrefRangeEnd = 473800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00082B2C File Offset: 0x00080D2C
		public unsafe bool EnableSsl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00082B68 File Offset: 0x00080D68
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473802, XrefRangeEnd = 473807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00082BA8 File Offset: 0x00080DA8
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473807, XrefRangeEnd = 473810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x00082BE4 File Offset: 0x00080DE4
		public unsafe override bool PreAuthenticate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473810, XrefRangeEnd = 473813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00082C24 File Offset: 0x00080E24
		public unsafe bool InUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_InUse_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00082C60 File Offset: 0x00080E60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 473871, RefRangeEnd = 473877, XrefRangeStart = 473813, XrefRangeEnd = 473871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureFtpWebResponse(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_EnsureFtpWebResponse_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00082CA4 File Offset: 0x00080EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473877, XrefRangeEnd = 473881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DataStreamClosed(CloseExState closeState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_DataStreamClosed_Internal_Void_CloseExState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0000B097 File Offset: 0x00009297
		public FtpWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00082CE4 File Offset: 0x00080EE4
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x0000B0A0 File Offset: 0x000092A0
		public unsafe Object _syncObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__syncObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__syncObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00082D14 File Offset: 0x00080F14
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0000B0BF File Offset: 0x000092BF
		public unsafe ICredentials _authInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__authInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__authInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00082D44 File Offset: 0x00080F44
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0000B0DE File Offset: 0x000092DE
		public unsafe Uri _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00082D74 File Offset: 0x00080F74
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x0000B0FD File Offset: 0x000092FD
		public unsafe FtpMethodInfo _methodInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__methodInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpMethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__methodInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00082DA4 File Offset: 0x00080FA4
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x0000B11C File Offset: 0x0000931C
		public unsafe string _renameTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__renameTo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__renameTo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x00082DCC File Offset: 0x00080FCC
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x0000B13B File Offset: 0x0000933B
		public unsafe bool _getRequestStreamStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__getRequestStreamStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__getRequestStreamStarted)) = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00082DF4 File Offset: 0x00080FF4
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x0000B156 File Offset: 0x00009356
		public unsafe bool _getResponseStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__getResponseStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__getResponseStarted)) = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x00082E1C File Offset: 0x0008101C
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x0000B171 File Offset: 0x00009371
		public unsafe DateTime _startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__startTime)) = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00082E44 File Offset: 0x00081044
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x0000B18C File Offset: 0x0000938C
		public unsafe int _timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timeout)) = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00082E6C File Offset: 0x0008106C
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x0000B1A7 File Offset: 0x000093A7
		public unsafe int _remainingTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__remainingTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__remainingTimeout)) = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00082E94 File Offset: 0x00081094
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x0000B1C2 File Offset: 0x000093C2
		public unsafe long _contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__contentLength)) = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00082EBC File Offset: 0x000810BC
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0000B1DD File Offset: 0x000093DD
		public unsafe long _contentOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__contentOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__contentOffset)) = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00082EE4 File Offset: 0x000810E4
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0000B1F8 File Offset: 0x000093F8
		public unsafe X509CertificateCollection _clientCertificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__clientCertificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__clientCertificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00082F14 File Offset: 0x00081114
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0000B217 File Offset: 0x00009417
		public unsafe bool _passive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__passive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__passive)) = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00082F3C File Offset: 0x0008113C
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0000B232 File Offset: 0x00009432
		public unsafe bool _binary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__binary);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__binary)) = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00082F64 File Offset: 0x00081164
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x0000B24D File Offset: 0x0000944D
		public unsafe string _connectionGroupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__connectionGroupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__connectionGroupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00082F8C File Offset: 0x0008118C
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0000B26C File Offset: 0x0000946C
		public unsafe bool _async
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__async);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__async)) = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00082FB4 File Offset: 0x000811B4
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x0000B287 File Offset: 0x00009487
		public unsafe bool _aborted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__aborted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__aborted)) = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00082FDC File Offset: 0x000811DC
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x0000B2A2 File Offset: 0x000094A2
		public unsafe bool _timedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timedOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timedOut)) = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00083004 File Offset: 0x00081204
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x0000B2BD File Offset: 0x000094BD
		public unsafe Exception _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00083034 File Offset: 0x00081234
		// (set) Token: 0x06001A29 RID: 6697 RVA: 0x0000B2DC File Offset: 0x000094DC
		public unsafe TimerThread.Queue _timerQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timerQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timerQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00083064 File Offset: 0x00081264
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0000B2FB File Offset: 0x000094FB
		public unsafe TimerThread.Callback _timerCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timerCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__timerCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00083094 File Offset: 0x00081294
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x0000B31A File Offset: 0x0000951A
		public unsafe bool _enableSsl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__enableSsl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__enableSsl)) = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x000830BC File Offset: 0x000812BC
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0000B335 File Offset: 0x00009535
		public unsafe FtpControlStream _connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpControlStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000830EC File Offset: 0x000812EC
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0000B354 File Offset: 0x00009554
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x0008311C File Offset: 0x0008131C
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0000B373 File Offset: 0x00009573
		public unsafe FtpWebRequest.RequestStage _requestStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__requestStage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__requestStage)) = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x00083144 File Offset: 0x00081344
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0000B38E File Offset: 0x0000958E
		public unsafe bool _onceFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__onceFailed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__onceFailed)) = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0008316C File Offset: 0x0008136C
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x0000B3A9 File Offset: 0x000095A9
		public unsafe WebHeaderCollection _ftpRequestHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__ftpRequestHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__ftpRequestHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x0008319C File Offset: 0x0008139C
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0000B3C8 File Offset: 0x000095C8
		public unsafe FtpWebResponse _ftpWebResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__ftpWebResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__ftpWebResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x000831CC File Offset: 0x000813CC
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0000B3E7 File Offset: 0x000095E7
		public unsafe int _readWriteTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__readWriteTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__readWriteTimeout)) = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x000831F4 File Offset: 0x000813F4
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0000B402 File Offset: 0x00009602
		public unsafe ContextAwareResult _writeAsyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__writeAsyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextAwareResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__writeAsyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x00083224 File Offset: 0x00081424
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0000B421 File Offset: 0x00009621
		public unsafe LazyAsyncResult _readAsyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__readAsyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__readAsyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x00083254 File Offset: 0x00081454
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x0000B440 File Offset: 0x00009640
		public unsafe LazyAsyncResult _requestCompleteAsyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__requestCompleteAsyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr__requestCompleteAsyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x00083284 File Offset: 0x00081484
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0000B45F File Offset: 0x0000965F
		public unsafe static NetworkCredential s_defaultFtpNetworkCredential
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpWebRequest.NativeFieldInfoPtr_s_defaultFtpNetworkCredential, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpWebRequest.NativeFieldInfoPtr_s_defaultFtpNetworkCredential, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x000832AC File Offset: 0x000814AC
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0000B471 File Offset: 0x00009671
		public new unsafe static TimerThread.Queue s_DefaultTimerQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpWebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpWebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr__syncObject;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr__authInfo;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr__methodInfo;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeFieldInfoPtr__renameTo;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeFieldInfoPtr__getRequestStreamStarted;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr__getResponseStarted;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr__startTime;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr__timeout;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr__remainingTimeout;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr__contentLength;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr__contentOffset;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr__clientCertificates;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeFieldInfoPtr__passive;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeFieldInfoPtr__binary;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeFieldInfoPtr__connectionGroupName;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeFieldInfoPtr__async;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeFieldInfoPtr__aborted;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeFieldInfoPtr__timedOut;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr__timerQueue;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr__timerCallback;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr__enableSsl;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr__connection;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeFieldInfoPtr__requestStage;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr__onceFailed;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeFieldInfoPtr__ftpRequestHeaders;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeFieldInfoPtr__ftpWebResponse;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr__readWriteTimeout;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr__writeAsyncResult;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr__readAsyncResult;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr__requestCompleteAsyncResult;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultFtpNetworkCredential;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTimerQueue;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodInfo_Internal_get_FtpMethodInfo_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_get_RenameTo_Public_get_String_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingTimeout_Internal_get_Int32_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentOffset_Public_get_Int64_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_SubmitRequest_Private_Void_Boolean_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_TranslateConnectException_Private_Exception_Exception_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_CreateConnectionAsync_Private_Void_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_CreateConnection_Private_FtpControlStream_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_TimedSubmitRequestHelper_Private_Stream_Boolean_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_TimerCallback_Private_Void_Timer_Int32_Object_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerQueue_Private_get_Queue_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_AttemptedRecovery_Private_Boolean_Exception_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Private_Void_Exception_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_CheckError_Private_Void_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_RequestCallback_Internal_Void_Object_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_SyncRequestCallback_Private_Void_Object_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_AsyncRequestCallback_Private_Void_Object_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_FinishRequestStage_Private_RequestStage_RequestStage_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_set_Void_RequestCachePolicy_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_get_UseBinary_Public_get_Boolean_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_get_UsePassive_Public_get_Boolean_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_get_InUse_Private_get_Boolean_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_EnsureFtpWebResponse_Private_Void_Exception_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_DataStreamClosed_Internal_Void_CloseExState_0;

		// Token: 0x02000318 RID: 792
		public enum RequestStage
		{
			// Token: 0x0400249E RID: 9374
			CheckForError,
			// Token: 0x0400249F RID: 9375
			RequestStarted,
			// Token: 0x040024A0 RID: 9376
			WriteReady,
			// Token: 0x040024A1 RID: 9377
			ReadReady,
			// Token: 0x040024A2 RID: 9378
			ReleaseConnection
		}

		// Token: 0x02000319 RID: 793
		[ObfuscatedName("System.Net.FtpWebRequest+<CreateConnectionAsync>d__86")]
		public sealed class _CreateConnectionAsync_d__86 : ValueType
		{
			// Token: 0x06002EA4 RID: 11940 RVA: 0x000CC4F8 File Offset: 0x000CA6F8
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateConnectionAsync_d__86()
			{
				Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "<CreateConnectionAsync>d__86");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr);
				FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr, "<>1__state");
				FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr, "<>t__builder");
				FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr, "<>4__this");
				FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr__client_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr, "<client>5__2");
				FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr, "<>u__1");
				FtpWebRequest._CreateConnectionAsync_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr, 100667388);
				FtpWebRequest._CreateConnectionAsync_d__86.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr, 100667389);
			}

			// Token: 0x06002EA5 RID: 11941 RVA: 0x000CC5B0 File Offset: 0x000CA7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472929, XrefRangeEnd = 472955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest._CreateConnectionAsync_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EA6 RID: 11942 RVA: 0x000CC5E8 File Offset: 0x000CA7E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472955, XrefRangeEnd = 472956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest._CreateConnectionAsync_d__86.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EA7 RID: 11943 RVA: 0x00014D77 File Offset: 0x00012F77
			public _CreateConnectionAsync_d__86(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EA8 RID: 11944 RVA: 0x00014D80 File Offset: 0x00012F80
			public _CreateConnectionAsync_d__86()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebRequest._CreateConnectionAsync_d__86>.NativeClassPtr))
			{
			}

			// Token: 0x17000E9A RID: 3738
			// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x000CC630 File Offset: 0x000CA830
			// (set) Token: 0x06002EAA RID: 11946 RVA: 0x00014D92 File Offset: 0x00012F92
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E9B RID: 3739
			// (get) Token: 0x06002EAB RID: 11947 RVA: 0x000CC658 File Offset: 0x000CA858
			// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00014DAD File Offset: 0x00012FAD
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000E9C RID: 3740
			// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000CC688 File Offset: 0x000CA888
			// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00014DDB File Offset: 0x00012FDB
			public unsafe FtpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E9D RID: 3741
			// (get) Token: 0x06002EAF RID: 11951 RVA: 0x000CC6B8 File Offset: 0x000CA8B8
			// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00014DFA File Offset: 0x00012FFA
			public unsafe TcpClient _client_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr__client_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TcpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr__client_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E9E RID: 3742
			// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x000CC6E8 File Offset: 0x000CA8E8
			// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x00014E19 File Offset: 0x00013019
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest._CreateConnectionAsync_d__86.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040024A3 RID: 9379
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040024A4 RID: 9380
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040024A5 RID: 9381
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040024A6 RID: 9382
			private static readonly IntPtr NativeFieldInfoPtr__client_5__2;

			// Token: 0x040024A7 RID: 9383
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040024A8 RID: 9384
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040024A9 RID: 9385
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200031A RID: 794
		[ObfuscatedName("System.Net.FtpWebRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002EB3 RID: 11955 RVA: 0x000CC718 File Offset: 0x000CA918
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FtpWebRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebRequest.__c>.NativeClassPtr);
				FtpWebRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest.__c>.NativeClassPtr, "<>9");
				FtpWebRequest.__c.NativeFieldInfoPtr___9__114_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest.__c>.NativeClassPtr, "<>9__114_0");
				FtpWebRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest.__c>.NativeClassPtr, 100667391);
				FtpWebRequest.__c.NativeMethodInfoPtr__get_ClientCertificates_b__114_0_Internal_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest.__c>.NativeClassPtr, 100667392);
			}

			// Token: 0x06002EB4 RID: 11956 RVA: 0x000CC794 File Offset: 0x000CA994
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EB5 RID: 11957 RVA: 0x000CC7D0 File Offset: 0x000CA9D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472956, XrefRangeEnd = 472960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509CertificateCollection _get_ClientCertificates_b__114_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.__c.NativeMethodInfoPtr__get_ClientCertificates_b__114_0_Internal_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}

			// Token: 0x06002EB6 RID: 11958 RVA: 0x00014E47 File Offset: 0x00013047
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E9F RID: 3743
			// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x000CC810 File Offset: 0x000CAA10
			// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00014E50 File Offset: 0x00013050
			public unsafe static FtpWebRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FtpWebRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FtpWebRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EA0 RID: 3744
			// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x000CC838 File Offset: 0x000CAA38
			// (set) Token: 0x06002EBA RID: 11962 RVA: 0x00014E62 File Offset: 0x00013062
			public unsafe static Func<X509CertificateCollection> __9__114_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FtpWebRequest.__c.NativeFieldInfoPtr___9__114_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<X509CertificateCollection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FtpWebRequest.__c.NativeFieldInfoPtr___9__114_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040024AA RID: 9386
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040024AB RID: 9387
			private static readonly IntPtr NativeFieldInfoPtr___9__114_0;

			// Token: 0x040024AC RID: 9388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040024AD RID: 9389
			private static readonly IntPtr NativeMethodInfoPtr__get_ClientCertificates_b__114_0_Internal_X509CertificateCollection_0;
		}
	}
}
