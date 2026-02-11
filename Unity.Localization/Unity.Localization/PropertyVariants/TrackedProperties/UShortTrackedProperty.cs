using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000EC RID: 236
	[Serializable]
	public class UShortTrackedProperty : TrackedProperty<ushort>
	{
		// Token: 0x06000BB7 RID: 2999 RVA: 0x00006E46 File Offset: 0x00005046
		// Note: this type is marked as 'beforefieldinit'.
		static UShortTrackedProperty()
		{
			Il2CppClassPointerStore<UShortTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "UShortTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UShortTrackedProperty>.NativeClassPtr);
			UShortTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UShortTrackedProperty>.NativeClassPtr, 100665235);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000358C4 File Offset: 0x00033AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079818, XrefRangeEnd = 1079821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UShortTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UShortTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UShortTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00006E7F File Offset: 0x0000507F
		public UShortTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
