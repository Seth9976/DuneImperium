using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000279 RID: 633
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		// Token: 0x0600297D RID: 10621 RVA: 0x000BBFF8 File Offset: 0x000BA1F8
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceCountersElement()
		{
			Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "PerformanceCountersElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr);
			PerformanceCountersElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr, 100669461);
			PerformanceCountersElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr, 100669462);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000BC050 File Offset: 0x000BA250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494240, XrefRangeEnd = 494243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceCountersElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceCountersElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000BC08C File Offset: 0x000BA28C
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494243, XrefRangeEnd = 494246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceCountersElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x00011D5A File Offset: 0x0000FF5A
		public PerformanceCountersElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
