using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E0 RID: 480
	[Serializable]
	public class FileWebRequest : WebRequest
	{
		// Token: 0x06001DCB RID: 7627 RVA: 0x0008FC1C File Offset: 0x0008DE1C
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebRequest()
		{
			Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FileWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr);
			FileWebRequest.NativeFieldInfoPtr_s_GetRequestStreamCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "s_GetRequestStreamCallback");
			FileWebRequest.NativeFieldInfoPtr_s_GetResponseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "s_GetResponseCallback");
			FileWebRequest.NativeFieldInfoPtr_m_connectionGroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_connectionGroupName");
			FileWebRequest.NativeFieldInfoPtr_m_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_contentLength");
			FileWebRequest.NativeFieldInfoPtr_m_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_credentials");
			FileWebRequest.NativeFieldInfoPtr_m_fileAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_fileAccess");
			FileWebRequest.NativeFieldInfoPtr_m_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_headers");
			FileWebRequest.NativeFieldInfoPtr_m_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_method");
			FileWebRequest.NativeFieldInfoPtr_m_preauthenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_preauthenticate");
			FileWebRequest.NativeFieldInfoPtr_m_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_proxy");
			FileWebRequest.NativeFieldInfoPtr_m_readerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_readerEvent");
			FileWebRequest.NativeFieldInfoPtr_m_readPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_readPending");
			FileWebRequest.NativeFieldInfoPtr_m_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_response");
			FileWebRequest.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_stream");
			FileWebRequest.NativeFieldInfoPtr_m_syncHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_syncHint");
			FileWebRequest.NativeFieldInfoPtr_m_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_timeout");
			FileWebRequest.NativeFieldInfoPtr_m_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_uri");
			FileWebRequest.NativeFieldInfoPtr_m_writePending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_writePending");
			FileWebRequest.NativeFieldInfoPtr_m_writing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_writing");
			FileWebRequest.NativeFieldInfoPtr_m_WriteAResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_WriteAResult");
			FileWebRequest.NativeFieldInfoPtr_m_ReadAResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_ReadAResult");
			FileWebRequest.NativeFieldInfoPtr_m_Aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_Aborted");
			FileWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667852);
			FileWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667853);
			FileWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667854);
			FileWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667855);
			FileWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667856);
			FileWebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667857);
			FileWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667858);
			FileWebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667859);
			FileWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667860);
			FileWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667861);
			FileWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667862);
			FileWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667863);
			FileWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667864);
			FileWebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667865);
			FileWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667866);
			FileWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667867);
			FileWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667868);
			FileWebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667869);
			FileWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667870);
			FileWebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667871);
			FileWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667872);
			FileWebRequest.NativeMethodInfoPtr_CanGetRequestStream_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667873);
			FileWebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667874);
			FileWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667875);
			FileWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667876);
			FileWebRequest.NativeMethodInfoPtr_GetRequestStreamCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667877);
			FileWebRequest.NativeMethodInfoPtr_GetResponseCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667878);
			FileWebRequest.NativeMethodInfoPtr_UnblockReader_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667879);
			FileWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667880);
			FileWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100667881);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0009005C File Offset: 0x0008E25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477733, XrefRangeEnd = 477765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x000900A8 File Offset: 0x0008E2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477765, XrefRangeEnd = 477828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0009010C File Offset: 0x0008E30C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00090168 File Offset: 0x0008E368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477828, XrefRangeEnd = 477870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x000901CC File Offset: 0x0008E3CC
		public unsafe bool Aborted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00090208 File Offset: 0x0008E408
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00090258 File Offset: 0x0008E458
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x000902A0 File Offset: 0x0008E4A0
		public unsafe override long ContentLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x000902EC File Offset: 0x0008E4EC
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00090338 File Offset: 0x0008E538
		public unsafe override ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00090388 File Offset: 0x0008E588
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x000903D4 File Offset: 0x0008E5D4
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x00090418 File Offset: 0x0008E618
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477870, XrefRangeEnd = 477882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000929 RID: 2345
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x00090468 File Offset: 0x0008E668
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000904B4 File Offset: 0x0008E6B4
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x00090500 File Offset: 0x0008E700
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00090550 File Offset: 0x0008E750
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x00090598 File Offset: 0x0008E798
		public unsafe override int Timeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x000905E4 File Offset: 0x0008E7E4
		public unsafe override Uri RequestUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00090630 File Offset: 0x0008E830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477882, XrefRangeEnd = 477910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000906A0 File Offset: 0x0008E8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477910, XrefRangeEnd = 477925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00090710 File Offset: 0x0008E910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477925, XrefRangeEnd = 477938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetRequestStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_CanGetRequestStream_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0009074C File Offset: 0x0008E94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477938, XrefRangeEnd = 477947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000907A8 File Offset: 0x0008E9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477947, XrefRangeEnd = 477956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00090804 File Offset: 0x0008EA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477956, XrefRangeEnd = 477980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00090850 File Offset: 0x0008EA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477980, XrefRangeEnd = 477995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRequestStreamCallback(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_GetRequestStreamCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00090888 File Offset: 0x0008EA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477995, XrefRangeEnd = 478014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetResponseCallback(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_GetResponseCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000908C0 File Offset: 0x0008EAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478019, RefRangeEnd = 478020, XrefRangeStart = 478014, XrefRangeEnd = 478019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnblockReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_UnblockReader_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x000908F4 File Offset: 0x0008EAF4
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478020, XrefRangeEnd = 478023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0009093C File Offset: 0x0008EB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478023, XrefRangeEnd = 478053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0000CAA1 File Offset: 0x0000ACA1
		public FileWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00090978 File Offset: 0x0008EB78
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x0000CAAA File Offset: 0x0000ACAA
		public unsafe static WaitCallback s_GetRequestStreamCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileWebRequest.NativeFieldInfoPtr_s_GetRequestStreamCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileWebRequest.NativeFieldInfoPtr_s_GetRequestStreamCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x000909A0 File Offset: 0x0008EBA0
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0000CABC File Offset: 0x0000ACBC
		public unsafe static WaitCallback s_GetResponseCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileWebRequest.NativeFieldInfoPtr_s_GetResponseCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileWebRequest.NativeFieldInfoPtr_s_GetResponseCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x000909C8 File Offset: 0x0008EBC8
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x0000CACE File Offset: 0x0000ACCE
		public unsafe string m_connectionGroupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_connectionGroupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_connectionGroupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x000909F0 File Offset: 0x0008EBF0
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0000CAED File Offset: 0x0000ACED
		public unsafe long m_contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_contentLength)) = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00090A18 File Offset: 0x0008EC18
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x0000CB08 File Offset: 0x0000AD08
		public unsafe ICredentials m_credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x00090A48 File Offset: 0x0008EC48
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x0000CB27 File Offset: 0x0000AD27
		public unsafe FileAccess m_fileAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_fileAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_fileAccess)) = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00090A70 File Offset: 0x0008EC70
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x0000CB42 File Offset: 0x0000AD42
		public unsafe WebHeaderCollection m_headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00090AA0 File Offset: 0x0008ECA0
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0000CB61 File Offset: 0x0000AD61
		public unsafe string m_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00090AC8 File Offset: 0x0008ECC8
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0000CB80 File Offset: 0x0000AD80
		public unsafe bool m_preauthenticate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_preauthenticate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_preauthenticate)) = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00090AF0 File Offset: 0x0008ECF0
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0000CB9B File Offset: 0x0000AD9B
		public unsafe IWebProxy m_proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00090B20 File Offset: 0x0008ED20
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0000CBBA File Offset: 0x0000ADBA
		public unsafe ManualResetEvent m_readerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00090B50 File Offset: 0x0008ED50
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0000CBD9 File Offset: 0x0000ADD9
		public unsafe bool m_readPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readPending)) = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00090B78 File Offset: 0x0008ED78
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		public unsafe WebResponse m_response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00090BA8 File Offset: 0x0008EDA8
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0000CC13 File Offset: 0x0000AE13
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x00090BD8 File Offset: 0x0008EDD8
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0000CC32 File Offset: 0x0000AE32
		public unsafe bool m_syncHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_syncHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_syncHint)) = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00090C00 File Offset: 0x0008EE00
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0000CC4D File Offset: 0x0000AE4D
		public unsafe int m_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_timeout)) = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00090C28 File Offset: 0x0008EE28
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0000CC68 File Offset: 0x0000AE68
		public unsafe Uri m_uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x00090C58 File Offset: 0x0008EE58
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0000CC87 File Offset: 0x0000AE87
		public unsafe bool m_writePending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writePending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writePending)) = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x00090C80 File Offset: 0x0008EE80
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0000CCA2 File Offset: 0x0000AEA2
		public unsafe bool m_writing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writing)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00090CA8 File Offset: 0x0008EEA8
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0000CCBD File Offset: 0x0000AEBD
		public unsafe LazyAsyncResult m_WriteAResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_WriteAResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_WriteAResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00090CD8 File Offset: 0x0008EED8
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		public unsafe LazyAsyncResult m_ReadAResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_ReadAResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_ReadAResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00090D08 File Offset: 0x0008EF08
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0000CCFB File Offset: 0x0000AEFB
		public unsafe int m_Aborted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_Aborted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_Aborted)) = value;
			}
		}

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeFieldInfoPtr_s_GetRequestStreamCallback;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeFieldInfoPtr_s_GetResponseCallback;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeFieldInfoPtr_m_connectionGroupName;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeFieldInfoPtr_m_contentLength;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeFieldInfoPtr_m_credentials;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeFieldInfoPtr_m_fileAccess;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeFieldInfoPtr_m_headers;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr_m_method;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeFieldInfoPtr_m_preauthenticate;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeFieldInfoPtr_m_proxy;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeFieldInfoPtr_m_readerEvent;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeFieldInfoPtr_m_readPending;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeFieldInfoPtr_m_response;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeFieldInfoPtr_m_syncHint;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeFieldInfoPtr_m_timeout;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeFieldInfoPtr_m_uri;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeFieldInfoPtr_m_writePending;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeFieldInfoPtr_m_writing;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteAResult;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadAResult;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeFieldInfoPtr_m_Aborted;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_set_Void_String_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLength_Public_Virtual_set_Void_Int64_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_set_Timeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_CanGetRequestStream_Private_Boolean_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_Stream_IAsyncResult_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStreamCallback_Private_Static_Void_Object_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseCallback_Private_Static_Void_Object_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_UnblockReader_Internal_Void_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;
	}
}
