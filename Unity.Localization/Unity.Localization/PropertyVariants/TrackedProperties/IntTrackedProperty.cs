using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000ED RID: 237
	[Serializable]
	public class IntTrackedProperty : TrackedProperty<int>
	{
		// Token: 0x06000BBA RID: 3002 RVA: 0x00006E88 File Offset: 0x00005088
		// Note: this type is marked as 'beforefieldinit'.
		static IntTrackedProperty()
		{
			Il2CppClassPointerStore<IntTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "IntTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntTrackedProperty>.NativeClassPtr);
			IntTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTrackedProperty>.NativeClassPtr, 100665236);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00035900 File Offset: 0x00033B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079821, XrefRangeEnd = 1079824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00006EC1 File Offset: 0x000050C1
		public IntTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
