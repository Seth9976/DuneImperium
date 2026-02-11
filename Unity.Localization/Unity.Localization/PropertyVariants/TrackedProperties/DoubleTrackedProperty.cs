using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F2 RID: 242
	[Serializable]
	public class DoubleTrackedProperty : TrackedProperty<double>
	{
		// Token: 0x06000BC9 RID: 3017 RVA: 0x00006FD2 File Offset: 0x000051D2
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleTrackedProperty()
		{
			Il2CppClassPointerStore<DoubleTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "DoubleTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleTrackedProperty>.NativeClassPtr);
			DoubleTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleTrackedProperty>.NativeClassPtr, 100665241);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00035A2C File Offset: 0x00033C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079836, XrefRangeEnd = 1079839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0000700B File Offset: 0x0000520B
		public DoubleTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
