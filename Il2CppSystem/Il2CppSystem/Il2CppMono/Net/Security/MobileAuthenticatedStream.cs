using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001A RID: 26
	public class MobileAuthenticatedStream : AuthenticatedStream
	{
		// Token: 0x06000129 RID: 297 RVA: 0x0001F1CC File Offset: 0x0001D3CC
		// Note: this type is marked as 'beforefieldinit'.
		static MobileAuthenticatedStream()
		{
			Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MobileAuthenticatedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr);
			MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "xobileTlsContext");
			MobileAuthenticatedStream.NativeFieldInfoPtr_lastException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "lastException");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncHandshakeRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncReadRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncWriteRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "readBuffer");
			MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "writeBuffer");
			MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "ioLock");
			MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "closeRequested");
			MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "shutdown");
			MobileAuthenticatedStream.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "operation");
			MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "uniqueNameInteger");
			MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<SslStream>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<Settings>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<Provider>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr__TargetHost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<TargetHost>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "nextId");
			MobileAuthenticatedStream.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "ID");
			MobileAuthenticatedStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663519);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_SslStream_Public_Virtual_Final_New_get_SslStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663520);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663521);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Provider_Public_get_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663522);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_TargetHost_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663523);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_TargetHost_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663524);
			MobileAuthenticatedStream.NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663525);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663526);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663527);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetInternalError_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663528);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetInvalidNestedCallException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663529);
			MobileAuthenticatedStream.NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663530);
			MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Void_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663531);
			MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsServer_Public_Void_X509Certificate_Boolean_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663532);
			MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663533);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_MonoSslAuthenticationOptions_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663534);
			MobileAuthenticatedStream.NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_MonoSslAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663535);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663536);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663537);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663538);
			MobileAuthenticatedStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663539);
			MobileAuthenticatedStream.NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663540);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663541);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663542);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663543);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663544);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663545);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663546);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663547);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663548);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663549);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663550);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663551);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663552);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_LocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663553);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663554);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663555);
			MobileAuthenticatedStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663556);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663557);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanTimeout_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663558);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663559);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663560);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663561);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663562);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663563);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663564);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663565);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663566);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_WriteTimeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663567);
			MobileAuthenticatedStream.NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663569);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0001F74C File Offset: 0x0001D94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428325, RefRangeEnd = 428326, XrefRangeStart = 428303, XrefRangeEnd = 428325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0001F7E0 File Offset: 0x0001D9E0
		public unsafe virtual SslStream SslStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_SslStream_Public_Virtual_Final_New_get_SslStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr3) : null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0001F820 File Offset: 0x0001DA20
		public unsafe MonoTlsSettings Settings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0001F860 File Offset: 0x0001DA60
		public unsafe MobileTlsProvider Provider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_Provider_Public_get_MobileTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr3) : null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0001F8A0 File Offset: 0x0001DAA0
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		public unsafe string TargetHost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_TargetHost_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_set_TargetHost_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001F91C File Offset: 0x0001DB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428327, RefRangeEnd = 428328, XrefRangeStart = 428326, XrefRangeEnd = 428327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref authSuccessCheck;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shutdownCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001F968 File Offset: 0x0001DB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428339, RefRangeEnd = 428340, XrefRangeStart = 428328, XrefRangeEnd = 428339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetSSPIException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0001F9AC File Offset: 0x0001DBAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428350, RefRangeEnd = 428353, XrefRangeStart = 428340, XrefRangeEnd = 428350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetIOException(Exception e, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0001FA04 File Offset: 0x0001DC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428353, XrefRangeEnd = 428359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInternalError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetInternalError_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001FA38 File Offset: 0x0001DC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428359, XrefRangeEnd = 428365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidNestedCallException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetInvalidNestedCallException_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 428367, RefRangeEnd = 428372, XrefRangeStart = 428365, XrefRangeEnd = 428367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo SetException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0001FABC File Offset: 0x0001DCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428387, RefRangeEnd = 428388, XrefRangeStart = 428372, XrefRangeEnd = 428387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Void_String_X509CertificateCollection_SslProtocols_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001FB2C File Offset: 0x0001DD2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428403, RefRangeEnd = 428404, XrefRangeStart = 428388, XrefRangeEnd = 428403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientCertificateRequired;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsServer_Public_Void_X509Certificate_Boolean_SslProtocols_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0001FB98 File Offset: 0x0001DD98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428418, RefRangeEnd = 428420, XrefRangeStart = 428404, XrefRangeEnd = 428418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001FC18 File Offset: 0x0001DE18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428432, RefRangeEnd = 428435, XrefRangeStart = 428420, XrefRangeEnd = 428432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref runSynchronously;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_MonoSslAuthenticationOptions_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001FC90 File Offset: 0x0001DE90
		[CallerCount(0)]
		public unsafe virtual MobileTlsContext CreateContext(MonoSslAuthenticationOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_MonoSslAuthenticationOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr3) : null;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001FCEC File Offset: 0x0001DEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428435, XrefRangeEnd = 428448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001FD60 File Offset: 0x0001DF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428448, XrefRangeEnd = 428461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001FDCC File Offset: 0x0001DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428461, XrefRangeEnd = 428466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0001FE5C File Offset: 0x0001E05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428466, XrefRangeEnd = 428471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 428487, RefRangeEnd = 428491, XrefRangeStart = 428471, XrefRangeEnd = 428487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001FF64 File Offset: 0x0001E164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428510, RefRangeEnd = 428512, XrefRangeStart = 428491, XrefRangeEnd = 428510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalRead(Il2CppStructArray<byte> buffer, int offset, int size, out bool outWantMore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outWantMore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428512, XrefRangeEnd = 428517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00020064 File Offset: 0x0001E264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428526, RefRangeEnd = 428528, XrefRangeStart = 428517, XrefRangeEnd = 428526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWrite(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000200D0 File Offset: 0x0001E2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428532, RefRangeEnd = 428533, XrefRangeStart = 428528, XrefRangeEnd = 428532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00020160 File Offset: 0x0001E360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428533, XrefRangeEnd = 428548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sync;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000201D4 File Offset: 0x0001E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428548, XrefRangeEnd = 428559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InnerWrite(bool sync, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sync;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00020238 File Offset: 0x0001E438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428570, RefRangeEnd = 428571, XrefRangeStart = 428559, XrefRangeEnd = 428570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renegotiate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00020290 File Offset: 0x0001E490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428576, RefRangeEnd = 428577, XrefRangeStart = 428571, XrefRangeEnd = 428576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, bool>(intPtr);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000202D8 File Offset: 0x0001E4D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428582, RefRangeEnd = 428583, XrefRangeStart = 428577, XrefRangeEnd = 428582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, bool>(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00020320 File Offset: 0x0001E520
		public unsafe override bool IsAuthenticated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428583, XrefRangeEnd = 428587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00020368 File Offset: 0x0001E568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428587, XrefRangeEnd = 428606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000203B4 File Offset: 0x0001E5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000203F0 File Offset: 0x0001E5F0
		public unsafe virtual X509Certificate LocalCertificate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 428612, RefRangeEnd = 428613, XrefRangeStart = 428606, XrefRangeEnd = 428612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_LocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00020430 File Offset: 0x0001E630
		public unsafe virtual X509Certificate InternalLocalCertificate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 428621, RefRangeEnd = 428622, XrefRangeStart = 428613, XrefRangeEnd = 428621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00020470 File Offset: 0x0001E670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428622, XrefRangeEnd = 428627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000204D4 File Offset: 0x0001E6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLength(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00020520 File Offset: 0x0001E720
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00020568 File Offset: 0x0001E768
		public unsafe override bool CanTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428627, XrefRangeEnd = 428628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanTimeout_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000205B0 File Offset: 0x0001E7B0
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000205F8 File Offset: 0x0001E7F8
		public unsafe override bool CanSeek
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00020640 File Offset: 0x0001E840
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00020688 File Offset: 0x0001E888
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000206D0 File Offset: 0x0001E8D0
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428628, XrefRangeEnd = 428633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0002071C File Offset: 0x0001E91C
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00020764 File Offset: 0x0001E964
		public unsafe override int ReadTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428633, XrefRangeEnd = 428634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428634, XrefRangeEnd = 428635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000207B0 File Offset: 0x0001E9B0
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000207F8 File Offset: 0x0001E9F8
		public unsafe override int WriteTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428635, XrefRangeEnd = 428636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428636, XrefRangeEnd = 428637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_set_WriteTimeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00020844 File Offset: 0x0001EA44
		[CallerCount(0)]
		public unsafe void _InnerWrite_b__67_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002795 File Offset: 0x00000995
		public MobileAuthenticatedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00020878 File Offset: 0x0001EA78
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000279E File Offset: 0x0000099E
		public unsafe MobileTlsContext xobileTlsContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000208A8 File Offset: 0x0001EAA8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000027BD File Offset: 0x000009BD
		public unsafe ExceptionDispatchInfo lastException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_lastException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_lastException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000208D8 File Offset: 0x0001EAD8
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000027DC File Offset: 0x000009DC
		public unsafe AsyncProtocolRequest asyncHandshakeRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00020908 File Offset: 0x0001EB08
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000027FB File Offset: 0x000009FB
		public unsafe AsyncProtocolRequest asyncReadRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00020938 File Offset: 0x0001EB38
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000281A File Offset: 0x00000A1A
		public unsafe AsyncProtocolRequest asyncWriteRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00020968 File Offset: 0x0001EB68
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002839 File Offset: 0x00000A39
		public unsafe BufferOffsetSize2 readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00020998 File Offset: 0x0001EB98
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002858 File Offset: 0x00000A58
		public unsafe BufferOffsetSize2 writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000209C8 File Offset: 0x0001EBC8
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002877 File Offset: 0x00000A77
		public unsafe Object ioLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000209F8 File Offset: 0x0001EBF8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002896 File Offset: 0x00000A96
		public unsafe int closeRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00020A20 File Offset: 0x0001EC20
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000028B1 File Offset: 0x00000AB1
		public unsafe bool shutdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00020A48 File Offset: 0x0001EC48
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000028CC File Offset: 0x00000ACC
		public unsafe MobileAuthenticatedStream.Operation operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_operation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_operation)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00020A70 File Offset: 0x0001EC70
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000028E7 File Offset: 0x00000AE7
		public unsafe static int uniqueNameInteger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger, (void*)(&value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00020A8C File Offset: 0x0001EC8C
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000028F5 File Offset: 0x00000AF5
		public unsafe SslStream _SslStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00020ABC File Offset: 0x0001ECBC
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002914 File Offset: 0x00000B14
		public unsafe MonoTlsSettings _Settings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00020AEC File Offset: 0x0001ECEC
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002933 File Offset: 0x00000B33
		public unsafe MobileTlsProvider _Provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00020B1C File Offset: 0x0001ED1C
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002952 File Offset: 0x00000B52
		public unsafe string _TargetHost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__TargetHost_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__TargetHost_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00020B44 File Offset: 0x0001ED44
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002971 File Offset: 0x00000B71
		public unsafe static int nextId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MobileAuthenticatedStream.NativeFieldInfoPtr_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MobileAuthenticatedStream.NativeFieldInfoPtr_nextId, (void*)(&value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00020B60 File Offset: 0x0001ED60
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000297F File Offset: 0x00000B7F
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_xobileTlsContext;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_lastException;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_asyncHandshakeRequest;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_asyncReadRequest;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_asyncWriteRequest;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_ioLock;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_closeRequested;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_shutdown;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_operation;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_uniqueNameInteger;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr__SslStream_k__BackingField;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr__Settings_k__BackingField;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr__TargetHost_k__BackingField;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_nextId;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_SslStream_Public_Virtual_Final_New_get_SslStream_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Public_get_MobileTlsProvider_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetHost_Internal_get_String_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetHost_Private_set_Void_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalError_Internal_Static_Exception_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidNestedCallException_Internal_Static_Exception_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClient_Public_Void_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsServer_Public_Void_X509Certificate_Boolean_SslProtocols_Boolean_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_MonoSslAuthenticationOptions_CancellationToken_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_MonoSslAuthenticationOptions_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_Boolean_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTimeout_Public_Virtual_get_Boolean_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_set_WriteTimeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0;

		// Token: 0x0200029B RID: 667
		public enum Operation
		{
			// Token: 0x04002177 RID: 8567
			None,
			// Token: 0x04002178 RID: 8568
			Handshake,
			// Token: 0x04002179 RID: 8569
			Authenticated,
			// Token: 0x0400217A RID: 8570
			Renegotiate,
			// Token: 0x0400217B RID: 8571
			Read,
			// Token: 0x0400217C RID: 8572
			Write,
			// Token: 0x0400217D RID: 8573
			Close
		}

		// Token: 0x0200029C RID: 668
		public enum OperationType
		{
			// Token: 0x0400217F RID: 8575
			Read,
			// Token: 0x04002180 RID: 8576
			Write,
			// Token: 0x04002181 RID: 8577
			Renegotiate,
			// Token: 0x04002182 RID: 8578
			Shutdown
		}

		// Token: 0x0200029D RID: 669
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<ProcessAuthentication>d__48")]
		public sealed class _ProcessAuthentication_d__48 : ValueType
		{
			// Token: 0x06002A52 RID: 10834 RVA: 0x000BDE58 File Offset: 0x000BC058
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessAuthentication_d__48()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<ProcessAuthentication>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr);
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, "options");
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_runSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, "runSynchronously");
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, 100663570);
				MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr, 100663571);
			}

			// Token: 0x06002A53 RID: 10835 RVA: 0x000BDF38 File Offset: 0x000BC138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428085, XrefRangeEnd = 428150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A54 RID: 10836 RVA: 0x000BDF70 File Offset: 0x000BC170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428150, XrefRangeEnd = 428154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A55 RID: 10837 RVA: 0x00012986 File Offset: 0x00010B86
			public _ProcessAuthentication_d__48(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A56 RID: 10838 RVA: 0x0001298F File Offset: 0x00010B8F
			public _ProcessAuthentication_d__48()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__48>.NativeClassPtr))
			{
			}

			// Token: 0x17000D63 RID: 3427
			// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000BDFB8 File Offset: 0x000BC1B8
			// (set) Token: 0x06002A58 RID: 10840 RVA: 0x000129A1 File Offset: 0x00010BA1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D64 RID: 3428
			// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000BDFE0 File Offset: 0x000BC1E0
			// (set) Token: 0x06002A5A RID: 10842 RVA: 0x000129BC File Offset: 0x00010BBC
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x06002A5B RID: 10843 RVA: 0x000BE010 File Offset: 0x000BC210
			// (set) Token: 0x06002A5C RID: 10844 RVA: 0x000129EA File Offset: 0x00010BEA
			public unsafe MonoSslAuthenticationOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoSslAuthenticationOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D66 RID: 3430
			// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000BE040 File Offset: 0x000BC240
			// (set) Token: 0x06002A5E RID: 10846 RVA: 0x00012A09 File Offset: 0x00010C09
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x06002A5F RID: 10847 RVA: 0x000BE070 File Offset: 0x000BC270
			// (set) Token: 0x06002A60 RID: 10848 RVA: 0x00012A28 File Offset: 0x00010C28
			public unsafe bool runSynchronously
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_runSynchronously);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_runSynchronously)) = value;
				}
			}

			// Token: 0x17000D68 RID: 3432
			// (get) Token: 0x06002A61 RID: 10849 RVA: 0x000BE098 File Offset: 0x000BC298
			// (set) Token: 0x06002A62 RID: 10850 RVA: 0x00012A43 File Offset: 0x00010C43
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x06002A63 RID: 10851 RVA: 0x000BE0C8 File Offset: 0x000BC2C8
			// (set) Token: 0x06002A64 RID: 10852 RVA: 0x00012A71 File Offset: 0x00010C71
			public ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__48.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002183 RID: 8579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002184 RID: 8580
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002185 RID: 8581
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04002186 RID: 8582
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002187 RID: 8583
			private static readonly IntPtr NativeFieldInfoPtr_runSynchronously;

			// Token: 0x04002188 RID: 8584
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002189 RID: 8585
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400218A RID: 8586
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400218B RID: 8587
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200029E RID: 670
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<StartOperation>d__57")]
		public sealed class _StartOperation_d__57 : ValueType
		{
			// Token: 0x06002A65 RID: 10853 RVA: 0x000BE0F8 File Offset: 0x000BC2F8
			// Note: this type is marked as 'beforefieldinit'.
			static _StartOperation_d__57()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<StartOperation>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr);
				MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, "type");
				MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_asyncRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, "asyncRequest");
				MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._StartOperation_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, 100663572);
				MobileAuthenticatedStream._StartOperation_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr, 100663573);
			}

			// Token: 0x06002A66 RID: 10854 RVA: 0x000BE1D8 File Offset: 0x000BC3D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428154, XrefRangeEnd = 428211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._StartOperation_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A67 RID: 10855 RVA: 0x000BE210 File Offset: 0x000BC410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428211, XrefRangeEnd = 428217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._StartOperation_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A68 RID: 10856 RVA: 0x00012A9F File Offset: 0x00010C9F
			public _StartOperation_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A69 RID: 10857 RVA: 0x00012AA8 File Offset: 0x00010CA8
			public _StartOperation_d__57()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__57>.NativeClassPtr))
			{
			}

			// Token: 0x17000D6A RID: 3434
			// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000BE258 File Offset: 0x000BC458
			// (set) Token: 0x06002A6B RID: 10859 RVA: 0x00012ABA File Offset: 0x00010CBA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x06002A6C RID: 10860 RVA: 0x000BE280 File Offset: 0x000BC480
			// (set) Token: 0x06002A6D RID: 10861 RVA: 0x00012AD5 File Offset: 0x00010CD5
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D6C RID: 3436
			// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000BE2B0 File Offset: 0x000BC4B0
			// (set) Token: 0x06002A6F RID: 10863 RVA: 0x00012B03 File Offset: 0x00010D03
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000BE2E0 File Offset: 0x000BC4E0
			// (set) Token: 0x06002A71 RID: 10865 RVA: 0x00012B22 File Offset: 0x00010D22
			public unsafe MobileAuthenticatedStream.OperationType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17000D6E RID: 3438
			// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000BE308 File Offset: 0x000BC508
			// (set) Token: 0x06002A73 RID: 10867 RVA: 0x00012B3D File Offset: 0x00010D3D
			public unsafe AsyncProtocolRequest asyncRequest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_asyncRequest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_asyncRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6F RID: 3439
			// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000BE338 File Offset: 0x000BC538
			// (set) Token: 0x06002A75 RID: 10869 RVA: 0x00012B5C File Offset: 0x00010D5C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D70 RID: 3440
			// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000BE368 File Offset: 0x000BC568
			// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00012B8A File Offset: 0x00010D8A
			public ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__57.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400218C RID: 8588
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400218D RID: 8589
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400218E RID: 8590
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400218F RID: 8591
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04002190 RID: 8592
			private static readonly IntPtr NativeFieldInfoPtr_asyncRequest;

			// Token: 0x04002191 RID: 8593
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002192 RID: 8594
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002193 RID: 8595
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002194 RID: 8596
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200029F RID: 671
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Object
		{
			// Token: 0x06002A78 RID: 10872 RVA: 0x000BE398 File Offset: 0x000BC598
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr);
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, "len");
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, 100663574);
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, 100663575);
			}

			// Token: 0x06002A79 RID: 10873 RVA: 0x000BE414 File Offset: 0x000BC614
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A7A RID: 10874 RVA: 0x000BE450 File Offset: 0x000BC650
			[CallerCount(0)]
			public unsafe int _InnerRead_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A7B RID: 10875 RVA: 0x00012BB8 File Offset: 0x00010DB8
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D71 RID: 3441
			// (get) Token: 0x06002A7C RID: 10876 RVA: 0x000BE48C File Offset: 0x000BC68C
			// (set) Token: 0x06002A7D RID: 10877 RVA: 0x00012BC1 File Offset: 0x00010DC1
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D72 RID: 3442
			// (get) Token: 0x06002A7E RID: 10878 RVA: 0x000BE4BC File Offset: 0x000BC6BC
			// (set) Token: 0x06002A7F RID: 10879 RVA: 0x00012BE0 File Offset: 0x00010DE0
			public unsafe int len
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len)) = value;
				}
			}

			// Token: 0x04002195 RID: 8597
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002196 RID: 8598
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x04002197 RID: 8599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002198 RID: 8600
			private static readonly IntPtr NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0;
		}

		// Token: 0x020002A0 RID: 672
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<InnerRead>d__66")]
		public sealed class _InnerRead_d__66 : ValueType
		{
			// Token: 0x06002A80 RID: 10880 RVA: 0x000BE4E4 File Offset: 0x000BC6E4
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerRead_d__66()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<InnerRead>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr);
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "requestedSize");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "sync");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, 100663576);
				MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, 100663577);
			}

			// Token: 0x06002A81 RID: 10881 RVA: 0x000BE5C4 File Offset: 0x000BC7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428217, XrefRangeEnd = 428261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A82 RID: 10882 RVA: 0x000BE5FC File Offset: 0x000BC7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428261, XrefRangeEnd = 428267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A83 RID: 10883 RVA: 0x00012BFB File Offset: 0x00010DFB
			public _InnerRead_d__66(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A84 RID: 10884 RVA: 0x00012C04 File Offset: 0x00010E04
			public _InnerRead_d__66()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr))
			{
			}

			// Token: 0x17000D73 RID: 3443
			// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000BE644 File Offset: 0x000BC844
			// (set) Token: 0x06002A86 RID: 10886 RVA: 0x00012C16 File Offset: 0x00010E16
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D74 RID: 3444
			// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000BE66C File Offset: 0x000BC86C
			// (set) Token: 0x06002A88 RID: 10888 RVA: 0x00012C31 File Offset: 0x00010E31
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D75 RID: 3445
			// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000BE69C File Offset: 0x000BC89C
			// (set) Token: 0x06002A8A RID: 10890 RVA: 0x00012C5F File Offset: 0x00010E5F
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D76 RID: 3446
			// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000BE6CC File Offset: 0x000BC8CC
			// (set) Token: 0x06002A8C RID: 10892 RVA: 0x00012C7E File Offset: 0x00010E7E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D77 RID: 3447
			// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000BE6FC File Offset: 0x000BC8FC
			// (set) Token: 0x06002A8E RID: 10894 RVA: 0x00012CAC File Offset: 0x00010EAC
			public unsafe int requestedSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize)) = value;
				}
			}

			// Token: 0x17000D78 RID: 3448
			// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000BE724 File Offset: 0x000BC924
			// (set) Token: 0x06002A90 RID: 10896 RVA: 0x00012CC7 File Offset: 0x00010EC7
			public unsafe bool sync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync)) = value;
				}
			}

			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000BE74C File Offset: 0x000BC94C
			// (set) Token: 0x06002A92 RID: 10898 RVA: 0x00012CE2 File Offset: 0x00010EE2
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002199 RID: 8601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400219A RID: 8602
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400219B RID: 8603
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400219C RID: 8604
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400219D RID: 8605
			private static readonly IntPtr NativeFieldInfoPtr_requestedSize;

			// Token: 0x0400219E RID: 8606
			private static readonly IntPtr NativeFieldInfoPtr_sync;

			// Token: 0x0400219F RID: 8607
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021A0 RID: 8608
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021A1 RID: 8609
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A1 RID: 673
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<InnerWrite>d__67")]
		public sealed class _InnerWrite_d__67 : ValueType
		{
			// Token: 0x06002A93 RID: 10899 RVA: 0x000BE77C File Offset: 0x000BC97C
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerWrite_d__67()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<InnerWrite>d__67");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr);
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "sync");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, 100663578);
				MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, 100663579);
			}

			// Token: 0x06002A94 RID: 10900 RVA: 0x000BE848 File Offset: 0x000BCA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428267, XrefRangeEnd = 428299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A95 RID: 10901 RVA: 0x000BE880 File Offset: 0x000BCA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428299, XrefRangeEnd = 428303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A96 RID: 10902 RVA: 0x00012D10 File Offset: 0x00010F10
			public _InnerWrite_d__67(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A97 RID: 10903 RVA: 0x00012D19 File Offset: 0x00010F19
			public _InnerWrite_d__67()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr))
			{
			}

			// Token: 0x17000D7A RID: 3450
			// (get) Token: 0x06002A98 RID: 10904 RVA: 0x000BE8C8 File Offset: 0x000BCAC8
			// (set) Token: 0x06002A99 RID: 10905 RVA: 0x00012D2B File Offset: 0x00010F2B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D7B RID: 3451
			// (get) Token: 0x06002A9A RID: 10906 RVA: 0x000BE8F0 File Offset: 0x000BCAF0
			// (set) Token: 0x06002A9B RID: 10907 RVA: 0x00012D46 File Offset: 0x00010F46
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D7C RID: 3452
			// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000BE920 File Offset: 0x000BCB20
			// (set) Token: 0x06002A9D RID: 10909 RVA: 0x00012D74 File Offset: 0x00010F74
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D7D RID: 3453
			// (get) Token: 0x06002A9E RID: 10910 RVA: 0x000BE950 File Offset: 0x000BCB50
			// (set) Token: 0x06002A9F RID: 10911 RVA: 0x00012DA2 File Offset: 0x00010FA2
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7E RID: 3454
			// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000BE980 File Offset: 0x000BCB80
			// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x00012DC1 File Offset: 0x00010FC1
			public unsafe bool sync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync)) = value;
				}
			}

			// Token: 0x17000D7F RID: 3455
			// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x000BE9A8 File Offset: 0x000BCBA8
			// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x00012DDC File Offset: 0x00010FDC
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021A2 RID: 8610
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021A3 RID: 8611
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021A4 RID: 8612
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040021A5 RID: 8613
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021A6 RID: 8614
			private static readonly IntPtr NativeFieldInfoPtr_sync;

			// Token: 0x040021A7 RID: 8615
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021A8 RID: 8616
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021A9 RID: 8617
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
