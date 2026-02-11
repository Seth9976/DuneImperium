using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200027E RID: 638
	[DefaultMember("Item")]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06002991 RID: 10641 RVA: 0x00011D87 File Offset: 0x0000FF87
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestModuleElementCollection()
		{
			Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebRequestModuleElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr);
			WebRequestModuleElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr, 100669471);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000BC41C File Offset: 0x000BA61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494270, XrefRangeEnd = 494273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestModuleElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModuleElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		public WebRequestModuleElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
