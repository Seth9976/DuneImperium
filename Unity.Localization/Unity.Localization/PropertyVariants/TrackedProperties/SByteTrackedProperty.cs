using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E9 RID: 233
	[Serializable]
	public class SByteTrackedProperty : TrackedProperty<sbyte>
	{
		// Token: 0x06000BAE RID: 2990 RVA: 0x00006D80 File Offset: 0x00004F80
		// Note: this type is marked as 'beforefieldinit'.
		static SByteTrackedProperty()
		{
			Il2CppClassPointerStore<SByteTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "SByteTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SByteTrackedProperty>.NativeClassPtr);
			SByteTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteTrackedProperty>.NativeClassPtr, 100665232);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00035810 File Offset: 0x00033A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079809, XrefRangeEnd = 1079812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SByteTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SByteTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00006DB9 File Offset: 0x00004FB9
		public SByteTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
