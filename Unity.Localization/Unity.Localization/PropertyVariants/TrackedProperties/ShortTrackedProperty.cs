using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class ShortTrackedProperty : TrackedProperty<short>
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x00006E04 File Offset: 0x00005004
		// Note: this type is marked as 'beforefieldinit'.
		static ShortTrackedProperty()
		{
			Il2CppClassPointerStore<ShortTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "ShortTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortTrackedProperty>.NativeClassPtr);
			ShortTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortTrackedProperty>.NativeClassPtr, 100665234);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00035888 File Offset: 0x00033A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079815, XrefRangeEnd = 1079818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00006E3D File Offset: 0x0000503D
		public ShortTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
