using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000210 RID: 528
	public class WebCompletionSource : WebCompletionSource<Object>
	{
		// Token: 0x06002300 RID: 8960 RVA: 0x0000F229 File Offset: 0x0000D429
		// Note: this type is marked as 'beforefieldinit'.
		static WebCompletionSource()
		{
			Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebCompletionSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr);
			WebCompletionSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100668499);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000A2BDC File Offset: 0x000A0DDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 484399, RefRangeEnd = 484403, XrefRangeStart = 484396, XrefRangeEnd = 484399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebCompletionSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0000F262 File Offset: 0x0000D462
		public WebCompletionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
