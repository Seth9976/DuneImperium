using System;
using Google.Apis.Http;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Requests
{
	// Token: 0x0200000E RID: 14
	public sealed class BatchRequest : Object
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00008D70 File Offset: 0x00006F70
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRequest()
		{
			Il2CppClassPointerStore<BatchRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "BatchRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr);
			BatchRequest.NativeFieldInfoPtr_DefaultBatchUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "DefaultBatchUrl");
			BatchRequest.NativeFieldInfoPtr_QueueLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "QueueLimit");
			BatchRequest.NativeFieldInfoPtr_allRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "allRequests");
			BatchRequest.NativeFieldInfoPtr_batchUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "batchUrl");
			BatchRequest.NativeFieldInfoPtr_service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "service");
			BatchRequest.NativeMethodInfoPtr_get_BatchUrl_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663508);
			BatchRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663509);
			BatchRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663510);
			BatchRequest.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663511);
			BatchRequest.NativeMethodInfoPtr_Queue_Public_Void_IClientServiceRequest_OnResponse_1_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663512);
			BatchRequest.NativeMethodInfoPtr_ExecuteAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663513);
			BatchRequest.NativeMethodInfoPtr_ExecuteAsync_Public_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663514);
			BatchRequest.NativeMethodInfoPtr_ParseAsHttpResponse_Internal_Static_HttpResponseMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663515);
			BatchRequest.NativeMethodInfoPtr_CreateOuterRequestContent_Internal_Static_Task_1_HttpContent_IEnumerable_1_IClientServiceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663516);
			BatchRequest.NativeMethodInfoPtr_CreateIndividualRequest_Internal_Static_Task_1_HttpContent_IClientServiceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663517);
			BatchRequest.NativeMethodInfoPtr_CreateRequestContentString_Internal_Static_Task_1_String_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, 100663518);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00008EE0 File Offset: 0x000070E0
		public unsafe string BatchUrl
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_get_BatchUrl_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008F18 File Offset: 0x00007118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197582, XrefRangeEnd = 1197597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchRequest(IClientService service)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008F64 File Offset: 0x00007164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197597, XrefRangeEnd = 1197607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchRequest(IClientService service, string batchUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(batchUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00008FC4 File Offset: 0x000071C4
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1197611, RefRangeEnd = 1197612, XrefRangeStart = 1197607, XrefRangeEnd = 1197611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009000 File Offset: 0x00007200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197612, XrefRangeEnd = 1197634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Queue<TResponse>(IClientServiceRequest request, BatchRequest.OnResponse<TResponse> callback) where TResponse : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.MethodInfoStoreGeneric_Queue_Public_Void_IClientServiceRequest_OnResponse_1_TResponse_0<TResponse>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00009054 File Offset: 0x00007254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197634, XrefRangeEnd = 1197650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ExecuteAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_ExecuteAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00009094 File Offset: 0x00007294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197650, XrefRangeEnd = 1197662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ExecuteAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_ExecuteAsync_Public_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000090EC File Offset: 0x000072EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1197766, RefRangeEnd = 1197767, XrefRangeStart = 1197662, XrefRangeEnd = 1197766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HttpResponseMessage ParseAsHttpResponse(string content)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_ParseAsHttpResponse_Internal_Static_HttpResponseMessage_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00009130 File Offset: 0x00007330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197767, XrefRangeEnd = 1197781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<HttpContent> CreateOuterRequestContent(IEnumerable<IClientServiceRequest> requests)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_CreateOuterRequestContent_Internal_Static_Task_1_HttpContent_IEnumerable_1_IClientServiceRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpContent>>(intPtr3) : null;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00009174 File Offset: 0x00007374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197781, XrefRangeEnd = 1197795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<HttpContent> CreateIndividualRequest(IClientServiceRequest request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_CreateIndividualRequest_Internal_Static_Task_1_HttpContent_IClientServiceRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpContent>>(intPtr3) : null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000091B8 File Offset: 0x000073B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197795, XrefRangeEnd = 1197809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<string> CreateRequestContentString(HttpRequestMessage requestMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.NativeMethodInfoPtr_CreateRequestContentString_Internal_Static_Task_1_String_HttpRequestMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000025B7 File Offset: 0x000007B7
		public BatchRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000091FC File Offset: 0x000073FC
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000025C0 File Offset: 0x000007C0
		public unsafe static string DefaultBatchUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BatchRequest.NativeFieldInfoPtr_DefaultBatchUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchRequest.NativeFieldInfoPtr_DefaultBatchUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000921C File Offset: 0x0000741C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000025D2 File Offset: 0x000007D2
		public unsafe static int QueueLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BatchRequest.NativeFieldInfoPtr_QueueLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchRequest.NativeFieldInfoPtr_QueueLimit, (void*)(&value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00009238 File Offset: 0x00007438
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000025E0 File Offset: 0x000007E0
		public unsafe IList<BatchRequest.InnerRequest> allRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.NativeFieldInfoPtr_allRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<BatchRequest.InnerRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.NativeFieldInfoPtr_allRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00009268 File Offset: 0x00007468
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000025FF File Offset: 0x000007FF
		public unsafe string batchUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.NativeFieldInfoPtr_batchUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.NativeFieldInfoPtr_batchUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00009290 File Offset: 0x00007490
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000261E File Offset: 0x0000081E
		public unsafe IClientService service
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.NativeFieldInfoPtr_service);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.NativeFieldInfoPtr_service), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_DefaultBatchUrl;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_QueueLimit;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_allRequests;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_batchUrl;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_service;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_get_BatchUrl_Internal_get_String_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_String_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_Queue_Public_Void_IClientServiceRequest_OnResponse_1_TResponse_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsync_Public_Task_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsync_Public_Task_CancellationToken_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_ParseAsHttpResponse_Internal_Static_HttpResponseMessage_String_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_CreateOuterRequestContent_Internal_Static_Task_1_HttpContent_IEnumerable_1_IClientServiceRequest_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_CreateIndividualRequest_Internal_Static_Task_1_HttpContent_IClientServiceRequest_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_CreateRequestContentString_Internal_Static_Task_1_String_HttpRequestMessage_0;

		// Token: 0x02000035 RID: 53
		public sealed class OnResponse<TResponse> : MulticastDelegate where TResponse : class
		{
			// Token: 0x060002E3 RID: 739 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
			// Note: this type is marked as 'beforefieldinit'.
			static OnResponse()
			{
				Il2CppClassPointerStore<BatchRequest.OnResponse<TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "OnResponse`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.OnResponse<TResponse>>.NativeClassPtr, 100663519);
				BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TResponse_RequestError_Int32_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.OnResponse<TResponse>>.NativeClassPtr, 100663520);
				BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TResponse_RequestError_Int32_HttpResponseMessage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.OnResponse<TResponse>>.NativeClassPtr, 100663521);
				BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.OnResponse<TResponse>>.NativeClassPtr, 100663522);
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0000F194 File Offset: 0x0000D394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnResponse(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest.OnResponse<TResponse>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x0000F1F0 File Offset: 0x0000D3F0
			[CallerCount(0)]
			public unsafe void Invoke(TResponse content, RequestError error, int index, HttpResponseMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TResponse).IsValueType)
					{
						TResponse tresponse = content;
						intPtr = ((tresponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tresponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tresponse as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref content;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TResponse_RequestError_Int32_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0000F29C File Offset: 0x0000D49C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197154, XrefRangeEnd = 1197158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TResponse content, RequestError error, int index, HttpResponseMessage message, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TResponse).IsValueType)
					{
						TResponse tresponse = content;
						intPtr = ((tresponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tresponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tresponse as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref content;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TResponse_RequestError_Int32_HttpResponseMessage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000F37C File Offset: 0x0000D57C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.OnResponse<TResponse>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000366F File Offset: 0x0000186F
			public OnResponse(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x00003678 File Offset: 0x00001878
			public static implicit operator BatchRequest.OnResponse<TResponse>(Action<TResponse, RequestError, int, HttpResponseMessage> A_0)
			{
				return DelegateSupport.ConvertDelegate<BatchRequest.OnResponse<TResponse>>(A_0);
			}

			// Token: 0x060002EA RID: 746 RVA: 0x00003680 File Offset: 0x00001880
			public static BatchRequest.OnResponse<TResponse>operator +(BatchRequest.OnResponse<TResponse> A_0, BatchRequest.OnResponse<TResponse> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BatchRequest.OnResponse<TResponse>>();
			}

			// Token: 0x060002EB RID: 747 RVA: 0x0000368E File Offset: 0x0000188E
			public static BatchRequest.OnResponse<TResponse>operator -(BatchRequest.OnResponse<TResponse> A_0, BatchRequest.OnResponse<TResponse> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<BatchRequest.OnResponse<TResponse>>();
				}
				return delegate2;
			}

			// Token: 0x040001F4 RID: 500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001F5 RID: 501
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TResponse_RequestError_Int32_HttpResponseMessage_0;

			// Token: 0x040001F6 RID: 502
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TResponse_RequestError_Int32_HttpResponseMessage_AsyncCallback_Object_0;

			// Token: 0x040001F7 RID: 503
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000036 RID: 54
		public class InnerRequest : Object
		{
			// Token: 0x060002EC RID: 748 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
			// Note: this type is marked as 'beforefieldinit'.
			static InnerRequest()
			{
				Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "InnerRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr);
				BatchRequest.InnerRequest.NativeFieldInfoPtr__ClientRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, "<ClientRequest>k__BackingField");
				BatchRequest.InnerRequest.NativeFieldInfoPtr__ResponseType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, "<ResponseType>k__BackingField");
				BatchRequest.InnerRequest.NativeMethodInfoPtr_get_ClientRequest_Public_get_IClientServiceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, 100663523);
				BatchRequest.InnerRequest.NativeMethodInfoPtr_set_ClientRequest_Public_set_Void_IClientServiceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, 100663524);
				BatchRequest.InnerRequest.NativeMethodInfoPtr_get_ResponseType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, 100663525);
				BatchRequest.InnerRequest.NativeMethodInfoPtr_set_ResponseType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, 100663526);
				BatchRequest.InnerRequest.NativeMethodInfoPtr_OnResponse_Public_Virtual_New_Void_Object_RequestError_Int32_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, 100663527);
				BatchRequest.InnerRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr, 100663528);
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060002ED RID: 749 RVA: 0x0000F48C File Offset: 0x0000D68C
			// (set) Token: 0x060002EE RID: 750 RVA: 0x0000F4CC File Offset: 0x0000D6CC
			public unsafe IClientServiceRequest ClientRequest
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest.NativeMethodInfoPtr_get_ClientRequest_Public_get_IClientServiceRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClientServiceRequest>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest.NativeMethodInfoPtr_set_ClientRequest_Public_set_Void_IClientServiceRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060002EF RID: 751 RVA: 0x0000F510 File Offset: 0x0000D710
			// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000F550 File Offset: 0x0000D750
			public unsafe Type ResponseType
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest.NativeMethodInfoPtr_get_ResponseType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest.NativeMethodInfoPtr_set_ResponseType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x0000F594 File Offset: 0x0000D794
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1197170, RefRangeEnd = 1197171, XrefRangeStart = 1197158, XrefRangeEnd = 1197170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnResponse(Object content, RequestError error, int index, HttpResponseMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchRequest.InnerRequest.NativeMethodInfoPtr_OnResponse_Public_Virtual_New_Void_Object_RequestError_Int32_HttpResponseMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x0000F614 File Offset: 0x0000D814
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InnerRequest()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest.InnerRequest>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0000369F File Offset: 0x0000189F
			public InnerRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000F650 File Offset: 0x0000D850
			// (set) Token: 0x060002F5 RID: 757 RVA: 0x000036A8 File Offset: 0x000018A8
			public unsafe IClientServiceRequest _ClientRequest_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.InnerRequest.NativeFieldInfoPtr__ClientRequest_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientServiceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.InnerRequest.NativeFieldInfoPtr__ClientRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000F680 File Offset: 0x0000D880
			// (set) Token: 0x060002F7 RID: 759 RVA: 0x000036C7 File Offset: 0x000018C7
			public unsafe Type _ResponseType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.InnerRequest.NativeFieldInfoPtr__ResponseType_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.InnerRequest.NativeFieldInfoPtr__ResponseType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F8 RID: 504
			private static readonly IntPtr NativeFieldInfoPtr__ClientRequest_k__BackingField;

			// Token: 0x040001F9 RID: 505
			private static readonly IntPtr NativeFieldInfoPtr__ResponseType_k__BackingField;

			// Token: 0x040001FA RID: 506
			private static readonly IntPtr NativeMethodInfoPtr_get_ClientRequest_Public_get_IClientServiceRequest_0;

			// Token: 0x040001FB RID: 507
			private static readonly IntPtr NativeMethodInfoPtr_set_ClientRequest_Public_set_Void_IClientServiceRequest_0;

			// Token: 0x040001FC RID: 508
			private static readonly IntPtr NativeMethodInfoPtr_get_ResponseType_Public_get_Type_0;

			// Token: 0x040001FD RID: 509
			private static readonly IntPtr NativeMethodInfoPtr_set_ResponseType_Public_set_Void_Type_0;

			// Token: 0x040001FE RID: 510
			private static readonly IntPtr NativeMethodInfoPtr_OnResponse_Public_Virtual_New_Void_Object_RequestError_Int32_HttpResponseMessage_0;

			// Token: 0x040001FF RID: 511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000037 RID: 55
		public class InnerRequest<TResponse> : BatchRequest.InnerRequest where TResponse : class
		{
			// Token: 0x060002F8 RID: 760 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
			// Note: this type is marked as 'beforefieldinit'.
			static InnerRequest()
			{
				Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "InnerRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr);
				BatchRequest.InnerRequest<TResponse>.NativeFieldInfoPtr__OnResponseCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr, "<OnResponseCallback>k__BackingField");
				BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr_get_OnResponseCallback_Public_get_OnResponse_1_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr, 100663529);
				BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr_set_OnResponseCallback_Public_set_Void_OnResponse_1_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr, 100663530);
				BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr_OnResponse_Public_Virtual_Void_Object_RequestError_Int32_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr, 100663531);
				BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr, 100663532);
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000F77C File Offset: 0x0000D97C
			// (set) Token: 0x060002FA RID: 762 RVA: 0x0000F7BC File Offset: 0x0000D9BC
			public unsafe BatchRequest.OnResponse<TResponse> OnResponseCallback
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr_get_OnResponseCallback_Public_get_OnResponse_1_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BatchRequest.OnResponse<TResponse>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr_set_OnResponseCallback_Public_set_Void_OnResponse_1_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0000F800 File Offset: 0x0000DA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197171, XrefRangeEnd = 1197176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnResponse(Object content, RequestError error, int index, HttpResponseMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr_OnResponse_Public_Virtual_Void_Object_RequestError_Int32_HttpResponseMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0000F880 File Offset: 0x0000DA80
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InnerRequest()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest.InnerRequest<TResponse>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.InnerRequest<TResponse>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FD RID: 765 RVA: 0x000036E6 File Offset: 0x000018E6
			public InnerRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060002FE RID: 766 RVA: 0x0000F8BC File Offset: 0x0000DABC
			// (set) Token: 0x060002FF RID: 767 RVA: 0x000036EF File Offset: 0x000018EF
			public unsafe BatchRequest.OnResponse<TResponse> _OnResponseCallback_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.InnerRequest<TResponse>.NativeFieldInfoPtr__OnResponseCallback_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchRequest.OnResponse<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest.InnerRequest<TResponse>.NativeFieldInfoPtr__OnResponseCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeFieldInfoPtr__OnResponseCallback_k__BackingField;

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeMethodInfoPtr_get_OnResponseCallback_Public_get_OnResponse_1_TResponse_0;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeMethodInfoPtr_set_OnResponseCallback_Public_set_Void_OnResponse_1_TResponse_0;

			// Token: 0x04000203 RID: 515
			private static readonly IntPtr NativeMethodInfoPtr_OnResponse_Public_Virtual_Void_Object_RequestError_Int32_HttpResponseMessage_0;

			// Token: 0x04000204 RID: 516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000038 RID: 56
		[ObfuscatedName("Google.Apis.Requests.BatchRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000300 RID: 768 RVA: 0x0000F8EC File Offset: 0x0000DAEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BatchRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest.__c>.NativeClassPtr);
				BatchRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest.__c>.NativeClassPtr, "<>9");
				BatchRequest.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest.__c>.NativeClassPtr, "<>9__16_0");
				BatchRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.__c>.NativeClassPtr, 100663534);
				BatchRequest.__c.NativeMethodInfoPtr__ExecuteAsync_b__16_0_Internal_IClientServiceRequest_InnerRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest.__c>.NativeClassPtr, 100663535);
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0000F968 File Offset: 0x0000DB68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000302 RID: 770 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
			[CallerCount(0)]
			public unsafe IClientServiceRequest _ExecuteAsync_b__16_0(BatchRequest.InnerRequest r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest.__c.NativeMethodInfoPtr__ExecuteAsync_b__16_0_Internal_IClientServiceRequest_InnerRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClientServiceRequest>(intPtr3) : null;
				}
			}

			// Token: 0x06000303 RID: 771 RVA: 0x0000370E File Offset: 0x0000190E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000304 RID: 772 RVA: 0x0000F9F4 File Offset: 0x0000DBF4
			// (set) Token: 0x06000305 RID: 773 RVA: 0x00003717 File Offset: 0x00001917
			public unsafe static BatchRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BatchRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BatchRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000306 RID: 774 RVA: 0x0000FA1C File Offset: 0x0000DC1C
			// (set) Token: 0x06000307 RID: 775 RVA: 0x00003729 File Offset: 0x00001929
			public unsafe static Func<BatchRequest.InnerRequest, IClientServiceRequest> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BatchRequest.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BatchRequest.InnerRequest, IClientServiceRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BatchRequest.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000205 RID: 517
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000206 RID: 518
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04000207 RID: 519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000208 RID: 520
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteAsync_b__16_0_Internal_IClientServiceRequest_InnerRequest_0;
		}

		// Token: 0x02000039 RID: 57
		[ObfuscatedName("Google.Apis.Requests.BatchRequest+<ExecuteAsync>d__16")]
		public sealed class _ExecuteAsync_d__16 : ValueType
		{
			// Token: 0x06000308 RID: 776 RVA: 0x0000FA44 File Offset: 0x0000DC44
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteAsync_d__16()
			{
				Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "<ExecuteAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr);
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<>1__state");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<>t__builder");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<>4__this");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "cancellationToken");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__httpClient_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<httpClient>5__2");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__result_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<result>5__3");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__fullContent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<fullContent>5__4");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__boundary_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<boundary>5__5");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__requestIndex_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<requestIndex>5__6");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<>u__1");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<>u__2");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<>u__3");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__endIndex_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<endIndex>5__7");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__responseMessage_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<responseMessage>5__8");
				BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, "<>u__4");
				BatchRequest._ExecuteAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, 100663536);
				BatchRequest._ExecuteAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr, 100663537);
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197176, XrefRangeEnd = 1197354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._ExecuteAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600030A RID: 778 RVA: 0x0000FBFC File Offset: 0x0000DDFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197354, XrefRangeEnd = 1197358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._ExecuteAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600030B RID: 779 RVA: 0x0000373B File Offset: 0x0000193B
			public _ExecuteAsync_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600030C RID: 780 RVA: 0x00003744 File Offset: 0x00001944
			public _ExecuteAsync_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest._ExecuteAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600030D RID: 781 RVA: 0x0000FC44 File Offset: 0x0000DE44
			// (set) Token: 0x0600030E RID: 782 RVA: 0x00003756 File Offset: 0x00001956
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600030F RID: 783 RVA: 0x0000FC6C File Offset: 0x0000DE6C
			// (set) Token: 0x06000310 RID: 784 RVA: 0x00003771 File Offset: 0x00001971
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000311 RID: 785 RVA: 0x0000FC9C File Offset: 0x0000DE9C
			// (set) Token: 0x06000312 RID: 786 RVA: 0x0000379F File Offset: 0x0000199F
			public unsafe BatchRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000313 RID: 787 RVA: 0x0000FCCC File Offset: 0x0000DECC
			// (set) Token: 0x06000314 RID: 788 RVA: 0x000037BE File Offset: 0x000019BE
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000315 RID: 789 RVA: 0x0000FCFC File Offset: 0x0000DEFC
			// (set) Token: 0x06000316 RID: 790 RVA: 0x000037EC File Offset: 0x000019EC
			public unsafe ConfigurableHttpClient _httpClient_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__httpClient_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__httpClient_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000317 RID: 791 RVA: 0x0000FD2C File Offset: 0x0000DF2C
			// (set) Token: 0x06000318 RID: 792 RVA: 0x0000380B File Offset: 0x00001A0B
			public unsafe HttpResponseMessage _result_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__result_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__result_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000319 RID: 793 RVA: 0x0000FD5C File Offset: 0x0000DF5C
			// (set) Token: 0x0600031A RID: 794 RVA: 0x0000382A File Offset: 0x00001A2A
			public unsafe string _fullContent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__fullContent_5__4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__fullContent_5__4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x0600031B RID: 795 RVA: 0x0000FD84 File Offset: 0x0000DF84
			// (set) Token: 0x0600031C RID: 796 RVA: 0x00003849 File Offset: 0x00001A49
			public unsafe string _boundary_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__boundary_5__5);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__boundary_5__5), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x0600031D RID: 797 RVA: 0x0000FDAC File Offset: 0x0000DFAC
			// (set) Token: 0x0600031E RID: 798 RVA: 0x00003868 File Offset: 0x00001A68
			public unsafe int _requestIndex_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__requestIndex_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__requestIndex_5__6)) = value;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600031F RID: 799 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
			// (set) Token: 0x06000320 RID: 800 RVA: 0x00003883 File Offset: 0x00001A83
			public ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000321 RID: 801 RVA: 0x0000FE04 File Offset: 0x0000E004
			// (set) Token: 0x06000322 RID: 802 RVA: 0x000038B1 File Offset: 0x00001AB1
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000323 RID: 803 RVA: 0x0000FE34 File Offset: 0x0000E034
			// (set) Token: 0x06000324 RID: 804 RVA: 0x000038DF File Offset: 0x00001ADF
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000325 RID: 805 RVA: 0x0000FE64 File Offset: 0x0000E064
			// (set) Token: 0x06000326 RID: 806 RVA: 0x0000390D File Offset: 0x00001B0D
			public unsafe int _endIndex_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__endIndex_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__endIndex_5__7)) = value;
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000327 RID: 807 RVA: 0x0000FE8C File Offset: 0x0000E08C
			// (set) Token: 0x06000328 RID: 808 RVA: 0x00003928 File Offset: 0x00001B28
			public unsafe HttpResponseMessage _responseMessage_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__responseMessage_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr__responseMessage_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000329 RID: 809 RVA: 0x0000FEBC File Offset: 0x0000E0BC
			// (set) Token: 0x0600032A RID: 810 RVA: 0x00003947 File Offset: 0x00001B47
			public ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._ExecuteAsync_d__16.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<RequestError>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000209 RID: 521
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400020A RID: 522
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400020B RID: 523
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400020C RID: 524
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400020D RID: 525
			private static readonly IntPtr NativeFieldInfoPtr__httpClient_5__2;

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeFieldInfoPtr__result_5__3;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeFieldInfoPtr__fullContent_5__4;

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeFieldInfoPtr__boundary_5__5;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeFieldInfoPtr__requestIndex_5__6;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeFieldInfoPtr__endIndex_5__7;

			// Token: 0x04000216 RID: 534
			private static readonly IntPtr NativeFieldInfoPtr__responseMessage_5__8;

			// Token: 0x04000217 RID: 535
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x04000218 RID: 536
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000219 RID: 537
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200003A RID: 58
		[ObfuscatedName("Google.Apis.Requests.BatchRequest+<CreateOuterRequestContent>d__18")]
		public sealed class _CreateOuterRequestContent_d__18 : ValueType
		{
			// Token: 0x0600032B RID: 811 RVA: 0x0000FEEC File Offset: 0x0000E0EC
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateOuterRequestContent_d__18()
			{
				Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "<CreateOuterRequestContent>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr);
				BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, "<>1__state");
				BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, "<>t__builder");
				BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr_requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, "requests");
				BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr__mixedContent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, "<mixedContent>5__2");
				BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, "<>7__wrap2");
				BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, "<>7__wrap3");
				BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, "<>u__1");
				BatchRequest._CreateOuterRequestContent_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, 100663538);
				BatchRequest._CreateOuterRequestContent_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr, 100663539);
			}

			// Token: 0x0600032C RID: 812 RVA: 0x0000FFCC File Offset: 0x0000E1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197358, XrefRangeEnd = 1197425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._CreateOuterRequestContent_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00010004 File Offset: 0x0000E204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197425, XrefRangeEnd = 1197431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._CreateOuterRequestContent_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00003975 File Offset: 0x00001B75
			public _CreateOuterRequestContent_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600032F RID: 815 RVA: 0x0000397E File Offset: 0x00001B7E
			public _CreateOuterRequestContent_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest._CreateOuterRequestContent_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000330 RID: 816 RVA: 0x0001004C File Offset: 0x0000E24C
			// (set) Token: 0x06000331 RID: 817 RVA: 0x00003990 File Offset: 0x00001B90
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000332 RID: 818 RVA: 0x00010074 File Offset: 0x0000E274
			// (set) Token: 0x06000333 RID: 819 RVA: 0x000039AB File Offset: 0x00001BAB
			public AsyncTaskMethodBuilder<HttpContent> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpContent>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpContent>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpContent>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000334 RID: 820 RVA: 0x000100A4 File Offset: 0x0000E2A4
			// (set) Token: 0x06000335 RID: 821 RVA: 0x000039D9 File Offset: 0x00001BD9
			public unsafe IEnumerable<IClientServiceRequest> requests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr_requests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<IClientServiceRequest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr_requests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000336 RID: 822 RVA: 0x000100D4 File Offset: 0x0000E2D4
			// (set) Token: 0x06000337 RID: 823 RVA: 0x000039F8 File Offset: 0x00001BF8
			public unsafe MultipartContent _mixedContent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr__mixedContent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipartContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr__mixedContent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000338 RID: 824 RVA: 0x00010104 File Offset: 0x0000E304
			// (set) Token: 0x06000339 RID: 825 RVA: 0x00003A17 File Offset: 0x00001C17
			public unsafe IEnumerator<IClientServiceRequest> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IClientServiceRequest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x0600033A RID: 826 RVA: 0x00010134 File Offset: 0x0000E334
			// (set) Token: 0x0600033B RID: 827 RVA: 0x00003A36 File Offset: 0x00001C36
			public unsafe MultipartContent __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipartContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x0600033C RID: 828 RVA: 0x00010164 File Offset: 0x0000E364
			// (set) Token: 0x0600033D RID: 829 RVA: 0x00003A55 File Offset: 0x00001C55
			public ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateOuterRequestContent_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpContent>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeFieldInfoPtr_requests;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeFieldInfoPtr__mixedContent_5__2;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200003B RID: 59
		[ObfuscatedName("Google.Apis.Requests.BatchRequest+<CreateIndividualRequest>d__19")]
		public sealed class _CreateIndividualRequest_d__19 : ValueType
		{
			// Token: 0x0600033E RID: 830 RVA: 0x00010194 File Offset: 0x0000E394
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateIndividualRequest_d__19()
			{
				Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "<CreateIndividualRequest>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr);
				BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr, "<>1__state");
				BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr, "<>t__builder");
				BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr, "request");
				BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr, "<>u__1");
				BatchRequest._CreateIndividualRequest_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr, 100663540);
				BatchRequest._CreateIndividualRequest_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr, 100663541);
			}

			// Token: 0x0600033F RID: 831 RVA: 0x00010238 File Offset: 0x0000E438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197431, XrefRangeEnd = 1197481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._CreateIndividualRequest_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000340 RID: 832 RVA: 0x00010270 File Offset: 0x0000E470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197481, XrefRangeEnd = 1197487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._CreateIndividualRequest_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000341 RID: 833 RVA: 0x00003A83 File Offset: 0x00001C83
			public _CreateIndividualRequest_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000342 RID: 834 RVA: 0x00003A8C File Offset: 0x00001C8C
			public _CreateIndividualRequest_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest._CreateIndividualRequest_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000343 RID: 835 RVA: 0x000102B8 File Offset: 0x0000E4B8
			// (set) Token: 0x06000344 RID: 836 RVA: 0x00003A9E File Offset: 0x00001C9E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000345 RID: 837 RVA: 0x000102E0 File Offset: 0x0000E4E0
			// (set) Token: 0x06000346 RID: 838 RVA: 0x00003AB9 File Offset: 0x00001CB9
			public AsyncTaskMethodBuilder<HttpContent> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpContent>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpContent>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpContent>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000347 RID: 839 RVA: 0x00010310 File Offset: 0x0000E510
			// (set) Token: 0x06000348 RID: 840 RVA: 0x00003AE7 File Offset: 0x00001CE7
			public unsafe IClientServiceRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientServiceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000349 RID: 841 RVA: 0x00010340 File Offset: 0x0000E540
			// (set) Token: 0x0600034A RID: 842 RVA: 0x00003B06 File Offset: 0x00001D06
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateIndividualRequest_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200003C RID: 60
		[ObfuscatedName("Google.Apis.Requests.BatchRequest+<CreateRequestContentString>d__20")]
		public sealed class _CreateRequestContentString_d__20 : ValueType
		{
			// Token: 0x0600034B RID: 843 RVA: 0x00010370 File Offset: 0x0000E570
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateRequestContentString_d__20()
			{
				Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRequest>.NativeClassPtr, "<CreateRequestContentString>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr);
				BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr, "<>1__state");
				BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr, "<>t__builder");
				BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr_requestMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr, "requestMessage");
				BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr__sb_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr, "<sb>5__2");
				BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr, "<>u__1");
				BatchRequest._CreateRequestContentString_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr, 100663542);
				BatchRequest._CreateRequestContentString_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr, 100663543);
			}

			// Token: 0x0600034C RID: 844 RVA: 0x00010428 File Offset: 0x0000E628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197487, XrefRangeEnd = 1197576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._CreateRequestContentString_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00010460 File Offset: 0x0000E660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197576, XrefRangeEnd = 1197582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRequest._CreateRequestContentString_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600034E RID: 846 RVA: 0x00003B34 File Offset: 0x00001D34
			public _CreateRequestContentString_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600034F RID: 847 RVA: 0x00003B3D File Offset: 0x00001D3D
			public _CreateRequestContentString_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRequest._CreateRequestContentString_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000350 RID: 848 RVA: 0x000104A8 File Offset: 0x0000E6A8
			// (set) Token: 0x06000351 RID: 849 RVA: 0x00003B4F File Offset: 0x00001D4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000352 RID: 850 RVA: 0x000104D0 File Offset: 0x0000E6D0
			// (set) Token: 0x06000353 RID: 851 RVA: 0x00003B6A File Offset: 0x00001D6A
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000354 RID: 852 RVA: 0x00010500 File Offset: 0x0000E700
			// (set) Token: 0x06000355 RID: 853 RVA: 0x00003B98 File Offset: 0x00001D98
			public unsafe HttpRequestMessage requestMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr_requestMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr_requestMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000356 RID: 854 RVA: 0x00010530 File Offset: 0x0000E730
			// (set) Token: 0x06000357 RID: 855 RVA: 0x00003BB7 File Offset: 0x00001DB7
			public unsafe StringBuilder _sb_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr__sb_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr__sb_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000358 RID: 856 RVA: 0x00010560 File Offset: 0x0000E760
			// (set) Token: 0x06000359 RID: 857 RVA: 0x00003BD6 File Offset: 0x00001DD6
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRequest._CreateRequestContentString_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeFieldInfoPtr_requestMessage;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeFieldInfoPtr__sb_5__2;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200003D RID: 61
		private sealed class MethodInfoStoreGeneric_Queue_Public_Void_IClientServiceRequest_OnResponse_1_TResponse_0<TResponse>
		{
			// Token: 0x04000230 RID: 560
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BatchRequest.NativeMethodInfoPtr_Queue_Public_Void_IClientServiceRequest_OnResponse_1_TResponse_0, Il2CppClassPointerStore<BatchRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) }))));
		}
	}
}
