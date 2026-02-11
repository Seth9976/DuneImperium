using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000050 RID: 80
	public sealed class NativeDisableContainerSafetyRestrictionAttribute : Attribute
	{
		// Token: 0x06000293 RID: 659 RVA: 0x000035FC File Offset: 0x000017FC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableContainerSafetyRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeDisableContainerSafetyRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr);
			NativeDisableContainerSafetyRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr, 100663522);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001D034 File Offset: 0x0001B234
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableContainerSafetyRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableContainerSafetyRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003635 File Offset: 0x00001835
		public NativeDisableContainerSafetyRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
