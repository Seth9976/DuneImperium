using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200027D RID: 637
	public sealed class WebRequestModulesSection : ConfigurationSection
	{
		// Token: 0x0600298D RID: 10637 RVA: 0x000BC348 File Offset: 0x000BA548
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestModulesSection()
		{
			Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebRequestModulesSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr);
			WebRequestModulesSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr, 100669469);
			WebRequestModulesSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr, 100669470);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000BC3A0 File Offset: 0x000BA5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494264, XrefRangeEnd = 494267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestModulesSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModulesSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x000BC3DC File Offset: 0x000BA5DC
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494267, XrefRangeEnd = 494270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModulesSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00011D7E File Offset: 0x0000FF7E
		public WebRequestModulesSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
