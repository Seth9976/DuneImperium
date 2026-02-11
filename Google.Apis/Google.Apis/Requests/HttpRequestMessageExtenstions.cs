using System;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Requests
{
	// Token: 0x02000011 RID: 17
	public static class HttpRequestMessageExtenstions : Object
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0000A044 File Offset: 0x00008244
		// Note: this type is marked as 'beforefieldinit'.
		static HttpRequestMessageExtenstions()
		{
			Il2CppClassPointerStore<HttpRequestMessageExtenstions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "HttpRequestMessageExtenstions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpRequestMessageExtenstions>.NativeClassPtr);
			HttpRequestMessageExtenstions.NativeMethodInfoPtr_SetRequestSerailizedContent_Internal_Static_Void_HttpRequestMessage_IClientService_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessageExtenstions>.NativeClassPtr, 100663588);
			HttpRequestMessageExtenstions.NativeMethodInfoPtr_CreateZipContent_Internal_Static_HttpContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessageExtenstions>.NativeClassPtr, 100663589);
			HttpRequestMessageExtenstions.NativeMethodInfoPtr_CreateGZipStream_Private_Static_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessageExtenstions>.NativeClassPtr, 100663590);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1198493, RefRangeEnd = 1198495, XrefRangeStart = 1198455, XrefRangeEnd = 1198493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRequestSerailizedContent(this HttpRequestMessage request, IClientService service, Object body, bool gzipEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(service);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzipEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessageExtenstions.NativeMethodInfoPtr_SetRequestSerailizedContent_Internal_Static_Void_HttpRequestMessage_IClientService_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000A118 File Offset: 0x00008318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198495, XrefRangeEnd = 1198507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HttpContent CreateZipContent(string content)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessageExtenstions.NativeMethodInfoPtr_CreateZipContent_Internal_Static_HttpContent_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr3) : null;
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000A15C File Offset: 0x0000835C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1198534, RefRangeEnd = 1198536, XrefRangeStart = 1198507, XrefRangeEnd = 1198534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream CreateGZipStream(string serializedObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serializedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessageExtenstions.NativeMethodInfoPtr_CreateGZipStream_Private_Static_Stream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002736 File Offset: 0x00000936
		public HttpRequestMessageExtenstions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestSerailizedContent_Internal_Static_Void_HttpRequestMessage_IClientService_Object_Boolean_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_CreateZipContent_Internal_Static_HttpContent_String_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_CreateGZipStream_Private_Static_Stream_String_0;
	}
}
