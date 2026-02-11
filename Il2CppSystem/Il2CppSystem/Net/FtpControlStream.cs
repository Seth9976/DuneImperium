using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x0200019C RID: 412
	public class FtpControlStream : CommandStream
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x0007F624 File Offset: 0x0007D824
		// Note: this type is marked as 'beforefieldinit'.
		static FtpControlStream()
		{
			Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpControlStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr);
			FtpControlStream.NativeFieldInfoPtr__dataSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_dataSocket");
			FtpControlStream.NativeFieldInfoPtr__passiveEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_passiveEndPoint");
			FtpControlStream.NativeFieldInfoPtr__tlsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_tlsStream");
			FtpControlStream.NativeFieldInfoPtr__bannerMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_bannerMessage");
			FtpControlStream.NativeFieldInfoPtr__welcomeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_welcomeMessage");
			FtpControlStream.NativeFieldInfoPtr__exitMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_exitMessage");
			FtpControlStream.NativeFieldInfoPtr__credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_credentials");
			FtpControlStream.NativeFieldInfoPtr__currentTypeSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_currentTypeSetting");
			FtpControlStream.NativeFieldInfoPtr__contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_contentLength");
			FtpControlStream.NativeFieldInfoPtr__lastModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_lastModified");
			FtpControlStream.NativeFieldInfoPtr__dataHandshakeStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_dataHandshakeStarted");
			FtpControlStream.NativeFieldInfoPtr__loginDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_loginDirectory");
			FtpControlStream.NativeFieldInfoPtr__establishedServerDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_establishedServerDirectory");
			FtpControlStream.NativeFieldInfoPtr__requestedServerDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_requestedServerDirectory");
			FtpControlStream.NativeFieldInfoPtr__responseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_responseUri");
			FtpControlStream.NativeFieldInfoPtr__loginState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "_loginState");
			FtpControlStream.NativeFieldInfoPtr_StatusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "StatusCode");
			FtpControlStream.NativeFieldInfoPtr_StatusLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "StatusLine");
			FtpControlStream.NativeFieldInfoPtr_s_acceptCallbackDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "s_acceptCallbackDelegate");
			FtpControlStream.NativeFieldInfoPtr_s_connectCallbackDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "s_connectCallbackDelegate");
			FtpControlStream.NativeFieldInfoPtr_s_SSLHandshakeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "s_SSLHandshakeCallback");
			FtpControlStream.NativeMethodInfoPtr_get_Credentials_Internal_get_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667266);
			FtpControlStream.NativeMethodInfoPtr_set_Credentials_Internal_set_Void_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667267);
			FtpControlStream.NativeMethodInfoPtr__ctor_Internal_Void_TcpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667268);
			FtpControlStream.NativeMethodInfoPtr_AbortConnect_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667269);
			FtpControlStream.NativeMethodInfoPtr_AcceptCallback_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667270);
			FtpControlStream.NativeMethodInfoPtr_ConnectCallback_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667271);
			FtpControlStream.NativeMethodInfoPtr_SSLHandshakeCallback_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667272);
			FtpControlStream.NativeMethodInfoPtr_QueueOrCreateFtpDataStream_Private_PipelineInstruction_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667273);
			FtpControlStream.NativeMethodInfoPtr_ClearState_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667274);
			FtpControlStream.NativeMethodInfoPtr_PipelineCallback_Protected_Virtual_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667275);
			FtpControlStream.NativeMethodInfoPtr_BuildCommandsList_Protected_Virtual_Il2CppReferenceArray_1_PipelineEntry_WebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667276);
			FtpControlStream.NativeMethodInfoPtr_QueueOrCreateDataConection_Private_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667277);
			FtpControlStream.NativeMethodInfoPtr_GetPathInfo_Private_Static_Void_GetPathOption_Uri_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667278);
			FtpControlStream.NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667279);
			FtpControlStream.NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667280);
			FtpControlStream.NativeMethodInfoPtr_get_ContentLength_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667281);
			FtpControlStream.NativeMethodInfoPtr_get_LastModified_Internal_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667282);
			FtpControlStream.NativeMethodInfoPtr_get_ResponseUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667283);
			FtpControlStream.NativeMethodInfoPtr_get_BannerMessage_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667284);
			FtpControlStream.NativeMethodInfoPtr_get_WelcomeMessage_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667285);
			FtpControlStream.NativeMethodInfoPtr_get_ExitMessage_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667286);
			FtpControlStream.NativeMethodInfoPtr_GetContentLengthFrom213Response_Private_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667287);
			FtpControlStream.NativeMethodInfoPtr_GetLastModifiedFrom213Response_Private_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667288);
			FtpControlStream.NativeMethodInfoPtr_TryUpdateResponseUri_Private_Void_String_FtpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667289);
			FtpControlStream.NativeMethodInfoPtr_TryUpdateContentLength_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667290);
			FtpControlStream.NativeMethodInfoPtr_GetLoginDirectory_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667291);
			FtpControlStream.NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667292);
			FtpControlStream.NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667293);
			FtpControlStream.NativeMethodInfoPtr_CreateFtpListenerSocket_Private_Void_FtpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667294);
			FtpControlStream.NativeMethodInfoPtr_GetPortCommandLine_Private_String_FtpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667295);
			FtpControlStream.NativeMethodInfoPtr_FormatFtpCommand_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667296);
			FtpControlStream.NativeMethodInfoPtr_CreateFtpDataSocket_Protected_Socket_FtpWebRequest_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667297);
			FtpControlStream.NativeMethodInfoPtr_CheckValid_Protected_Virtual_Boolean_ResponseDescription_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667298);
			FtpControlStream.NativeMethodInfoPtr_IsFtpDataStreamWriteable_Private_TriState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, 100667299);
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x0007FAA0 File Offset: 0x0007DCA0
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x0007FAE0 File Offset: 0x0007DCE0
		public unsafe NetworkCredential Credentials
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 471880, RefRangeEnd = 471884, XrefRangeStart = 471877, XrefRangeEnd = 471880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_get_Credentials_Internal_get_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471884, XrefRangeEnd = 471890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_set_Credentials_Internal_set_Void_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0007FB24 File Offset: 0x0007DD24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 471910, RefRangeEnd = 471912, XrefRangeStart = 471890, XrefRangeEnd = 471910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpControlStream(TcpClient client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr__ctor_Internal_Void_TcpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0007FB70 File Offset: 0x0007DD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471914, RefRangeEnd = 471915, XrefRangeStart = 471912, XrefRangeEnd = 471914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AbortConnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_AbortConnect_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0007FBA4 File Offset: 0x0007DDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471915, XrefRangeEnd = 471934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AcceptCallback(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_AcceptCallback_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0007FBDC File Offset: 0x0007DDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471934, XrefRangeEnd = 471944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectCallback(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_ConnectCallback_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0007FC14 File Offset: 0x0007DE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471944, XrefRangeEnd = 471953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SSLHandshakeCallback(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_SSLHandshakeCallback_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0007FC4C File Offset: 0x0007DE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471953, XrefRangeEnd = 471977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_QueueOrCreateFtpDataStream_Private_PipelineInstruction_byref_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471977, XrefRangeEnd = 471987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpControlStream.NativeMethodInfoPtr_ClearState_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0007FCEC File Offset: 0x0007DEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471987, XrefRangeEnd = 472094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpControlStream.NativeMethodInfoPtr_PipelineCallback_Protected_Virtual_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0007FD90 File Offset: 0x0007DF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472094, XrefRangeEnd = 472354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<CommandStream.PipelineEntry> BuildCommandsList(WebRequest req)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(req);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpControlStream.NativeMethodInfoPtr_BuildCommandsList_Protected_Virtual_Il2CppReferenceArray_1_PipelineEntry_WebRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CommandStream.PipelineEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0007FDEC File Offset: 0x0007DFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472441, RefRangeEnd = 472442, XrefRangeStart = 472354, XrefRangeEnd = 472441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isSocketReady;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_QueueOrCreateDataConection_Private_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0007FE94 File Offset: 0x0007E094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472442, XrefRangeEnd = 472460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pathOption;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_GetPathInfo_Private_Static_Void_GetPathOption_Uri_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			path = IL2CPP.Il2CppStringToManaged(intPtr);
			directory = IL2CPP.Il2CppStringToManaged(intPtr2);
			filename = IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0007FF28 File Offset: 0x0007E128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472482, RefRangeEnd = 472483, XrefRangeStart = 472460, XrefRangeEnd = 472482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatAddress(IPAddress address, int Port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0007FF80 File Offset: 0x0007E180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472483, XrefRangeEnd = 472496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatAddressV6(IPAddress address, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x0007FFD8 File Offset: 0x0007E1D8
		public unsafe long ContentLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_get_ContentLength_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00080014 File Offset: 0x0007E214
		public unsafe DateTime LastModified
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_get_LastModified_Internal_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00080050 File Offset: 0x0007E250
		public unsafe Uri ResponseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_get_ResponseUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00080090 File Offset: 0x0007E290
		public unsafe string BannerMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_get_BannerMessage_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x000800C8 File Offset: 0x0007E2C8
		public unsafe string WelcomeMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_get_WelcomeMessage_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00080100 File Offset: 0x0007E300
		public unsafe string ExitMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_get_ExitMessage_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00080138 File Offset: 0x0007E338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472496, XrefRangeEnd = 472514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetContentLengthFrom213Response(string responseString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(responseString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_GetContentLengthFrom213Response_Private_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00080188 File Offset: 0x0007E388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472549, RefRangeEnd = 472550, XrefRangeStart = 472514, XrefRangeEnd = 472549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetLastModifiedFrom213Response(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_GetLastModifiedFrom213Response_Private_DateTime_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000801D8 File Offset: 0x0007E3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472550, XrefRangeEnd = 472591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateResponseUri(string str, FtpWebRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_TryUpdateResponseUri_Private_Void_String_FtpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0008022C File Offset: 0x0007E42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472591, XrefRangeEnd = 472600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateContentLength(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_TryUpdateContentLength_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00080270 File Offset: 0x0007E470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472600, XrefRangeEnd = 472605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLoginDirectory(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_GetLoginDirectory_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000802B8 File Offset: 0x0007E4B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472623, RefRangeEnd = 472624, XrefRangeStart = 472605, XrefRangeEnd = 472623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPortV4(string responseString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(responseString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00080308 File Offset: 0x0007E508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472656, RefRangeEnd = 472657, XrefRangeStart = 472624, XrefRangeEnd = 472656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPortV6(string responseString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(responseString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00080358 File Offset: 0x0007E558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472683, RefRangeEnd = 472684, XrefRangeStart = 472657, XrefRangeEnd = 472683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateFtpListenerSocket(FtpWebRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_CreateFtpListenerSocket_Private_Void_FtpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0008039C File Offset: 0x0007E59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472704, RefRangeEnd = 472705, XrefRangeStart = 472684, XrefRangeEnd = 472704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPortCommandLine(FtpWebRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_GetPortCommandLine_Private_String_FtpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000803E4 File Offset: 0x0007E5E4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 472718, RefRangeEnd = 472735, XrefRangeStart = 472705, XrefRangeEnd = 472718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatFtpCommand(string command, string parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_FormatFtpCommand_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00080440 File Offset: 0x0007E640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472735, XrefRangeEnd = 472739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(templateSocket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_CreateFtpDataSocket_Protected_Socket_FtpWebRequest_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000804A4 File Offset: 0x0007E6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472739, XrefRangeEnd = 472791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &validThrough;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &completeLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpControlStream.NativeMethodInfoPtr_CheckValid_Protected_Virtual_Boolean_ResponseDescription_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00080518 File Offset: 0x0007E718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472791, XrefRangeEnd = 472793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriState IsFtpDataStreamWriteable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.NativeMethodInfoPtr_IsFtpDataStreamWriteable_Private_TriState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0000ACFC File Offset: 0x00008EFC
		public FtpControlStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00080554 File Offset: 0x0007E754
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x0000AD05 File Offset: 0x00008F05
		public unsafe Socket _dataSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__dataSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__dataSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00080584 File Offset: 0x0007E784
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x0000AD24 File Offset: 0x00008F24
		public unsafe IPEndPoint _passiveEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__passiveEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__passiveEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x000805B4 File Offset: 0x0007E7B4
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x0000AD43 File Offset: 0x00008F43
		public unsafe TlsStream _tlsStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__tlsStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TlsStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__tlsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x000805E4 File Offset: 0x0007E7E4
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x0000AD62 File Offset: 0x00008F62
		public unsafe StringBuilder _bannerMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__bannerMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__bannerMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00080614 File Offset: 0x0007E814
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x0000AD81 File Offset: 0x00008F81
		public unsafe StringBuilder _welcomeMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__welcomeMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__welcomeMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x00080644 File Offset: 0x0007E844
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		public unsafe StringBuilder _exitMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__exitMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__exitMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x00080674 File Offset: 0x0007E874
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x0000ADBF File Offset: 0x00008FBF
		public unsafe WeakReference _credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x000806A4 File Offset: 0x0007E8A4
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x0000ADDE File Offset: 0x00008FDE
		public unsafe string _currentTypeSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__currentTypeSetting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__currentTypeSetting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000806CC File Offset: 0x0007E8CC
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x0000ADFD File Offset: 0x00008FFD
		public unsafe long _contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__contentLength)) = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000806F4 File Offset: 0x0007E8F4
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x0000AE18 File Offset: 0x00009018
		public unsafe DateTime _lastModified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__lastModified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__lastModified)) = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0008071C File Offset: 0x0007E91C
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x0000AE33 File Offset: 0x00009033
		public unsafe bool _dataHandshakeStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__dataHandshakeStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__dataHandshakeStarted)) = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x00080744 File Offset: 0x0007E944
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x0000AE4E File Offset: 0x0000904E
		public unsafe string _loginDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__loginDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__loginDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x0008076C File Offset: 0x0007E96C
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x0000AE6D File Offset: 0x0000906D
		public unsafe string _establishedServerDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__establishedServerDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__establishedServerDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x00080794 File Offset: 0x0007E994
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x0000AE8C File Offset: 0x0000908C
		public unsafe string _requestedServerDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__requestedServerDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__requestedServerDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x000807BC File Offset: 0x0007E9BC
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x0000AEAB File Offset: 0x000090AB
		public unsafe Uri _responseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__responseUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__responseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x000807EC File Offset: 0x0007E9EC
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x0000AECA File Offset: 0x000090CA
		public unsafe FtpLoginState _loginState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__loginState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr__loginState)) = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x00080814 File Offset: 0x0007EA14
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x0000AEE5 File Offset: 0x000090E5
		public unsafe FtpStatusCode StatusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr_StatusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr_StatusCode)) = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0008083C File Offset: 0x0007EA3C
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x0000AF00 File Offset: 0x00009100
		public unsafe string StatusLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr_StatusLine);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.NativeFieldInfoPtr_StatusLine), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00080864 File Offset: 0x0007EA64
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x0000AF1F File Offset: 0x0000911F
		public unsafe static AsyncCallback s_acceptCallbackDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpControlStream.NativeFieldInfoPtr_s_acceptCallbackDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpControlStream.NativeFieldInfoPtr_s_acceptCallbackDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x0008088C File Offset: 0x0007EA8C
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x0000AF31 File Offset: 0x00009131
		public unsafe static AsyncCallback s_connectCallbackDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpControlStream.NativeFieldInfoPtr_s_connectCallbackDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpControlStream.NativeFieldInfoPtr_s_connectCallbackDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x000808B4 File Offset: 0x0007EAB4
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x0000AF43 File Offset: 0x00009143
		public unsafe static AsyncCallback s_SSLHandshakeCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpControlStream.NativeFieldInfoPtr_s_SSLHandshakeCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpControlStream.NativeFieldInfoPtr_s_SSLHandshakeCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeFieldInfoPtr__dataSocket;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeFieldInfoPtr__passiveEndPoint;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeFieldInfoPtr__tlsStream;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeFieldInfoPtr__bannerMessage;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeFieldInfoPtr__welcomeMessage;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeFieldInfoPtr__exitMessage;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr__credentials;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeFieldInfoPtr__currentTypeSetting;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeFieldInfoPtr__contentLength;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeFieldInfoPtr__lastModified;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeFieldInfoPtr__dataHandshakeStarted;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeFieldInfoPtr__loginDirectory;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeFieldInfoPtr__establishedServerDirectory;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeFieldInfoPtr__requestedServerDirectory;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeFieldInfoPtr__responseUri;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeFieldInfoPtr__loginState;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeFieldInfoPtr_StatusCode;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeFieldInfoPtr_StatusLine;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeFieldInfoPtr_s_acceptCallbackDelegate;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeFieldInfoPtr_s_connectCallbackDelegate;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeFieldInfoPtr_s_SSLHandshakeCallback;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Internal_get_NetworkCredential_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Internal_set_Void_NetworkCredential_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TcpClient_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_AbortConnect_Internal_Void_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_AcceptCallback_Private_Static_Void_IAsyncResult_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_ConnectCallback_Private_Static_Void_IAsyncResult_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_SSLHandshakeCallback_Private_Static_Void_IAsyncResult_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_QueueOrCreateFtpDataStream_Private_PipelineInstruction_byref_Stream_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Protected_Virtual_Void_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_PipelineCallback_Protected_Virtual_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_BuildCommandsList_Protected_Virtual_Il2CppReferenceArray_1_PipelineEntry_WebRequest_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_QueueOrCreateDataConection_Private_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_byref_Boolean_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_GetPathInfo_Private_Static_Void_GetPathOption_Uri_byref_String_byref_String_byref_String_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Internal_get_Int64_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_get_LastModified_Internal_get_DateTime_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseUri_Internal_get_Uri_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_get_BannerMessage_Internal_get_String_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_get_WelcomeMessage_Internal_get_String_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_get_ExitMessage_Internal_get_String_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_GetContentLengthFrom213Response_Private_Int64_String_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_GetLastModifiedFrom213Response_Private_DateTime_String_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateResponseUri_Private_Void_String_FtpWebRequest_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateContentLength_Private_Void_String_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_GetLoginDirectory_Private_String_String_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_CreateFtpListenerSocket_Private_Void_FtpWebRequest_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_GetPortCommandLine_Private_String_FtpWebRequest_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_FormatFtpCommand_Private_String_String_String_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_CreateFtpDataSocket_Protected_Socket_FtpWebRequest_Socket_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_CheckValid_Protected_Virtual_Boolean_ResponseDescription_byref_Int32_byref_Int32_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_IsFtpDataStreamWriteable_Private_TriState_0;

		// Token: 0x02000316 RID: 790
		public enum GetPathOption
		{
			// Token: 0x04002496 RID: 9366
			Normal,
			// Token: 0x04002497 RID: 9367
			AssumeFilename,
			// Token: 0x04002498 RID: 9368
			AssumeNoFilename
		}

		// Token: 0x02000317 RID: 791
		[ObfuscatedName("System.Net.FtpControlStream+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Object
		{
			// Token: 0x06002E9C RID: 11932 RVA: 0x000CC39C File Offset: 0x000CA59C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<FtpControlStream.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FtpControlStream>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpControlStream.__c__DisplayClass31_0>.NativeClassPtr);
				FtpControlStream.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				FtpControlStream.__c__DisplayClass31_0.NativeFieldInfoPtr_tlsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpControlStream.__c__DisplayClass31_0>.NativeClassPtr, "tlsStream");
				FtpControlStream.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream.__c__DisplayClass31_0>.NativeClassPtr, 100667301);
				FtpControlStream.__c__DisplayClass31_0.NativeMethodInfoPtr__PipelineCallback_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpControlStream.__c__DisplayClass31_0>.NativeClassPtr, 100667302);
			}

			// Token: 0x06002E9D RID: 11933 RVA: 0x000CC418 File Offset: 0x000CA618
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpControlStream.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E9E RID: 11934 RVA: 0x000CC454 File Offset: 0x000CA654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471872, XrefRangeEnd = 471877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PipelineCallback_b__0(IAsyncResult ar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpControlStream.__c__DisplayClass31_0.NativeMethodInfoPtr__PipelineCallback_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E9F RID: 11935 RVA: 0x00014D30 File Offset: 0x00012F30
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E98 RID: 3736
			// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000CC498 File Offset: 0x000CA698
			// (set) Token: 0x06002EA1 RID: 11937 RVA: 0x00014D39 File Offset: 0x00012F39
			public unsafe FtpControlStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpControlStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E99 RID: 3737
			// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x000CC4C8 File Offset: 0x000CA6C8
			// (set) Token: 0x06002EA3 RID: 11939 RVA: 0x00014D58 File Offset: 0x00012F58
			public unsafe TlsStream tlsStream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.__c__DisplayClass31_0.NativeFieldInfoPtr_tlsStream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TlsStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpControlStream.__c__DisplayClass31_0.NativeFieldInfoPtr_tlsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002499 RID: 9369
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400249A RID: 9370
			private static readonly IntPtr NativeFieldInfoPtr_tlsStream;

			// Token: 0x0400249B RID: 9371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400249C RID: 9372
			private static readonly IntPtr NativeMethodInfoPtr__PipelineCallback_b__0_Internal_Void_IAsyncResult_0;
		}
	}
}
