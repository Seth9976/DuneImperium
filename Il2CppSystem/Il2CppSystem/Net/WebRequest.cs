using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Principal;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class WebRequest : MarshalByRefObject
	{
		// Token: 0x06001C04 RID: 7172 RVA: 0x000896B0 File Offset: 0x000878B0
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequest()
		{
			Il2CppClassPointerStore<WebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest>.NativeClassPtr);
			WebRequest.NativeFieldInfoPtr_s_PrefixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_PrefixList");
			WebRequest.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_InternalSyncObject");
			WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultTimerQueue");
			WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_AuthenticationLevel");
			WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_ImpersonationLevel");
			WebRequest.NativeFieldInfoPtr_m_CachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CachePolicy");
			WebRequest.NativeFieldInfoPtr_m_CacheProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CacheProtocol");
			WebRequest.NativeFieldInfoPtr_m_CacheBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CacheBinding");
			WebRequest.NativeFieldInfoPtr_webRequestCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "webRequestCreate");
			WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultWebProxy");
			WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultWebProxyInitialized");
			WebRequest.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667590);
			WebRequest.NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667591);
			WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667592);
			WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667593);
			WebRequest.NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667594);
			WebRequest.NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667595);
			WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667596);
			WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667597);
			WebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667598);
			WebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667599);
			WebRequest.NativeMethodInfoPtr_get_DefaultCachePolicy_Public_Static_get_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667600);
			WebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667601);
			WebRequest.NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667602);
			WebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667603);
			WebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667604);
			WebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667605);
			WebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667606);
			WebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667607);
			WebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667608);
			WebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667609);
			WebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667610);
			WebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667611);
			WebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667612);
			WebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667613);
			WebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667614);
			WebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667615);
			WebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667616);
			WebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667617);
			WebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667618);
			WebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667619);
			WebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667620);
			WebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667621);
			WebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_New_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667622);
			WebRequest.NativeMethodInfoPtr_GetRequestStreamAsync_Public_Virtual_New_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667623);
			WebRequest.NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667624);
			WebRequest.NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667625);
			WebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667626);
			WebRequest.NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667627);
			WebRequest.NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667628);
			WebRequest.NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667629);
			WebRequest.NativeMethodInfoPtr__GetRequestStreamAsync_b__78_0_Private_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667631);
			WebRequest.NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100667632);
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00089B04 File Offset: 0x00087D04
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 475526, RefRangeEnd = 475528, XrefRangeStart = 475511, XrefRangeEnd = 475526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00089B38 File Offset: 0x00087D38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 475548, RefRangeEnd = 475551, XrefRangeStart = 475528, XrefRangeEnd = 475548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(Uri requestUri, bool useUriBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUriBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00089B8C File Offset: 0x00087D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475565, RefRangeEnd = 475566, XrefRangeStart = 475551, XrefRangeEnd = 475565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(string requestUriString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(requestUriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00089BD0 File Offset: 0x00087DD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475580, RefRangeEnd = 475582, XrefRangeStart = 475566, XrefRangeEnd = 475580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(Uri requestUri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00089C14 File Offset: 0x00087E14
		public unsafe static ArrayList PrefixList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 475609, RefRangeEnd = 475610, XrefRangeStart = 475582, XrefRangeEnd = 475609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00089C48 File Offset: 0x00087E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475655, RefRangeEnd = 475656, XrefRangeStart = 475610, XrefRangeEnd = 475655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayList PopulatePrefixList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00089C7C File Offset: 0x00087E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 475657, RefRangeEnd = 475660, XrefRangeStart = 475656, XrefRangeEnd = 475657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00089CB8 File Offset: 0x00087EB8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00089D1C File Offset: 0x00087F1C
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00089D78 File Offset: 0x00087F78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00089DDC File Offset: 0x00087FDC
		public unsafe static RequestCachePolicy DefaultCachePolicy
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 475666, RefRangeEnd = 475669, XrefRangeStart = 475660, XrefRangeEnd = 475666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_DefaultCachePolicy_Public_Static_get_RequestCachePolicy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr3) : null;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x00089E10 File Offset: 0x00088010
		public unsafe virtual RequestCachePolicy CachePolicy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475669, XrefRangeEnd = 475676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00089E60 File Offset: 0x00088060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetCachePolicy(RequestCachePolicy policy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(policy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00089EA4 File Offset: 0x000880A4
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x00089EE8 File Offset: 0x000880E8
		public unsafe virtual string Method
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475676, XrefRangeEnd = 475679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475679, XrefRangeEnd = 475682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00089F38 File Offset: 0x00088138
		public unsafe virtual Uri RequestUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475682, XrefRangeEnd = 475685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x00089F84 File Offset: 0x00088184
		public unsafe virtual string ConnectionGroupName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475685, XrefRangeEnd = 475688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00089FD4 File Offset: 0x000881D4
		public unsafe virtual WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475688, XrefRangeEnd = 475691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0008A020 File Offset: 0x00088220
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x0008A068 File Offset: 0x00088268
		public unsafe virtual long ContentLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475691, XrefRangeEnd = 475694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475694, XrefRangeEnd = 475697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_ContentLength_Public_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0008A0B4 File Offset: 0x000882B4
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0008A100 File Offset: 0x00088300
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475697, XrefRangeEnd = 475700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475700, XrefRangeEnd = 475703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0008A150 File Offset: 0x00088350
		public unsafe virtual bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475703, XrefRangeEnd = 475706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0008A198 File Offset: 0x00088398
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x0008A1E4 File Offset: 0x000883E4
		public unsafe virtual IWebProxy Proxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475706, XrefRangeEnd = 475709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475709, XrefRangeEnd = 475712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087A RID: 2170
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x0008A234 File Offset: 0x00088434
		public unsafe virtual bool PreAuthenticate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475712, XrefRangeEnd = 475715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0008A280 File Offset: 0x00088480
		// (set) Token: 0x06001C20 RID: 7200 RVA: 0x0008A2C8 File Offset: 0x000884C8
		public unsafe virtual int Timeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475715, XrefRangeEnd = 475718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475718, XrefRangeEnd = 475721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Timeout_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0008A314 File Offset: 0x00088514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475721, XrefRangeEnd = 475724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0008A360 File Offset: 0x00088560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475724, XrefRangeEnd = 475727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginGetResponse(AsyncCallback callback, Object state)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0008A3D0 File Offset: 0x000885D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475727, XrefRangeEnd = 475730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0008A42C File Offset: 0x0008862C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475730, XrefRangeEnd = 475733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, Object state)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0008A49C File Offset: 0x0008869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475733, XrefRangeEnd = 475736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_New_Stream_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0008A4F8 File Offset: 0x000886F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475736, XrefRangeEnd = 475776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Stream> GetRequestStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetRequestStreamAsync_Public_Virtual_New_Task_1_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0008A544 File Offset: 0x00088744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475776, XrefRangeEnd = 475816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<WebResponse> GetResponseAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0008A590 File Offset: 0x00088790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475816, XrefRangeEnd = 475820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity SafeCaptureIdenity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr3) : null;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0008A5D0 File Offset: 0x000887D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475820, XrefRangeEnd = 475823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0008A60C File Offset: 0x0008880C
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0008A64C File Offset: 0x0008884C
		public unsafe RequestCacheProtocol CacheProtocol
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCacheProtocol>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x0008A690 File Offset: 0x00088890
		public unsafe static IWebProxy InternalDefaultWebProxy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 475854, RefRangeEnd = 475855, XrefRangeStart = 475823, XrefRangeEnd = 475854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0008A6C4 File Offset: 0x000888C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475855, XrefRangeEnd = 475869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> _GetRequestStreamAsync_b__78_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__GetRequestStreamAsync_b__78_0_Private_Task_1_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0008A704 File Offset: 0x00088904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475869, XrefRangeEnd = 475883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebResponse> _GetResponseAsync_b__79_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0000BF7E File Offset: 0x0000A17E
		public WebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0008A744 File Offset: 0x00088944
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x0000BF87 File Offset: 0x0000A187
		public unsafe static ArrayList s_PrefixList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_PrefixList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_PrefixList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0008A76C File Offset: 0x0008896C
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x0000BF99 File Offset: 0x0000A199
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0008A794 File Offset: 0x00088994
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x0000BFAB File Offset: 0x0000A1AB
		public unsafe static TimerThread.Queue s_DefaultTimerQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0008A7BC File Offset: 0x000889BC
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0000BFBD File Offset: 0x0000A1BD
		public unsafe AuthenticationLevel m_AuthenticationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel)) = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0008A7E4 File Offset: 0x000889E4
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		public unsafe TokenImpersonationLevel m_ImpersonationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel)) = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0008A80C File Offset: 0x00088A0C
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		public unsafe RequestCachePolicy m_CachePolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CachePolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0008A83C File Offset: 0x00088A3C
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0000C012 File Offset: 0x0000A212
		public unsafe RequestCacheProtocol m_CacheProtocol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheProtocol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheProtocol>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheProtocol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0008A86C File Offset: 0x00088A6C
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x0000C031 File Offset: 0x0000A231
		public unsafe RequestCacheBinding m_CacheBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0008A89C File Offset: 0x00088A9C
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0000C050 File Offset: 0x0000A250
		public unsafe static WebRequest.DesignerWebRequestCreate webRequestCreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_webRequestCreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest.DesignerWebRequestCreate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_webRequestCreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0008A8C4 File Offset: 0x00088AC4
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x0000C062 File Offset: 0x0000A262
		public unsafe static IWebProxy s_DefaultWebProxy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x0008A8EC File Offset: 0x00088AEC
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x0000C074 File Offset: 0x0000A274
		public unsafe static bool s_DefaultWebProxyInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized, (void*)(&value));
			}
		}

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_s_PrefixList;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTimerQueue;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeFieldInfoPtr_m_AuthenticationLevel;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr_m_ImpersonationLevel;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeFieldInfoPtr_m_CachePolicy;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheProtocol;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheBinding;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_webRequestCreate;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultWebProxy;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultWebProxyInitialized;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCachePolicy_Public_Static_get_RequestCachePolicy_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionGroupName_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLength_Public_Virtual_New_set_Void_Int64_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_set_PreAuthenticate_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr_set_Timeout_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetRequestStream_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_EndGetRequestStream_Public_Virtual_New_Stream_IAsyncResult_0;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStreamAsync_Public_Virtual_New_Task_1_Stream_0;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr__GetRequestStreamAsync_b__78_0_Private_Task_1_Stream_0;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0;

		// Token: 0x0200031F RID: 799
		public class DesignerWebRequestCreate : Object
		{
			// Token: 0x06002EBE RID: 11966 RVA: 0x000CC89C File Offset: 0x000CAA9C
			// Note: this type is marked as 'beforefieldinit'.
			static DesignerWebRequestCreate()
			{
				Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "DesignerWebRequestCreate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr);
				WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr, 100667633);
				WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr, 100667634);
			}

			// Token: 0x06002EBF RID: 11967 RVA: 0x000CC8F0 File Offset: 0x000CAAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475446, XrefRangeEnd = 475463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual WebRequest Create(Uri uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
				}
			}

			// Token: 0x06002EC0 RID: 11968 RVA: 0x000CC940 File Offset: 0x000CAB40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DesignerWebRequestCreate()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EC1 RID: 11969 RVA: 0x00014EB1 File Offset: 0x000130B1
			public DesignerWebRequestCreate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040024BF RID: 9407
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;

			// Token: 0x040024C0 RID: 9408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000320 RID: 800
		[ObfuscatedName("System.Net.WebRequest+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Object
		{
			// Token: 0x06002EC2 RID: 11970 RVA: 0x000CC97C File Offset: 0x000CAB7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<WebRequest.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.__c__DisplayClass78_0>.NativeClassPtr);
				WebRequest.__c__DisplayClass78_0.NativeFieldInfoPtr_currentUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass78_0>.NativeClassPtr, "currentUser");
				WebRequest.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass78_0>.NativeClassPtr, "<>4__this");
				WebRequest.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass78_0>.NativeClassPtr, 100667635);
				WebRequest.__c__DisplayClass78_0.NativeMethodInfoPtr__GetRequestStreamAsync_b__1_Internal_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass78_0>.NativeClassPtr, 100667636);
			}

			// Token: 0x06002EC3 RID: 11971 RVA: 0x000CC9F8 File Offset: 0x000CABF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EC4 RID: 11972 RVA: 0x000CCA34 File Offset: 0x000CAC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475463, XrefRangeEnd = 475487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<Stream> _GetRequestStreamAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass78_0.NativeMethodInfoPtr__GetRequestStreamAsync_b__1_Internal_Task_1_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
			}

			// Token: 0x06002EC5 RID: 11973 RVA: 0x00014EBA File Offset: 0x000130BA
			public __c__DisplayClass78_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EA1 RID: 3745
			// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x000CCA74 File Offset: 0x000CAC74
			// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00014EC3 File Offset: 0x000130C3
			public unsafe WindowsIdentity currentUser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass78_0.NativeFieldInfoPtr_currentUser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass78_0.NativeFieldInfoPtr_currentUser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EA2 RID: 3746
			// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x000CCAA4 File Offset: 0x000CACA4
			// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00014EE2 File Offset: 0x000130E2
			public unsafe WebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040024C1 RID: 9409
			private static readonly IntPtr NativeFieldInfoPtr_currentUser;

			// Token: 0x040024C2 RID: 9410
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040024C3 RID: 9411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040024C4 RID: 9412
			private static readonly IntPtr NativeMethodInfoPtr__GetRequestStreamAsync_b__1_Internal_Task_1_Stream_0;
		}

		// Token: 0x02000321 RID: 801
		[ObfuscatedName("System.Net.WebRequest+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Object
		{
			// Token: 0x06002ECA RID: 11978 RVA: 0x000CCAD4 File Offset: 0x000CACD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr);
				WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, "currentUser");
				WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, 100667637);
				WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, 100667638);
			}

			// Token: 0x06002ECB RID: 11979 RVA: 0x000CCB50 File Offset: 0x000CAD50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ECC RID: 11980 RVA: 0x000CCB8C File Offset: 0x000CAD8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475487, XrefRangeEnd = 475511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<WebResponse> _GetResponseAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
			}

			// Token: 0x06002ECD RID: 11981 RVA: 0x00014F01 File Offset: 0x00013101
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EA3 RID: 3747
			// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000CCBCC File Offset: 0x000CADCC
			// (set) Token: 0x06002ECF RID: 11983 RVA: 0x00014F0A File Offset: 0x0001310A
			public unsafe WindowsIdentity currentUser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EA4 RID: 3748
			// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x000CCBFC File Offset: 0x000CADFC
			// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x00014F29 File Offset: 0x00013129
			public unsafe WebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040024C5 RID: 9413
			private static readonly IntPtr NativeFieldInfoPtr_currentUser;

			// Token: 0x040024C6 RID: 9414
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040024C7 RID: 9415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040024C8 RID: 9416
			private static readonly IntPtr NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0;
		}
	}
}
