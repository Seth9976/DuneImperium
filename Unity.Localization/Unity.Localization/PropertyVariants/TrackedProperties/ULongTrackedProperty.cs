using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000F0 RID: 240
	[Serializable]
	public class ULongTrackedProperty : TrackedProperty<ulong>
	{
		// Token: 0x06000BC3 RID: 3011 RVA: 0x00006F4E File Offset: 0x0000514E
		// Note: this type is marked as 'beforefieldinit'.
		static ULongTrackedProperty()
		{
			Il2CppClassPointerStore<ULongTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "ULongTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ULongTrackedProperty>.NativeClassPtr);
			ULongTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ULongTrackedProperty>.NativeClassPtr, 100665239);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000359B4 File Offset: 0x00033BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079830, XrefRangeEnd = 1079833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ULongTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ULongTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ULongTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00006F87 File Offset: 0x00005187
		public ULongTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
