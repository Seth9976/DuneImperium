using System;
using Google.Apis.Discovery;
using Google.Apis.Logging;
using Google.Apis.Requests.Parameters;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Requests
{
	// Token: 0x02000010 RID: 16
	public class ClientServiceRequest<TResponse> : ClientServiceRequest
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00009514 File Offset: 0x00007714
		// Note: this type is marked as 'beforefieldinit'.
		static ClientServiceRequest()
		{
			Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "ClientServiceRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr);
			ClientServiceRequest<TResponse>.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "Logger");
			ClientServiceRequest<TResponse>.NativeFieldInfoPtr_service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "service");
			ClientServiceRequest<TResponse>.NativeFieldInfoPtr__ETagAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ETagAction>k__BackingField");
			ClientServiceRequest<TResponse>.NativeFieldInfoPtr__ModifyRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ModifyRequest>k__BackingField");
			ClientServiceRequest<TResponse>.NativeFieldInfoPtr__RequestParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<RequestParameters>k__BackingField");
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_ETagAction_Public_get_ETagAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663548);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_set_ETagAction_Public_set_Void_ETagAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663549);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_ModifyRequest_Public_get_Action_1_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663550);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_set_ModifyRequest_Public_set_Void_Action_1_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663551);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663552);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_RestPath_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663553);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_HttpMethod_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663554);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_RequestParameters_Public_Virtual_Final_New_get_IDictionary_2_String_IParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663555);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_set_RequestParameters_Private_set_Void_IDictionary_2_String_IParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663556);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_Service_Public_Virtual_Final_New_get_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663557);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663558);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_InitParameters_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663559);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663560);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsStream_Public_Virtual_Final_New_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663561);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Virtual_Final_New_Task_1_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663562);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Virtual_Final_New_Task_1_TResponse_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663563);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Virtual_Final_New_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663564);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Virtual_Final_New_Task_1_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663565);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteUnparsedAsync_Private_Task_1_HttpResponseMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663566);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ParseResponse_Private_Task_1_TResponse_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663567);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_CreateRequest_Public_Virtual_Final_New_HttpRequestMessage_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663568);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_CreateBuilder_Private_RequestBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663569);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_GenerateRequestUri_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663570);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_GetBody_Protected_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663571);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_AddETag_Private_Void_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663572);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_GetDefaultETagAction_Public_Static_ETagAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663573);
			ClientServiceRequest<TResponse>.NativeMethodInfoPtr_AddParameters_Private_Void_RequestBuilder_ParameterCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, 100663574);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00009800 File Offset: 0x00007A00
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000983C File Offset: 0x00007A3C
		public unsafe ETagAction ETagAction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_ETagAction_Public_get_ETagAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_set_ETagAction_Public_set_Void_ETagAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000987C File Offset: 0x00007A7C
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000098BC File Offset: 0x00007ABC
		public unsafe Action<HttpRequestMessage> ModifyRequest
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_ModifyRequest_Public_get_Action_1_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<HttpRequestMessage>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_set_ModifyRequest_Public_set_Void_Action_1_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00009900 File Offset: 0x00007B00
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00009944 File Offset: 0x00007B44
		public unsafe virtual string RestPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_RestPath_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00009988 File Offset: 0x00007B88
		public unsafe virtual string HttpMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_HttpMethod_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000099CC File Offset: 0x00007BCC
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00009A0C File Offset: 0x00007C0C
		public unsafe virtual IDictionary<string, IParameter> RequestParameters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_RequestParameters_Public_Virtual_Final_New_get_IDictionary_2_String_IParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, IParameter>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_set_RequestParameters_Private_set_Void_IDictionary_2_String_IParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00009A50 File Offset: 0x00007C50
		public unsafe virtual IClientService Service
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_get_Service_Public_Virtual_Final_New_get_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr3) : null;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00009A90 File Offset: 0x00007C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464354, RefRangeEnd = 464355, XrefRangeStart = 464354, XrefRangeEnd = 464355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientServiceRequest(IClientService service)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00009ADC File Offset: 0x00007CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198177, RefRangeEnd = 1198178, XrefRangeStart = 1198164, XrefRangeEnd = 1198177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientServiceRequest<TResponse>.NativeMethodInfoPtr_InitParameters_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00009B18 File Offset: 0x00007D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198178, XrefRangeEnd = 1198198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TResponse Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResponse>(intPtr, false, true);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00009B54 File Offset: 0x00007D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198198, XrefRangeEnd = 1198210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Stream ExecuteAsStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsStream_Public_Virtual_Final_New_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009B94 File Offset: 0x00007D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1198217, RefRangeEnd = 1198219, XrefRangeStart = 1198210, XrefRangeEnd = 1198217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<TResponse> ExecuteAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Virtual_Final_New_Task_1_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResponse>>(intPtr3) : null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00009BD4 File Offset: 0x00007DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198227, RefRangeEnd = 1198228, XrefRangeStart = 1198219, XrefRangeEnd = 1198227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<TResponse> ExecuteAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Virtual_Final_New_Task_1_TResponse_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00009C2C File Offset: 0x00007E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198228, XrefRangeEnd = 1198240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Stream> ExecuteAsStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Virtual_Final_New_Task_1_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009C6C File Offset: 0x00007E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198253, RefRangeEnd = 1198254, XrefRangeStart = 1198240, XrefRangeEnd = 1198253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Virtual_Final_New_Task_1_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00009CC4 File Offset: 0x00007EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1198267, RefRangeEnd = 1198269, XrefRangeStart = 1198254, XrefRangeEnd = 1198267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> ExecuteUnparsedAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteUnparsedAsync_Private_Task_1_HttpResponseMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00009D1C File Offset: 0x00007F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198277, RefRangeEnd = 1198278, XrefRangeStart = 1198269, XrefRangeEnd = 1198277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResponse> ParseResponse(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_ParseResponse_Private_Task_1_TResponse_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00009D6C File Offset: 0x00007F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198306, RefRangeEnd = 1198307, XrefRangeStart = 1198278, XrefRangeEnd = 1198306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual HttpRequestMessage CreateRequest(Nullable<bool> overrideGZipEnabled = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideGZipEnabled));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_CreateRequest_Public_Virtual_Final_New_HttpRequestMessage_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00009DC4 File Offset: 0x00007FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1198334, RefRangeEnd = 1198336, XrefRangeStart = 1198307, XrefRangeEnd = 1198334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestBuilder CreateBuilder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_CreateBuilder_Private_RequestBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestBuilder>(intPtr3) : null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00009E04 File Offset: 0x00008004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198336, XrefRangeEnd = 1198350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateRequestUri()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_GenerateRequestUri_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00009E3C File Offset: 0x0000803C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetBody()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientServiceRequest<TResponse>.NativeMethodInfoPtr_GetBody_Protected_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00009E88 File Offset: 0x00008088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198383, RefRangeEnd = 1198384, XrefRangeStart = 1198350, XrefRangeEnd = 1198383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddETag(HttpRequestMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_AddETag_Private_Void_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00009ECC File Offset: 0x000080CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198384, XrefRangeEnd = 1198391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ETagAction GetDefaultETagAction(string httpMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(httpMethod);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_GetDefaultETagAction_Public_Static_ETagAction_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00009F10 File Offset: 0x00008110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198454, RefRangeEnd = 1198455, XrefRangeStart = 1198391, XrefRangeEnd = 1198454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddParameters(RequestBuilder requestBuilder, ParameterCollection inputParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>.NativeMethodInfoPtr_AddParameters_Private_Void_RequestBuilder_ParameterCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000026A3 File Offset: 0x000008A3
		public ClientServiceRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00009F64 File Offset: 0x00008164
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000026AC File Offset: 0x000008AC
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientServiceRequest<TResponse>.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientServiceRequest<TResponse>.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00009F8C File Offset: 0x0000818C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000026BE File Offset: 0x000008BE
		public unsafe IClientService service
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr_service);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr_service), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00009FBC File Offset: 0x000081BC
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000026DD File Offset: 0x000008DD
		public unsafe ETagAction _ETagAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr__ETagAction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr__ETagAction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00009FE4 File Offset: 0x000081E4
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000026F8 File Offset: 0x000008F8
		public unsafe Action<HttpRequestMessage> _ModifyRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr__ModifyRequest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HttpRequestMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr__ModifyRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000A014 File Offset: 0x00008214
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002717 File Offset: 0x00000917
		public unsafe IDictionary<string, IParameter> _RequestParameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr__RequestParameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, IParameter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>.NativeFieldInfoPtr__RequestParameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_service;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr__ETagAction_k__BackingField;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr__ModifyRequest_k__BackingField;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr__RequestParameters_k__BackingField;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_get_ETagAction_Public_get_ETagAction_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_set_ETagAction_Public_set_Void_ETagAction_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_ModifyRequest_Public_get_Action_1_HttpRequestMessage_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_set_ModifyRequest_Public_set_Void_Action_1_HttpRequestMessage_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestParameters_Public_Virtual_Final_New_get_IDictionary_2_String_IParameter_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestParameters_Private_set_Void_IDictionary_2_String_IParameter_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_Service_Public_Virtual_Final_New_get_IClientService_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IClientService_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_New_Void_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_TResponse_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsStream_Public_Virtual_Final_New_Stream_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsync_Public_Virtual_Final_New_Task_1_TResponse_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsync_Public_Virtual_Final_New_Task_1_TResponse_CancellationToken_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Virtual_Final_New_Task_1_Stream_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Virtual_Final_New_Task_1_Stream_CancellationToken_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteUnparsedAsync_Private_Task_1_HttpResponseMessage_CancellationToken_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Private_Task_1_TResponse_HttpResponseMessage_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_CreateRequest_Public_Virtual_Final_New_HttpRequestMessage_Nullable_1_Boolean_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_CreateBuilder_Private_RequestBuilder_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRequestUri_Protected_String_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_GetBody_Protected_Virtual_New_Object_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_AddETag_Private_Void_HttpRequestMessage_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultETagAction_Public_Static_ETagAction_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_AddParameters_Private_Void_RequestBuilder_ParameterCollection_0;

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("Google.Apis.Requests.ClientServiceRequest`1+<ExecuteAsync>d__26")]
		public sealed class _ExecuteAsync_d__26 : ValueType
		{
			// Token: 0x0600035B RID: 859 RVA: 0x000105E4 File Offset: 0x0000E7E4
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteAsync_d__26()
			{
				Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ExecuteAsync>d__26"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr);
				ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr, "<>1__state");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr, "<>t__builder");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr, "<>4__this");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr, "<>u__1");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr, 100663576);
				ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr, 100663577);
			}

			// Token: 0x0600035C RID: 860 RVA: 0x000106C4 File Offset: 0x0000E8C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197865, XrefRangeEnd = 1197884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600035D RID: 861 RVA: 0x000106FC File Offset: 0x0000E8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197884, XrefRangeEnd = 1197945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600035E RID: 862 RVA: 0x00003C04 File Offset: 0x00001E04
			public _ExecuteAsync_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00003C0D File Offset: 0x00001E0D
			public _ExecuteAsync_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000360 RID: 864 RVA: 0x00010744 File Offset: 0x0000E944
			// (set) Token: 0x06000361 RID: 865 RVA: 0x00003C1F File Offset: 0x00001E1F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000362 RID: 866 RVA: 0x0001076C File Offset: 0x0000E96C
			// (set) Token: 0x06000363 RID: 867 RVA: 0x00003C3A File Offset: 0x00001E3A
			public AsyncTaskMethodBuilder<TResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0001079C File Offset: 0x0000E99C
			// (set) Token: 0x06000365 RID: 869 RVA: 0x00003C68 File Offset: 0x00001E68
			public unsafe ClientServiceRequest<TResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientServiceRequest<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000366 RID: 870 RVA: 0x000107CC File Offset: 0x0000E9CC
			// (set) Token: 0x06000367 RID: 871 RVA: 0x00003C87 File Offset: 0x00001E87
			public ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("Google.Apis.Requests.ClientServiceRequest`1+<ExecuteAsync>d__27")]
		public sealed class _ExecuteAsync_d__27 : ValueType
		{
			// Token: 0x06000368 RID: 872 RVA: 0x000107FC File Offset: 0x0000E9FC
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteAsync_d__27()
			{
				Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ExecuteAsync>d__27"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr);
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, "<>1__state");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, "<>t__builder");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, "<>4__this");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, "cancellationToken");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr__response_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, "<response>5__2");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, "<>u__1");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, "<>u__2");
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, 100663578);
				ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr, 100663579);
			}

			// Token: 0x06000369 RID: 873 RVA: 0x00010918 File Offset: 0x0000EB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197945, XrefRangeEnd = 1197988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00010950 File Offset: 0x0000EB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197988, XrefRangeEnd = 1197993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600036B RID: 875 RVA: 0x00003CB5 File Offset: 0x00001EB5
			public _ExecuteAsync_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600036C RID: 876 RVA: 0x00003CBE File Offset: 0x00001EBE
			public _ExecuteAsync_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsync_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600036D RID: 877 RVA: 0x00010998 File Offset: 0x0000EB98
			// (set) Token: 0x0600036E RID: 878 RVA: 0x00003CD0 File Offset: 0x00001ED0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600036F RID: 879 RVA: 0x000109C0 File Offset: 0x0000EBC0
			// (set) Token: 0x06000370 RID: 880 RVA: 0x00003CEB File Offset: 0x00001EEB
			public AsyncTaskMethodBuilder<TResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000371 RID: 881 RVA: 0x000109F0 File Offset: 0x0000EBF0
			// (set) Token: 0x06000372 RID: 882 RVA: 0x00003D19 File Offset: 0x00001F19
			public unsafe ClientServiceRequest<TResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientServiceRequest<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00010A20 File Offset: 0x0000EC20
			// (set) Token: 0x06000374 RID: 884 RVA: 0x00003D38 File Offset: 0x00001F38
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000375 RID: 885 RVA: 0x00010A50 File Offset: 0x0000EC50
			// (set) Token: 0x06000376 RID: 886 RVA: 0x00003D66 File Offset: 0x00001F66
			public unsafe HttpResponseMessage _response_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr__response_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr__response_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000377 RID: 887 RVA: 0x00010A80 File Offset: 0x0000EC80
			// (set) Token: 0x06000378 RID: 888 RVA: 0x00003D85 File Offset: 0x00001F85
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000379 RID: 889 RVA: 0x00010AB0 File Offset: 0x0000ECB0
			// (set) Token: 0x0600037A RID: 890 RVA: 0x00003DB3 File Offset: 0x00001FB3
			public ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsync_d__27.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeFieldInfoPtr__response_5__2;

			// Token: 0x0400023C RID: 572
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400023D RID: 573
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400023E RID: 574
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400023F RID: 575
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("Google.Apis.Requests.ClientServiceRequest`1+<ExecuteAsStreamAsync>d__28")]
		public sealed class _ExecuteAsStreamAsync_d__28 : ValueType
		{
			// Token: 0x0600037B RID: 891 RVA: 0x00010AE0 File Offset: 0x0000ECE0
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteAsStreamAsync_d__28()
			{
				Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ExecuteAsStreamAsync>d__28"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr);
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr, "<>1__state");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr, "<>t__builder");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr, "<>4__this");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr, "<>u__1");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr, 100663580);
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr, 100663581);
			}

			// Token: 0x0600037C RID: 892 RVA: 0x00010BC0 File Offset: 0x0000EDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197993, XrefRangeEnd = 1198016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600037D RID: 893 RVA: 0x00010BF8 File Offset: 0x0000EDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198016, XrefRangeEnd = 1198022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00003DE1 File Offset: 0x00001FE1
			public _ExecuteAsStreamAsync_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600037F RID: 895 RVA: 0x00003DEA File Offset: 0x00001FEA
			public _ExecuteAsStreamAsync_d__28()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28>.NativeClassPtr))
			{
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000380 RID: 896 RVA: 0x00010C40 File Offset: 0x0000EE40
			// (set) Token: 0x06000381 RID: 897 RVA: 0x00003DFC File Offset: 0x00001FFC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000382 RID: 898 RVA: 0x00010C68 File Offset: 0x0000EE68
			// (set) Token: 0x06000383 RID: 899 RVA: 0x00003E17 File Offset: 0x00002017
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000384 RID: 900 RVA: 0x00010C98 File Offset: 0x0000EE98
			// (set) Token: 0x06000385 RID: 901 RVA: 0x00003E45 File Offset: 0x00002045
			public unsafe ClientServiceRequest<TResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientServiceRequest<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000386 RID: 902 RVA: 0x00010CC8 File Offset: 0x0000EEC8
			// (set) Token: 0x06000387 RID: 903 RVA: 0x00003E64 File Offset: 0x00002064
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000240 RID: 576
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000241 RID: 577
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000242 RID: 578
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000243 RID: 579
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000244 RID: 580
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000245 RID: 581
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000041 RID: 65
		[ObfuscatedName("Google.Apis.Requests.ClientServiceRequest`1+<ExecuteAsStreamAsync>d__29")]
		public sealed class _ExecuteAsStreamAsync_d__29 : ValueType
		{
			// Token: 0x06000388 RID: 904 RVA: 0x00010CF8 File Offset: 0x0000EEF8
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteAsStreamAsync_d__29()
			{
				Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ExecuteAsStreamAsync>d__29"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr);
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, "<>1__state");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, "<>t__builder");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, "<>4__this");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, "cancellationToken");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, "<>u__1");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, "<>u__2");
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, 100663582);
				ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr, 100663583);
			}

			// Token: 0x06000389 RID: 905 RVA: 0x00010E00 File Offset: 0x0000F000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198022, XrefRangeEnd = 1198057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600038A RID: 906 RVA: 0x00010E38 File Offset: 0x0000F038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198057, XrefRangeEnd = 1198090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00003E92 File Offset: 0x00002092
			public _ExecuteAsStreamAsync_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00003E9B File Offset: 0x0000209B
			public _ExecuteAsStreamAsync_d__29()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29>.NativeClassPtr))
			{
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600038D RID: 909 RVA: 0x00010E80 File Offset: 0x0000F080
			// (set) Token: 0x0600038E RID: 910 RVA: 0x00003EAD File Offset: 0x000020AD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x0600038F RID: 911 RVA: 0x00010EA8 File Offset: 0x0000F0A8
			// (set) Token: 0x06000390 RID: 912 RVA: 0x00003EC8 File Offset: 0x000020C8
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000391 RID: 913 RVA: 0x00010ED8 File Offset: 0x0000F0D8
			// (set) Token: 0x06000392 RID: 914 RVA: 0x00003EF6 File Offset: 0x000020F6
			public unsafe ClientServiceRequest<TResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientServiceRequest<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000393 RID: 915 RVA: 0x00010F08 File Offset: 0x0000F108
			// (set) Token: 0x06000394 RID: 916 RVA: 0x00003F15 File Offset: 0x00002115
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000395 RID: 917 RVA: 0x00010F38 File Offset: 0x0000F138
			// (set) Token: 0x06000396 RID: 918 RVA: 0x00003F43 File Offset: 0x00002143
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000397 RID: 919 RVA: 0x00010F68 File Offset: 0x0000F168
			// (set) Token: 0x06000398 RID: 920 RVA: 0x00003F71 File Offset: 0x00002171
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteAsStreamAsync_d__29.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000246 RID: 582
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("Google.Apis.Requests.ClientServiceRequest`1+<ExecuteUnparsedAsync>d__30")]
		public sealed class _ExecuteUnparsedAsync_d__30 : ValueType
		{
			// Token: 0x06000399 RID: 921 RVA: 0x00010F98 File Offset: 0x0000F198
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteUnparsedAsync_d__30()
			{
				Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ExecuteUnparsedAsync>d__30"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr);
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, "<>1__state");
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, "<>t__builder");
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, "<>4__this");
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, "cancellationToken");
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, "<request>5__2");
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, "<>u__1");
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, 100663584);
				ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr, 100663585);
			}

			// Token: 0x0600039A RID: 922 RVA: 0x000110A0 File Offset: 0x0000F2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198090, XrefRangeEnd = 1198116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600039B RID: 923 RVA: 0x000110D8 File Offset: 0x0000F2D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198116, XrefRangeEnd = 1198128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00003F9F File Offset: 0x0000219F
			public _ExecuteUnparsedAsync_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00003FA8 File Offset: 0x000021A8
			public _ExecuteUnparsedAsync_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600039E RID: 926 RVA: 0x00011120 File Offset: 0x0000F320
			// (set) Token: 0x0600039F RID: 927 RVA: 0x00003FBA File Offset: 0x000021BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060003A0 RID: 928 RVA: 0x00011148 File Offset: 0x0000F348
			// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003FD5 File Offset: 0x000021D5
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpResponseMessage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060003A2 RID: 930 RVA: 0x00011178 File Offset: 0x0000F378
			// (set) Token: 0x060003A3 RID: 931 RVA: 0x00004003 File Offset: 0x00002203
			public unsafe ClientServiceRequest<TResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientServiceRequest<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060003A4 RID: 932 RVA: 0x000111A8 File Offset: 0x0000F3A8
			// (set) Token: 0x060003A5 RID: 933 RVA: 0x00004022 File Offset: 0x00002222
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060003A6 RID: 934 RVA: 0x000111D8 File Offset: 0x0000F3D8
			// (set) Token: 0x060003A7 RID: 935 RVA: 0x00004050 File Offset: 0x00002250
			public unsafe HttpRequestMessage _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060003A8 RID: 936 RVA: 0x00011208 File Offset: 0x0000F408
			// (set) Token: 0x060003A9 RID: 937 RVA: 0x0000406F File Offset: 0x0000226F
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ExecuteUnparsedAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("Google.Apis.Requests.ClientServiceRequest`1+<ParseResponse>d__31")]
		public sealed class _ParseResponse_d__31 : ValueType
		{
			// Token: 0x060003AA RID: 938 RVA: 0x00011238 File Offset: 0x0000F438
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseResponse_d__31()
			{
				Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientServiceRequest<TResponse>>.NativeClassPtr, "<ParseResponse>d__31"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr);
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, "<>1__state");
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, "<>t__builder");
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, "response");
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, "<>4__this");
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, "<>u__1");
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, "<>u__2");
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, 100663586);
				ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr, 100663587);
			}

			// Token: 0x060003AB RID: 939 RVA: 0x00011340 File Offset: 0x0000F540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198128, XrefRangeEnd = 1198164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00011378 File Offset: 0x0000F578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003AD RID: 941 RVA: 0x0000409D File Offset: 0x0000229D
			public _ParseResponse_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003AE RID: 942 RVA: 0x000040A6 File Offset: 0x000022A6
			public _ParseResponse_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest<TResponse>._ParseResponse_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060003AF RID: 943 RVA: 0x000113C0 File Offset: 0x0000F5C0
			// (set) Token: 0x060003B0 RID: 944 RVA: 0x000040B8 File Offset: 0x000022B8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x000113E8 File Offset: 0x0000F5E8
			// (set) Token: 0x060003B2 RID: 946 RVA: 0x000040D3 File Offset: 0x000022D3
			public AsyncTaskMethodBuilder<TResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x00011418 File Offset: 0x0000F618
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x00004101 File Offset: 0x00002301
			public unsafe HttpResponseMessage response
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr_response);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x00011448 File Offset: 0x0000F648
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x00004120 File Offset: 0x00002320
			public unsafe ClientServiceRequest<TResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientServiceRequest<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00011478 File Offset: 0x0000F678
			// (set) Token: 0x060003B8 RID: 952 RVA: 0x0000413F File Offset: 0x0000233F
			public ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x000114A8 File Offset: 0x0000F6A8
			// (set) Token: 0x060003BA RID: 954 RVA: 0x0000416D File Offset: 0x0000236D
			public ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest<TResponse>._ParseResponse_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeFieldInfoPtr_response;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
