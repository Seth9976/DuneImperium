using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000EF RID: 239
	[Serializable]
	public class LongTrackedProperty : TrackedProperty<long>
	{
		// Token: 0x06000BC0 RID: 3008 RVA: 0x00006F0C File Offset: 0x0000510C
		// Note: this type is marked as 'beforefieldinit'.
		static LongTrackedProperty()
		{
			Il2CppClassPointerStore<LongTrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "LongTrackedProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongTrackedProperty>.NativeClassPtr);
			LongTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongTrackedProperty>.NativeClassPtr, 100665238);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00035978 File Offset: 0x00033B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079827, XrefRangeEnd = 1079830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongTrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongTrackedProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongTrackedProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00006F45 File Offset: 0x00005145
		public LongTrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
