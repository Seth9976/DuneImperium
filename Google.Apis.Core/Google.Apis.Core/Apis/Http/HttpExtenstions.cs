using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Http
{
	// Token: 0x0200002D RID: 45
	public static class HttpExtenstions : Object
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0000BACC File Offset: 0x00009CCC
		// Note: this type is marked as 'beforefieldinit'.
		static HttpExtenstions()
		{
			Il2CppClassPointerStore<HttpExtenstions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "HttpExtenstions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpExtenstions>.NativeClassPtr);
			HttpExtenstions.NativeMethodInfoPtr_IsRedirectStatusCode_Internal_Static_Boolean_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpExtenstions>.NativeClassPtr, 100663618);
			HttpExtenstions.NativeMethodInfoPtr_SetEmptyContent_Public_Static_HttpContent_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpExtenstions>.NativeClassPtr, 100663619);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000BB24 File Offset: 0x00009D24
		[CallerCount(0)]
		public unsafe static bool IsRedirectStatusCode(this HttpResponseMessage message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpExtenstions.NativeMethodInfoPtr_IsRedirectStatusCode_Internal_Static_Boolean_HttpResponseMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000BB68 File Offset: 0x00009D68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1212416, RefRangeEnd = 1212418, XrefRangeStart = 1212403, XrefRangeEnd = 1212416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HttpContent SetEmptyContent(this HttpRequestMessage request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpExtenstions.NativeMethodInfoPtr_SetEmptyContent_Public_Static_HttpContent_HttpRequestMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr3) : null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public HttpExtenstions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_IsRedirectStatusCode_Internal_Static_Boolean_HttpResponseMessage_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_SetEmptyContent_Public_Static_HttpContent_HttpRequestMessage_0;
	}
}
