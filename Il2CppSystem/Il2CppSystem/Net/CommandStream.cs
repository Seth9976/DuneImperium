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
	// Token: 0x02000198 RID: 408
	public class CommandStream : NetworkStreamWrapper
	{
		// Token: 0x060018EE RID: 6382 RVA: 0x0007E3D0 File Offset: 0x0007C5D0
		// Note: this type is marked as 'beforefieldinit'.
		static CommandStream()
		{
			Il2CppClassPointerStore<CommandStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CommandStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandStream>.NativeClassPtr);
			CommandStream.NativeFieldInfoPtr_s_writeCallbackDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "s_writeCallbackDelegate");
			CommandStream.NativeFieldInfoPtr_s_readCallbackDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "s_readCallbackDelegate");
			CommandStream.NativeFieldInfoPtr__recoverableFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_recoverableFailure");
			CommandStream.NativeFieldInfoPtr__request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_request");
			CommandStream.NativeFieldInfoPtr__isAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_isAsync");
			CommandStream.NativeFieldInfoPtr__aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_aborted");
			CommandStream.NativeFieldInfoPtr__commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_commands");
			CommandStream.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_index");
			CommandStream.NativeFieldInfoPtr__doRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_doRead");
			CommandStream.NativeFieldInfoPtr__doSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_doSend");
			CommandStream.NativeFieldInfoPtr__currentResponseDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_currentResponseDescription");
			CommandStream.NativeFieldInfoPtr__abortReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_abortReason");
			CommandStream.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_buffer");
			CommandStream.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_encoding");
			CommandStream.NativeFieldInfoPtr__decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "_decoder");
			CommandStream.NativeMethodInfoPtr__ctor_Internal_Void_TcpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667231);
			CommandStream.NativeMethodInfoPtr_Abort_Internal_Virtual_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667232);
			CommandStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667233);
			CommandStream.NativeMethodInfoPtr_InvokeRequestCallback_Protected_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667234);
			CommandStream.NativeMethodInfoPtr_get_RecoverableFailure_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667235);
			CommandStream.NativeMethodInfoPtr_MarkAsRecoverableFailure_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667236);
			CommandStream.NativeMethodInfoPtr_SubmitRequest_Internal_Stream_WebRequest_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667237);
			CommandStream.NativeMethodInfoPtr_ClearState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667238);
			CommandStream.NativeMethodInfoPtr_BuildCommandsList_Protected_Virtual_New_Il2CppReferenceArray_1_PipelineEntry_WebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667239);
			CommandStream.NativeMethodInfoPtr_GenerateException_Protected_Exception_String_WebExceptionStatus_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667240);
			CommandStream.NativeMethodInfoPtr_GenerateException_Protected_Exception_FtpStatusCode_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667241);
			CommandStream.NativeMethodInfoPtr_InitCommandPipeline_Protected_Void_WebRequest_Il2CppReferenceArray_1_PipelineEntry_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667242);
			CommandStream.NativeMethodInfoPtr_CheckContinuePipeline_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667243);
			CommandStream.NativeMethodInfoPtr_ContinueCommandPipeline_Protected_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667244);
			CommandStream.NativeMethodInfoPtr_PostSendCommandProcessing_Private_Boolean_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667245);
			CommandStream.NativeMethodInfoPtr_PostReadCommandProcessing_Private_Boolean_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667246);
			CommandStream.NativeMethodInfoPtr_PipelineCallback_Protected_Virtual_New_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667247);
			CommandStream.NativeMethodInfoPtr_ReadCallback_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667248);
			CommandStream.NativeMethodInfoPtr_WriteCallback_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667249);
			CommandStream.NativeMethodInfoPtr_get_Encoding_Protected_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667250);
			CommandStream.NativeMethodInfoPtr_set_Encoding_Protected_set_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667251);
			CommandStream.NativeMethodInfoPtr_CheckValid_Protected_Virtual_New_Boolean_ResponseDescription_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667252);
			CommandStream.NativeMethodInfoPtr_ReceiveCommandResponse_Private_ResponseDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667253);
			CommandStream.NativeMethodInfoPtr_ReceiveCommandResponseCallback_Private_Void_ReceiveState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, 100667254);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0007E70C File Offset: 0x0007C90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471609, XrefRangeEnd = 471623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandStream(TcpClient client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr__ctor_Internal_Void_TcpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0007E758 File Offset: 0x0007C958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471623, XrefRangeEnd = 471651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Abort(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandStream.NativeMethodInfoPtr_Abort_Internal_Virtual_New_Void_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0007E7A8 File Offset: 0x0007C9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471651, XrefRangeEnd = 471666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0007E7F4 File Offset: 0x0007C9F4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 471669, RefRangeEnd = 471678, XrefRangeStart = 471666, XrefRangeEnd = 471669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeRequestCallback(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_InvokeRequestCallback_Protected_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0007E838 File Offset: 0x0007CA38
		public unsafe bool RecoverableFailure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_get_RecoverableFailure_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0007E874 File Offset: 0x0007CA74
		[CallerCount(0)]
		public unsafe void MarkAsRecoverableFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_MarkAsRecoverableFailure_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0007E8A8 File Offset: 0x0007CAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471678, XrefRangeEnd = 471680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readInitalResponseOnConnect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_SubmitRequest_Internal_Stream_WebRequest_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0007E914 File Offset: 0x0007CB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471680, XrefRangeEnd = 471681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandStream.NativeMethodInfoPtr_ClearState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0007E950 File Offset: 0x0007CB50
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<CommandStream.PipelineEntry> BuildCommandsList(WebRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandStream.NativeMethodInfoPtr_BuildCommandsList_Protected_Virtual_New_Il2CppReferenceArray_1_PipelineEntry_WebRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CommandStream.PipelineEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0007E9AC File Offset: 0x0007CBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471681, XrefRangeEnd = 471685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GenerateException(string message, WebExceptionStatus status, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_GenerateException_Protected_Exception_String_WebExceptionStatus_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0007EA1C File Offset: 0x0007CC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471685, XrefRangeEnd = 471693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_GenerateException_Protected_Exception_FtpStatusCode_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0007EA8C File Offset: 0x0007CC8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 471699, RefRangeEnd = 471703, XrefRangeStart = 471693, XrefRangeEnd = 471699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitCommandPipeline(WebRequest request, Il2CppReferenceArray<CommandStream.PipelineEntry> commands, bool isAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commands);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_InitCommandPipeline_Protected_Void_WebRequest_Il2CppReferenceArray_1_PipelineEntry_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0007EAF0 File Offset: 0x0007CCF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471705, RefRangeEnd = 471706, XrefRangeStart = 471703, XrefRangeEnd = 471705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckContinuePipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_CheckContinuePipeline_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0007EB24 File Offset: 0x0007CD24
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 471740, RefRangeEnd = 471750, XrefRangeStart = 471706, XrefRangeEnd = 471740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream ContinueCommandPipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_ContinueCommandPipeline_Protected_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0007EB64 File Offset: 0x0007CD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471753, RefRangeEnd = 471754, XrefRangeStart = 471750, XrefRangeEnd = 471753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PostSendCommandProcessing(ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_PostSendCommandProcessing_Private_Boolean_byref_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0007EBC8 File Offset: 0x0007CDC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471763, RefRangeEnd = 471764, XrefRangeStart = 471754, XrefRangeEnd = 471763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PostReadCommandProcessing(ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_PostReadCommandProcessing_Private_Boolean_byref_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0007EC2C File Offset: 0x0007CE2C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandStream.NativeMethodInfoPtr_PipelineCallback_Protected_Virtual_New_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0007ECD0 File Offset: 0x0007CED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471764, XrefRangeEnd = 471772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadCallback(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_ReadCallback_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0007ED08 File Offset: 0x0007CF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471772, XrefRangeEnd = 471781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteCallback(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_WriteCallback_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0007ED40 File Offset: 0x0007CF40
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0007ED80 File Offset: 0x0007CF80
		public unsafe Encoding Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_get_Encoding_Protected_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471781, XrefRangeEnd = 471784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_set_Encoding_Protected_set_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0007EDC4 File Offset: 0x0007CFC4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandStream.NativeMethodInfoPtr_CheckValid_Protected_Virtual_New_Boolean_ResponseDescription_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0007EE38 File Offset: 0x0007D038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471810, RefRangeEnd = 471811, XrefRangeStart = 471784, XrefRangeEnd = 471810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResponseDescription ReceiveCommandResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_ReceiveCommandResponse_Private_ResponseDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseDescription>(intPtr3) : null;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0007EE78 File Offset: 0x0007D078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 471848, RefRangeEnd = 471850, XrefRangeStart = 471811, XrefRangeEnd = 471848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.NativeMethodInfoPtr_ReceiveCommandResponseCallback_Private_Void_ReceiveState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0000AA37 File Offset: 0x00008C37
		public CommandStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0007EEC8 File Offset: 0x0007D0C8
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0000AA40 File Offset: 0x00008C40
		public unsafe static AsyncCallback s_writeCallbackDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandStream.NativeFieldInfoPtr_s_writeCallbackDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandStream.NativeFieldInfoPtr_s_writeCallbackDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0007EEF0 File Offset: 0x0007D0F0
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0000AA52 File Offset: 0x00008C52
		public unsafe static AsyncCallback s_readCallbackDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandStream.NativeFieldInfoPtr_s_readCallbackDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandStream.NativeFieldInfoPtr_s_readCallbackDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0007EF18 File Offset: 0x0007D118
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0000AA64 File Offset: 0x00008C64
		public unsafe bool _recoverableFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__recoverableFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__recoverableFailure)) = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0007EF40 File Offset: 0x0007D140
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0000AA7F File Offset: 0x00008C7F
		public unsafe WebRequest _request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0007EF70 File Offset: 0x0007D170
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x0000AA9E File Offset: 0x00008C9E
		public unsafe bool _isAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__isAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__isAsync)) = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0007EF98 File Offset: 0x0007D198
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x0000AAB9 File Offset: 0x00008CB9
		public unsafe bool _aborted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__aborted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__aborted)) = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x0007EFC0 File Offset: 0x0007D1C0
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public unsafe Il2CppReferenceArray<CommandStream.PipelineEntry> _commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__commands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CommandStream.PipelineEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__commands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0007EFF0 File Offset: 0x0007D1F0
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0000AAF3 File Offset: 0x00008CF3
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0007F018 File Offset: 0x0007D218
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x0000AB0E File Offset: 0x00008D0E
		public unsafe bool _doRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__doRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__doRead)) = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0007F040 File Offset: 0x0007D240
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x0000AB29 File Offset: 0x00008D29
		public unsafe bool _doSend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__doSend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__doSend)) = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0007F068 File Offset: 0x0007D268
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0000AB44 File Offset: 0x00008D44
		public unsafe ResponseDescription _currentResponseDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__currentResponseDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResponseDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__currentResponseDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0007F098 File Offset: 0x0007D298
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0000AB63 File Offset: 0x00008D63
		public unsafe string _abortReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__abortReason);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__abortReason), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0007F0C0 File Offset: 0x0007D2C0
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0000AB82 File Offset: 0x00008D82
		public unsafe string _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__buffer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__buffer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0007F0E8 File Offset: 0x0007D2E8
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x0000ABA1 File Offset: 0x00008DA1
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0007F118 File Offset: 0x0007D318
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public unsafe Decoder _decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.NativeFieldInfoPtr__decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_s_writeCallbackDelegate;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_s_readCallbackDelegate;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr__recoverableFailure;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr__request;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr__isAsync;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeFieldInfoPtr__aborted;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeFieldInfoPtr__commands;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeFieldInfoPtr__doRead;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeFieldInfoPtr__doSend;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr__currentResponseDescription;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr__abortReason;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeFieldInfoPtr__decoder;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TcpClient_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Internal_Virtual_New_Void_Exception_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_InvokeRequestCallback_Protected_Void_Object_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_get_RecoverableFailure_Internal_get_Boolean_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsRecoverableFailure_Protected_Void_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_SubmitRequest_Internal_Stream_WebRequest_Boolean_Boolean_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Protected_Virtual_New_Void_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_BuildCommandsList_Protected_Virtual_New_Il2CppReferenceArray_1_PipelineEntry_WebRequest_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_GenerateException_Protected_Exception_String_WebExceptionStatus_Exception_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_GenerateException_Protected_Exception_FtpStatusCode_String_Exception_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_InitCommandPipeline_Protected_Void_WebRequest_Il2CppReferenceArray_1_PipelineEntry_Boolean_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_CheckContinuePipeline_Internal_Void_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_ContinueCommandPipeline_Protected_Stream_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_PostSendCommandProcessing_Private_Boolean_byref_Stream_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_PostReadCommandProcessing_Private_Boolean_byref_Stream_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_PipelineCallback_Protected_Virtual_New_PipelineInstruction_PipelineEntry_ResponseDescription_Boolean_byref_Stream_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_ReadCallback_Private_Static_Void_IAsyncResult_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_WriteCallback_Private_Static_Void_IAsyncResult_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Protected_get_Encoding_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_set_Encoding_Protected_set_Void_Encoding_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_CheckValid_Protected_Virtual_New_Boolean_ResponseDescription_byref_Int32_byref_Int32_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCommandResponse_Private_ResponseDescription_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCommandResponseCallback_Private_Void_ReceiveState_Int32_0;

		// Token: 0x02000313 RID: 787
		public enum PipelineInstruction
		{
			// Token: 0x04002486 RID: 9350
			Abort,
			// Token: 0x04002487 RID: 9351
			Advance,
			// Token: 0x04002488 RID: 9352
			Pause,
			// Token: 0x04002489 RID: 9353
			Reread,
			// Token: 0x0400248A RID: 9354
			GiveStream
		}

		// Token: 0x02000314 RID: 788
		[Flags]
		public enum PipelineEntryFlags
		{
			// Token: 0x0400248C RID: 9356
			UserCommand = 1,
			// Token: 0x0400248D RID: 9357
			GiveDataStream = 2,
			// Token: 0x0400248E RID: 9358
			CreateDataConnection = 4,
			// Token: 0x0400248F RID: 9359
			DontLogParameter = 8
		}

		// Token: 0x02000315 RID: 789
		public class PipelineEntry : Object
		{
			// Token: 0x06002E93 RID: 11923 RVA: 0x000CC1C8 File Offset: 0x000CA3C8
			// Note: this type is marked as 'beforefieldinit'.
			static PipelineEntry()
			{
				Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandStream>.NativeClassPtr, "PipelineEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr);
				CommandStream.PipelineEntry.NativeFieldInfoPtr_Command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr, "Command");
				CommandStream.PipelineEntry.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr, "Flags");
				CommandStream.PipelineEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr, 100667256);
				CommandStream.PipelineEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_PipelineEntryFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr, 100667257);
				CommandStream.PipelineEntry.NativeMethodInfoPtr_HasFlag_Internal_Boolean_PipelineEntryFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr, 100667258);
			}

			// Token: 0x06002E94 RID: 11924 RVA: 0x000CC258 File Offset: 0x000CA458
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PipelineEntry(string command)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.PipelineEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E95 RID: 11925 RVA: 0x000CC2A4 File Offset: 0x000CA4A4
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PipelineEntry(string command, CommandStream.PipelineEntryFlags flags)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandStream.PipelineEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.PipelineEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_PipelineEntryFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E96 RID: 11926 RVA: 0x000CC300 File Offset: 0x000CA500
			[CallerCount(0)]
			public unsafe bool HasFlag(CommandStream.PipelineEntryFlags flags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref flags;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandStream.PipelineEntry.NativeMethodInfoPtr_HasFlag_Internal_Boolean_PipelineEntryFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E97 RID: 11927 RVA: 0x00014CED File Offset: 0x00012EED
			public PipelineEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E96 RID: 3734
			// (get) Token: 0x06002E98 RID: 11928 RVA: 0x000CC34C File Offset: 0x000CA54C
			// (set) Token: 0x06002E99 RID: 11929 RVA: 0x00014CF6 File Offset: 0x00012EF6
			public unsafe string Command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.PipelineEntry.NativeFieldInfoPtr_Command);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.PipelineEntry.NativeFieldInfoPtr_Command), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E97 RID: 3735
			// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000CC374 File Offset: 0x000CA574
			// (set) Token: 0x06002E9B RID: 11931 RVA: 0x00014D15 File Offset: 0x00012F15
			public unsafe CommandStream.PipelineEntryFlags Flags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.PipelineEntry.NativeFieldInfoPtr_Flags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandStream.PipelineEntry.NativeFieldInfoPtr_Flags)) = value;
				}
			}

			// Token: 0x04002490 RID: 9360
			private static readonly IntPtr NativeFieldInfoPtr_Command;

			// Token: 0x04002491 RID: 9361
			private static readonly IntPtr NativeFieldInfoPtr_Flags;

			// Token: 0x04002492 RID: 9362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

			// Token: 0x04002493 RID: 9363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_PipelineEntryFlags_0;

			// Token: 0x04002494 RID: 9364
			private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Internal_Boolean_PipelineEntryFlags_0;
		}
	}
}
