using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class FloatTrackedProperty : TrackedProperty<float>
	{
		// Token: 0x06000BC6 RID: 3014 RVA: 0x00006F90 File Offset: 0x00005190
		// Note: this type is marked as 'beforefieldinit'.
		static FloatTrackedProperty()
		{
			Il2CppClassPointerStore<FloatTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "FloatTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatTrackedProperty>.NativeClassPtr);
			FloatTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTrackedProperty>.NativeClassPtr, 100665240);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000359F0 File Offset: 0x00033BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079833, XrefRangeEnd = 1079836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00006FC9 File Offset: 0x000051C9
		public FloatTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
