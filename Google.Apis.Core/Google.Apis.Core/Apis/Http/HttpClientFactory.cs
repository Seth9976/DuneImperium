using System;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Http
{
	// Token: 0x0200002B RID: 43
	public class HttpClientFactory : Object
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x0000B754 File Offset: 0x00009954
		// Note: this type is marked as 'beforefieldinit'.
		static HttpClientFactory()
		{
			Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "HttpClientFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr);
			HttpClientFactory.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr, "Logger");
			HttpClientFactory.NativeMethodInfoPtr_CreateHttpClient_Public_Virtual_Final_New_ConfigurableHttpClient_CreateHttpClientArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr, 100663609);
			HttpClientFactory.NativeMethodInfoPtr_CreateHandler_Protected_Virtual_New_HttpMessageHandler_CreateHttpClientArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr, 100663610);
			HttpClientFactory.NativeMethodInfoPtr_CreateAndConfigureClientHandler_Private_HttpClientHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr, 100663611);
			HttpClientFactory.NativeMethodInfoPtr_CreateClientHandler_Protected_Virtual_New_HttpClientHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr, 100663612);
			HttpClientFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr, 100663613);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000B7FC File Offset: 0x000099FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1212358, RefRangeEnd = 1212359, XrefRangeStart = 1212318, XrefRangeEnd = 1212358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientFactory.NativeMethodInfoPtr_CreateHttpClient_Public_Virtual_Final_New_ConfigurableHttpClient_CreateHttpClientArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000B84C File Offset: 0x00009A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212359, XrefRangeEnd = 1212395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual HttpMessageHandler CreateHandler(CreateHttpClientArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClientFactory.NativeMethodInfoPtr_CreateHandler_Protected_Virtual_New_HttpMessageHandler_CreateHttpClientArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpMessageHandler>(intPtr3) : null;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1212397, RefRangeEnd = 1212399, XrefRangeStart = 1212395, XrefRangeEnd = 1212397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpClientHandler CreateAndConfigureClientHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientFactory.NativeMethodInfoPtr_CreateAndConfigureClientHandler_Private_HttpClientHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpClientHandler>(intPtr3) : null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212399, XrefRangeEnd = 1212403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual HttpClientHandler CreateClientHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpClientFactory.NativeMethodInfoPtr_CreateClientHandler_Protected_Virtual_New_HttpClientHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpClientHandler>(intPtr3) : null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000B934 File Offset: 0x00009B34
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpClientFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002C26 File Offset: 0x00000E26
		public HttpClientFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000B970 File Offset: 0x00009B70
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002C2F File Offset: 0x00000E2F
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpClientFactory.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpClientFactory.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_CreateHttpClient_Public_Virtual_Final_New_ConfigurableHttpClient_CreateHttpClientArgs_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandler_Protected_Virtual_New_HttpMessageHandler_CreateHttpClientArgs_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndConfigureClientHandler_Private_HttpClientHandler_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientHandler_Protected_Virtual_New_HttpClientHandler_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200005E RID: 94
		[ObfuscatedName("Google.Apis.Http.HttpClientFactory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060003A8 RID: 936 RVA: 0x00010AD8 File Offset: 0x0000ECD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HttpClientFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpClientFactory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpClientFactory.__c>.NativeClassPtr);
				HttpClientFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClientFactory.__c>.NativeClassPtr, "<>9");
				HttpClientFactory.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpClientFactory.__c>.NativeClassPtr, "<>9__2_0");
				HttpClientFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientFactory.__c>.NativeClassPtr, 100663616);
				HttpClientFactory.__c.NativeMethodInfoPtr__CreateHandler_b__2_0_Internal_Boolean_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpClientFactory.__c>.NativeClassPtr, 100663617);
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x00010B54 File Offset: 0x0000ED54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpClientFactory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003AA RID: 938 RVA: 0x00010B90 File Offset: 0x0000ED90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212317, XrefRangeEnd = 1212318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateHandler_b__2_0(HttpRequestMessage request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpClientFactory.__c.NativeMethodInfoPtr__CreateHandler_b__2_0_Internal_Boolean_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003AB RID: 939 RVA: 0x00003BDA File Offset: 0x00001DDA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060003AC RID: 940 RVA: 0x00010BE0 File Offset: 0x0000EDE0
			// (set) Token: 0x060003AD RID: 941 RVA: 0x00003BE3 File Offset: 0x00001DE3
			public unsafe static HttpClientFactory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpClientFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClientFactory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpClientFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060003AE RID: 942 RVA: 0x00010C08 File Offset: 0x0000EE08
			// (set) Token: 0x060003AF RID: 943 RVA: 0x00003BF5 File Offset: 0x00001DF5
			public unsafe static Func<HttpRequestMessage, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpClientFactory.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpRequestMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpClientFactory.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeMethodInfoPtr__CreateHandler_b__2_0_Internal_Boolean_HttpRequestMessage_0;
		}
	}
}
