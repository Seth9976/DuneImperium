using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004F RID: 79
	public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
	{
		// Token: 0x06000290 RID: 656 RVA: 0x000035BA File Offset: 0x000017BA
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableUnsafePtrRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeDisableUnsafePtrRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr);
			NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr, 100663521);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableUnsafePtrRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000035F3 File Offset: 0x000017F3
		public NativeDisableUnsafePtrRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
