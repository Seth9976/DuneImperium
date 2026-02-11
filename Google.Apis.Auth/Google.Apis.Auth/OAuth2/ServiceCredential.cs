using System;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200001D RID: 29
	public class ServiceCredential : Object
	{
		// Token: 0x0600016D RID: 365 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceCredential()
		{
			Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "ServiceCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr);
			ServiceCredential.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "Logger");
			ServiceCredential.NativeFieldInfoPtr__TokenServerUrl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<TokenServerUrl>k__BackingField");
			ServiceCredential.NativeFieldInfoPtr__Clock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<Clock>k__BackingField");
			ServiceCredential.NativeFieldInfoPtr__AccessMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<AccessMethod>k__BackingField");
			ServiceCredential.NativeFieldInfoPtr__HttpClient_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<HttpClient>k__BackingField");
			ServiceCredential.NativeFieldInfoPtr__HttpClientFactory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<HttpClientFactory>k__BackingField");
			ServiceCredential.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<DefaultExponentialBackOffPolicy>k__BackingField");
			ServiceCredential.NativeFieldInfoPtr__refreshManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "_refreshManager");
			ServiceCredential.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663655);
			ServiceCredential.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663656);
			ServiceCredential.NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663657);
			ServiceCredential.NativeMethodInfoPtr_get_HttpClient_Public_get_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663658);
			ServiceCredential.NativeMethodInfoPtr_get_HttpClientFactory_Internal_get_IHttpClientFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663659);
			ServiceCredential.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Internal_get_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663660);
			ServiceCredential.NativeMethodInfoPtr_get_Token_Public_get_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663661);
			ServiceCredential.NativeMethodInfoPtr_set_Token_Public_set_Void_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663662);
			ServiceCredential.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663663);
			ServiceCredential.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663664);
			ServiceCredential.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663665);
			ServiceCredential.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663666);
			ServiceCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_New_Task_1_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663667);
			ServiceCredential.NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Abstract_Virtual_New_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, 100663668);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000BF90 File Offset: 0x0000A190
		public unsafe string TokenServerUrl
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		public unsafe IClock Clock
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr3) : null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000C008 File Offset: 0x0000A208
		public unsafe IAccessMethod AccessMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr3) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000C048 File Offset: 0x0000A248
		public unsafe ConfigurableHttpClient HttpClient
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_get_HttpClient_Public_get_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000C088 File Offset: 0x0000A288
		public unsafe IHttpClientFactory HttpClientFactory
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_get_HttpClientFactory_Internal_get_IHttpClientFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr3) : null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		public unsafe ExponentialBackOffPolicy DefaultExponentialBackOffPolicy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Internal_get_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000C104 File Offset: 0x0000A304
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000C144 File Offset: 0x0000A344
		public unsafe TokenResponse Token
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155841, XrefRangeEnd = 1155843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_get_Token_Public_get_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155843, XrefRangeEnd = 1155845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_set_Token_Public_set_Void_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000C188 File Offset: 0x0000A388
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1155908, RefRangeEnd = 1155911, XrefRangeStart = 1155845, XrefRangeEnd = 1155908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCredential(ServiceCredential.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155911, XrefRangeEnd = 1155914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ConfigurableHttpClient httpClient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpClient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000C218 File Offset: 0x0000A418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155914, XrefRangeEnd = 1155926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000C280 File Offset: 0x0000A480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155926, XrefRangeEnd = 1155941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_New_Task_1_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000C344 File Offset: 0x0000A544
		[CallerCount(0)]
		public unsafe virtual Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceCredential.NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Abstract_Virtual_New_Task_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002A0A File Offset: 0x00000C0A
		public ServiceCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceCredential.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceCredential.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002A25 File Offset: 0x00000C25
		public unsafe string _TokenServerUrl_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__TokenServerUrl_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__TokenServerUrl_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002A44 File Offset: 0x00000C44
		public unsafe IClock _Clock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__Clock_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__Clock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000C424 File Offset: 0x0000A624
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002A63 File Offset: 0x00000C63
		public unsafe IAccessMethod _AccessMethod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__AccessMethod_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__AccessMethod_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000C454 File Offset: 0x0000A654
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002A82 File Offset: 0x00000C82
		public unsafe ConfigurableHttpClient _HttpClient_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__HttpClient_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__HttpClient_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000C484 File Offset: 0x0000A684
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public unsafe IHttpClientFactory _HttpClientFactory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__HttpClientFactory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__HttpClientFactory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public unsafe ExponentialBackOffPolicy _DefaultExponentialBackOffPolicy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002ADB File Offset: 0x00000CDB
		public unsafe TokenRefreshManager _refreshManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__refreshManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenRefreshManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.NativeFieldInfoPtr__refreshManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr__TokenServerUrl_k__BackingField;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr__Clock_k__BackingField;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr__AccessMethod_k__BackingField;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr__HttpClient_k__BackingField;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr__HttpClientFactory_k__BackingField;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr__refreshManager;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_get_Clock_Public_get_IClock_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClient_Public_get_ConfigurableHttpClient_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClientFactory_Internal_get_IHttpClientFactory_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Internal_get_ExponentialBackOffPolicy_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_TokenResponse_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_TokenResponse_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Initializer_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_New_Task_1_String_String_CancellationToken_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Abstract_Virtual_New_Task_1_Boolean_CancellationToken_0;

		// Token: 0x02000058 RID: 88
		public class Initializer : Object
		{
			// Token: 0x06000570 RID: 1392 RVA: 0x000188FC File Offset: 0x00016AFC
			// Note: this type is marked as 'beforefieldinit'.
			static Initializer()
			{
				Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "Initializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr);
				ServiceCredential.Initializer.NativeFieldInfoPtr__TokenServerUrl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, "<TokenServerUrl>k__BackingField");
				ServiceCredential.Initializer.NativeFieldInfoPtr__Clock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, "<Clock>k__BackingField");
				ServiceCredential.Initializer.NativeFieldInfoPtr__AccessMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, "<AccessMethod>k__BackingField");
				ServiceCredential.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, "<HttpClientFactory>k__BackingField");
				ServiceCredential.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, "<DefaultExponentialBackOffPolicy>k__BackingField");
				ServiceCredential.Initializer.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663670);
				ServiceCredential.Initializer.NativeMethodInfoPtr_set_TokenServerUrl_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663671);
				ServiceCredential.Initializer.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663672);
				ServiceCredential.Initializer.NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663673);
				ServiceCredential.Initializer.NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663674);
				ServiceCredential.Initializer.NativeMethodInfoPtr_set_AccessMethod_Public_set_Void_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663675);
				ServiceCredential.Initializer.NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663676);
				ServiceCredential.Initializer.NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663677);
				ServiceCredential.Initializer.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663678);
				ServiceCredential.Initializer.NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663679);
				ServiceCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663680);
				ServiceCredential.Initializer.NativeMethodInfoPtr__ctor_Internal_Void_ServiceCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr, 100663681);
			}

			// Token: 0x170001FD RID: 509
			// (get) Token: 0x06000571 RID: 1393 RVA: 0x00018A7C File Offset: 0x00016C7C
			// (set) Token: 0x06000572 RID: 1394 RVA: 0x00018AB4 File Offset: 0x00016CB4
			public unsafe string TokenServerUrl
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_set_TokenServerUrl_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x00018AF8 File Offset: 0x00016CF8
			// (set) Token: 0x06000574 RID: 1396 RVA: 0x00018B38 File Offset: 0x00016D38
			public unsafe IClock Clock
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x00018B7C File Offset: 0x00016D7C
			// (set) Token: 0x06000576 RID: 1398 RVA: 0x00018BBC File Offset: 0x00016DBC
			public unsafe IAccessMethod AccessMethod
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_set_AccessMethod_Public_set_Void_IAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000200 RID: 512
			// (get) Token: 0x06000577 RID: 1399 RVA: 0x00018C00 File Offset: 0x00016E00
			// (set) Token: 0x06000578 RID: 1400 RVA: 0x00018C40 File Offset: 0x00016E40
			public unsafe IHttpClientFactory HttpClientFactory
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x00018C84 File Offset: 0x00016E84
			// (set) Token: 0x0600057A RID: 1402 RVA: 0x00018CC0 File Offset: 0x00016EC0
			public unsafe ExponentialBackOffPolicy DefaultExponentialBackOffPolicy
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00018D00 File Offset: 0x00016F00
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1155767, RefRangeEnd = 1155773, XrefRangeStart = 1155755, XrefRangeEnd = 1155767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(string tokenServerUrl)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenServerUrl);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00018D4C File Offset: 0x00016F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155773, XrefRangeEnd = 1155778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(ServiceCredential other)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCredential.Initializer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.Initializer.NativeMethodInfoPtr__ctor_Internal_Void_ServiceCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x00004F75 File Offset: 0x00003175
			public Initializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x0600057E RID: 1406 RVA: 0x00018D98 File Offset: 0x00016F98
			// (set) Token: 0x0600057F RID: 1407 RVA: 0x00004F7E File Offset: 0x0000317E
			public unsafe string _TokenServerUrl_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__TokenServerUrl_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__TokenServerUrl_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x06000580 RID: 1408 RVA: 0x00018DC0 File Offset: 0x00016FC0
			// (set) Token: 0x06000581 RID: 1409 RVA: 0x00004F9D File Offset: 0x0000319D
			public unsafe IClock _Clock_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__Clock_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__Clock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x06000582 RID: 1410 RVA: 0x00018DF0 File Offset: 0x00016FF0
			// (set) Token: 0x06000583 RID: 1411 RVA: 0x00004FBC File Offset: 0x000031BC
			public unsafe IAccessMethod _AccessMethod_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__AccessMethod_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__AccessMethod_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x06000584 RID: 1412 RVA: 0x00018E20 File Offset: 0x00017020
			// (set) Token: 0x06000585 RID: 1413 RVA: 0x00004FDB File Offset: 0x000031DB
			public unsafe IHttpClientFactory _HttpClientFactory_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001FC RID: 508
			// (get) Token: 0x06000586 RID: 1414 RVA: 0x00018E50 File Offset: 0x00017050
			// (set) Token: 0x06000587 RID: 1415 RVA: 0x00004FFA File Offset: 0x000031FA
			public unsafe ExponentialBackOffPolicy _DefaultExponentialBackOffPolicy_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField)) = value;
				}
			}

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr__TokenServerUrl_k__BackingField;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeFieldInfoPtr__Clock_k__BackingField;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeFieldInfoPtr__AccessMethod_k__BackingField;

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeFieldInfoPtr__HttpClientFactory_k__BackingField;

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField;

			// Token: 0x0400035C RID: 860
			private static readonly IntPtr NativeMethodInfoPtr_get_TokenServerUrl_Public_get_String_0;

			// Token: 0x0400035D RID: 861
			private static readonly IntPtr NativeMethodInfoPtr_set_TokenServerUrl_Private_set_Void_String_0;

			// Token: 0x0400035E RID: 862
			private static readonly IntPtr NativeMethodInfoPtr_get_Clock_Public_get_IClock_0;

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0;

			// Token: 0x04000360 RID: 864
			private static readonly IntPtr NativeMethodInfoPtr_get_AccessMethod_Public_get_IAccessMethod_0;

			// Token: 0x04000361 RID: 865
			private static readonly IntPtr NativeMethodInfoPtr_set_AccessMethod_Public_set_Void_IAccessMethod_0;

			// Token: 0x04000362 RID: 866
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0;

			// Token: 0x04000363 RID: 867
			private static readonly IntPtr NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0;

			// Token: 0x04000364 RID: 868
			private static readonly IntPtr NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0;

			// Token: 0x04000365 RID: 869
			private static readonly IntPtr NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0;

			// Token: 0x04000366 RID: 870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04000367 RID: 871
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ServiceCredential_0;
		}

		// Token: 0x02000059 RID: 89
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ServiceCredential+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000588 RID: 1416 RVA: 0x00018E78 File Offset: 0x00017078
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ServiceCredential.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCredential.__c>.NativeClassPtr);
				ServiceCredential.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential.__c>.NativeClassPtr, "<>9");
				ServiceCredential.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential.__c>.NativeClassPtr, "<>9__24_0");
				ServiceCredential.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.__c>.NativeClassPtr, 100663683);
				ServiceCredential.__c.NativeMethodInfoPtr___ctor_b__24_0_Internal_BackOffHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential.__c>.NativeClassPtr, 100663684);
			}

			// Token: 0x06000589 RID: 1417 RVA: 0x00018EF4 File Offset: 0x000170F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCredential.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x00018F30 File Offset: 0x00017130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155778, XrefRangeEnd = 1155786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BackOffHandler __ctor_b__24_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential.__c.NativeMethodInfoPtr___ctor_b__24_0_Internal_BackOffHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BackOffHandler>(intPtr3) : null;
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x00005015 File Offset: 0x00003215
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x0600058C RID: 1420 RVA: 0x00018F70 File Offset: 0x00017170
			// (set) Token: 0x0600058D RID: 1421 RVA: 0x0000501E File Offset: 0x0000321E
			public unsafe static ServiceCredential.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ServiceCredential.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceCredential.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ServiceCredential.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x0600058E RID: 1422 RVA: 0x00018F98 File Offset: 0x00017198
			// (set) Token: 0x0600058F RID: 1423 RVA: 0x00005030 File Offset: 0x00003230
			public unsafe static Func<BackOffHandler> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ServiceCredential.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BackOffHandler>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ServiceCredential.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000368 RID: 872
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000369 RID: 873
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400036A RID: 874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400036B RID: 875
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_0_Internal_BackOffHandler_0;
		}

		// Token: 0x0200005A RID: 90
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ServiceCredential+<InterceptAsync>d__26")]
		public sealed class _InterceptAsync_d__26 : ValueType
		{
			// Token: 0x06000590 RID: 1424 RVA: 0x00018FC0 File Offset: 0x000171C0
			// Note: this type is marked as 'beforefieldinit'.
			static _InterceptAsync_d__26()
			{
				Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<InterceptAsync>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr);
				ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, "<>1__state");
				ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, "<>t__builder");
				ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, "<>4__this");
				ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, "request");
				ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, "cancellationToken");
				ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, "<>u__1");
				ServiceCredential._InterceptAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, 100663685);
				ServiceCredential._InterceptAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr, 100663686);
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x0001908C File Offset: 0x0001728C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155786, XrefRangeEnd = 1155806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential._InterceptAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x000190C4 File Offset: 0x000172C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155806, XrefRangeEnd = 1155810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential._InterceptAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x00005042 File Offset: 0x00003242
			public _InterceptAsync_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x0000504B File Offset: 0x0000324B
			public _InterceptAsync_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCredential._InterceptAsync_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001910C File Offset: 0x0001730C
			// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000505D File Offset: 0x0000325D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x06000597 RID: 1431 RVA: 0x00019134 File Offset: 0x00017334
			// (set) Token: 0x06000598 RID: 1432 RVA: 0x00005078 File Offset: 0x00003278
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x00019164 File Offset: 0x00017364
			// (set) Token: 0x0600059A RID: 1434 RVA: 0x000050A6 File Offset: 0x000032A6
			public unsafe ServiceCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x00019194 File Offset: 0x00017394
			// (set) Token: 0x0600059C RID: 1436 RVA: 0x000050C5 File Offset: 0x000032C5
			public unsafe HttpRequestMessage request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000208 RID: 520
			// (get) Token: 0x0600059D RID: 1437 RVA: 0x000191C4 File Offset: 0x000173C4
			// (set) Token: 0x0600059E RID: 1438 RVA: 0x000050E4 File Offset: 0x000032E4
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x0600059F RID: 1439 RVA: 0x000191F4 File Offset: 0x000173F4
			// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00005112 File Offset: 0x00003312
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._InterceptAsync_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400036C RID: 876
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400036D RID: 877
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400036E RID: 878
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400036F RID: 879
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000370 RID: 880
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000371 RID: 881
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000372 RID: 882
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000373 RID: 883
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200005B RID: 91
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ServiceCredential+<HandleResponseAsync>d__27")]
		public sealed class _HandleResponseAsync_d__27 : ValueType
		{
			// Token: 0x060005A1 RID: 1441 RVA: 0x00019224 File Offset: 0x00017424
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleResponseAsync_d__27()
			{
				Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceCredential>.NativeClassPtr, "<HandleResponseAsync>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr);
				ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr, "<>1__state");
				ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr, "<>t__builder");
				ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr, "args");
				ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr, "<>4__this");
				ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr, "<>u__1");
				ServiceCredential._HandleResponseAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr, 100663687);
				ServiceCredential._HandleResponseAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr, 100663688);
			}

			// Token: 0x060005A2 RID: 1442 RVA: 0x000192DC File Offset: 0x000174DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155810, XrefRangeEnd = 1155835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential._HandleResponseAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005A3 RID: 1443 RVA: 0x00019314 File Offset: 0x00017514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155835, XrefRangeEnd = 1155841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCredential._HandleResponseAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005A4 RID: 1444 RVA: 0x00005140 File Offset: 0x00003340
			public _HandleResponseAsync_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005A5 RID: 1445 RVA: 0x00005149 File Offset: 0x00003349
			public _HandleResponseAsync_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCredential._HandleResponseAsync_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001935C File Offset: 0x0001755C
			// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0000515B File Offset: 0x0000335B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00019384 File Offset: 0x00017584
			// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00005176 File Offset: 0x00003376
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x060005AA RID: 1450 RVA: 0x000193B4 File Offset: 0x000175B4
			// (set) Token: 0x060005AB RID: 1451 RVA: 0x000051A4 File Offset: 0x000033A4
			public unsafe HandleUnsuccessfulResponseArgs args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandleUnsuccessfulResponseArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x060005AC RID: 1452 RVA: 0x000193E4 File Offset: 0x000175E4
			// (set) Token: 0x060005AD RID: 1453 RVA: 0x000051C3 File Offset: 0x000033C3
			public unsafe ServiceCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x060005AE RID: 1454 RVA: 0x00019414 File Offset: 0x00017614
			// (set) Token: 0x060005AF RID: 1455 RVA: 0x000051E2 File Offset: 0x000033E2
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCredential._HandleResponseAsync_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000374 RID: 884
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000375 RID: 885
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000376 RID: 886
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x04000377 RID: 887
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000378 RID: 888
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000379 RID: 889
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400037A RID: 890
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
