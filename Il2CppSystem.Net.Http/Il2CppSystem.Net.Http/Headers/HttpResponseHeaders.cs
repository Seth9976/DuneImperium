using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000028 RID: 40
	public sealed class HttpResponseHeaders : HttpHeaders
	{
		// Token: 0x06000290 RID: 656 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		// Note: this type is marked as 'beforefieldinit'.
		static HttpResponseHeaders()
		{
			Il2CppClassPointerStore<HttpResponseHeaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "HttpResponseHeaders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpResponseHeaders>.NativeClassPtr);
			HttpResponseHeaders.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseHeaders>.NativeClassPtr, 100663708);
			HttpResponseHeaders.NativeMethodInfoPtr_get_ETag_Public_get_EntityTagHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseHeaders>.NativeClassPtr, 100663709);
			HttpResponseHeaders.NativeMethodInfoPtr_get_Location_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseHeaders>.NativeClassPtr, 100663710);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000EC44 File Offset: 0x0000CE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174595, XrefRangeEnd = 1174599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpResponseHeaders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpResponseHeaders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseHeaders.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000EC80 File Offset: 0x0000CE80
		public unsafe EntityTagHeaderValue ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1174604, RefRangeEnd = 1174608, XrefRangeStart = 1174599, XrefRangeEnd = 1174604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseHeaders.NativeMethodInfoPtr_get_ETag_Public_get_EntityTagHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityTagHeaderValue>(intPtr3) : null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000ECC0 File Offset: 0x0000CEC0
		public unsafe Uri Location
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1174613, RefRangeEnd = 1174617, XrefRangeStart = 1174608, XrefRangeEnd = 1174613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseHeaders.NativeMethodInfoPtr_get_Location_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002F58 File Offset: 0x00001158
		public HttpResponseHeaders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_get_EntityTagHeaderValue_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_Uri_0;
	}
}
