using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000003 RID: 3
	public class HttpClientHandler : HttpMessageHandler
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00004404 File Offset: 0x00002604
		// Note: this type is marked as 'beforefieldinit'.
		static HttpClientHandler()
		{
			Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpClientHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr);
			HttpClientHandler.NativeFieldInfoPtr__delegatingHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, "_delegatingHandler");
			HttpClientHandler.NativeFieldInfoPtr__clientCertificateOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, "_clientCertificateOptions");
			HttpClientHandler.NativeMethodInfoPtr_CreateDefaultHandler_Private_Static_IMonoHttpClientHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663299);
			HttpClientHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663300);
			HttpClientHandler.NativeMethodInfoPtr__ctor_Internal_Void_IMonoHttpClientHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663301);
			HttpClientHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663302);
			HttpClientHandler.NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663303);
			HttpClientHandler.NativeMethodInfoPtr_get_SupportsRedirectConfiguration_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663304);
			HttpClientHandler.NativeMethodInfoPtr_ThrowForModifiedManagedSslOptionsIfStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663305);
			HttpClientHandler.NativeMethodInfoPtr_get_ClientCertificateOptions_Public_get_ClientCertificateOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663306);
			HttpClientHandler.NativeMethodInfoPtr_set_ClientCertificateOptions_Public_set_Void_ClientCertificateOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663307);
			HttpClientHandler.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663308);
			HttpClientHandler.NativeMethodInfoPtr_set_AutomaticDecompression_Public_set_Void_DecompressionMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663309);
			HttpClientHandler.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663310);
			HttpClientHandler.NativeMethodInfoPtr_SetWebRequestTimeout_Internal_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663311);
			HttpClientHandler.NativeMethodInfoPtr_SendAsync_FamOrAssem_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663312);
			HttpClientHandler.NativeMethodInfoPtr__set_ClientCertificateOptions_b__23_0_Private_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00004588 File Offset: 0x00002788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170125, XrefRangeEnd = 1170154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMonoHttpClientHandler CreateDefaultHandler()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_CreateDefaultHandler_Private_Static_IMonoHttpClientHandler_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMonoHttpClientHandler>(intPtr3) : null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000045BC File Offset: 0x000027BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1170186, RefRangeEnd = 1170188, XrefRangeStart = 1170154, XrefRangeEnd = 1170186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpClientHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000045F8 File Offset: 0x000027F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170188, XrefRangeEnd = 1170191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpClientHandler(IMonoHttpClientHandler handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr__ctor_Internal_Void_IMonoHttpClientHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00004644 File Offset: 0x00002844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170191, XrefRangeEnd = 1170194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClientHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00004690 File Offset: 0x00002890
		public unsafe virtual bool SupportsAutomaticDecompression
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170194, XrefRangeEnd = 1170198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClientHandler.NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000046D8 File Offset: 0x000028D8
		public unsafe virtual bool SupportsRedirectConfiguration
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClientHandler.NativeMethodInfoPtr_get_SupportsRedirectConfiguration_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00004720 File Offset: 0x00002920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1170205, RefRangeEnd = 1170207, XrefRangeStart = 1170198, XrefRangeEnd = 1170205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowForModifiedManagedSslOptionsIfStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_ThrowForModifiedManagedSslOptionsIfStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00004754 File Offset: 0x00002954
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00004790 File Offset: 0x00002990
		public unsafe ClientCertificateOption ClientCertificateOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_get_ClientCertificateOptions_Public_get_ClientCertificateOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1170243, RefRangeEnd = 1170245, XrefRangeStart = 1170207, XrefRangeEnd = 1170243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_set_ClientCertificateOptions_Public_set_Void_ClientCertificateOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000047D0 File Offset: 0x000029D0
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170245, XrefRangeEnd = 1170255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00004810 File Offset: 0x00002A10
		public unsafe DecompressionMethods AutomaticDecompression
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1170260, RefRangeEnd = 1170262, XrefRangeStart = 1170255, XrefRangeEnd = 1170260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_set_AutomaticDecompression_Public_set_Void_DecompressionMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00004850 File Offset: 0x00002A50
		public unsafe bool AllowAutoRedirect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1170267, RefRangeEnd = 1170268, XrefRangeStart = 1170262, XrefRangeEnd = 1170267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004890 File Offset: 0x00002A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170268, XrefRangeEnd = 1170273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWebRequestTimeout(TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr_SetWebRequestTimeout_Internal_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000048D0 File Offset: 0x00002AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170273, XrefRangeEnd = 1170278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClientHandler.NativeMethodInfoPtr_SendAsync_FamOrAssem_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004944 File Offset: 0x00002B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170278, XrefRangeEnd = 1170299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate _set_ClientCertificateOptions_b__23_0(Object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.NativeMethodInfoPtr__set_ClientCertificateOptions_b__23_0_Private_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002059 File Offset: 0x00000259
		public HttpClientHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000049E0 File Offset: 0x00002BE0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe IMonoHttpClientHandler _delegatingHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClientHandler.NativeFieldInfoPtr__delegatingHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMonoHttpClientHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClientHandler.NativeFieldInfoPtr__delegatingHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00004A10 File Offset: 0x00002C10
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002081 File Offset: 0x00000281
		public unsafe ClientCertificateOption _clientCertificateOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClientHandler.NativeFieldInfoPtr__clientCertificateOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpClientHandler.NativeFieldInfoPtr__clientCertificateOptions)) = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr__delegatingHandler;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr__clientCertificateOptions;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultHandler_Private_Static_IMonoHttpClientHandler_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMonoHttpClientHandler_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsRedirectConfiguration_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_ThrowForModifiedManagedSslOptionsIfStarted_Private_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateOptions_Public_get_ClientCertificateOption_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateOptions_Public_set_Void_ClientCertificateOption_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_set_AutomaticDecompression_Public_set_Void_DecompressionMethods_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAutoRedirect_Public_set_Void_Boolean_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_SetWebRequestTimeout_Internal_Void_TimeSpan_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_FamOrAssem_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__set_ClientCertificateOptions_b__23_0_Private_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;

		// Token: 0x0200003C RID: 60
		[ObfuscatedName("System.Net.Http.HttpClientHandler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060003C1 RID: 961 RVA: 0x00013F6C File Offset: 0x0001216C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HttpClientHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpClientHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpClientHandler.__c>.NativeClassPtr);
				HttpClientHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClientHandler.__c>.NativeClassPtr, "<>9");
				HttpClientHandler.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClientHandler.__c>.NativeClassPtr, "<>9__23_1");
				HttpClientHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler.__c>.NativeClassPtr, 100663315);
				HttpClientHandler.__c.NativeMethodInfoPtr__set_ClientCertificateOptions_b__23_1_Internal_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientHandler.__c>.NativeClassPtr, 100663316);
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x00013FE8 File Offset: 0x000121E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClientHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00014024 File Offset: 0x00012224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170124, XrefRangeEnd = 1170125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509Certificate _set_ClientCertificateOptions_b__23_1(Object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientHandler.__c.NativeMethodInfoPtr__set_ClientCertificateOptions_b__23_1_Internal_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x000034AA File Offset: 0x000016AA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060003C5 RID: 965 RVA: 0x000140C0 File Offset: 0x000122C0
			// (set) Token: 0x060003C6 RID: 966 RVA: 0x000034B3 File Offset: 0x000016B3
			public unsafe static HttpClientHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpClientHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClientHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpClientHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060003C7 RID: 967 RVA: 0x000140E8 File Offset: 0x000122E8
			// (set) Token: 0x060003C8 RID: 968 RVA: 0x000034C5 File Offset: 0x000016C5
			public unsafe static LocalCertificateSelectionCallback __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpClientHandler.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalCertificateSelectionCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpClientHandler.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002CB RID: 715
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002CC RID: 716
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeMethodInfoPtr__set_ClientCertificateOptions_b__23_1_Internal_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
		}
	}
}
