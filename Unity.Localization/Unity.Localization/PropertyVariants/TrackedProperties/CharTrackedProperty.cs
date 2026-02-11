using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	public class CharTrackedProperty : TrackedProperty<char>
	{
		// Token: 0x06000BB1 RID: 2993 RVA: 0x00006DC2 File Offset: 0x00004FC2
		// Note: this type is marked as 'beforefieldinit'.
		static CharTrackedProperty()
		{
			Il2CppClassPointerStore<CharTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "CharTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharTrackedProperty>.NativeClassPtr);
			CharTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharTrackedProperty>.NativeClassPtr, 100665233);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0003584C File Offset: 0x00033A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079812, XrefRangeEnd = 1079815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00006DFB File Offset: 0x00004FFB
		public CharTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
