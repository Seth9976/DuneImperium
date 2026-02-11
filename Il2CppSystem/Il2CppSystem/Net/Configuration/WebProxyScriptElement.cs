using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200027C RID: 636
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		// Token: 0x06002989 RID: 10633 RVA: 0x000BC274 File Offset: 0x000BA474
		// Note: this type is marked as 'beforefieldinit'.
		static WebProxyScriptElement()
		{
			Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebProxyScriptElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr);
			WebProxyScriptElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr, 100669467);
			WebProxyScriptElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr, 100669468);
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000BC2CC File Offset: 0x000BA4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494258, XrefRangeEnd = 494261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxyScriptElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxyScriptElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x000BC308 File Offset: 0x000BA508
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494261, XrefRangeEnd = 494264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxyScriptElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00011D75 File Offset: 0x0000FF75
		public WebProxyScriptElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
