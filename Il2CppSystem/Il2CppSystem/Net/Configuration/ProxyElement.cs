using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000274 RID: 628
	public sealed class ProxyElement : ConfigurationElement
	{
		// Token: 0x0600296A RID: 10602 RVA: 0x000BBC6C File Offset: 0x000B9E6C
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyElement()
		{
			Il2CppClassPointerStore<ProxyElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ProxyElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr);
			ProxyElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr, 100669452);
			ProxyElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr, 100669453);
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x000BBCC4 File Offset: 0x000B9EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494213, XrefRangeEnd = 494216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProxyElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000BBD00 File Offset: 0x000B9F00
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494216, XrefRangeEnd = 494219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00011CF4 File Offset: 0x0000FEF4
		public ProxyElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
