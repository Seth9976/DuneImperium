using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.platformdependent
{
	// Token: 0x02000028 RID: 40
	public class PlatformUtilAttribute : Attribute
	{
		// Token: 0x06000156 RID: 342 RVA: 0x000029CF File Offset: 0x00000BCF
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformUtilAttribute()
		{
			Il2CppClassPointerStore<PlatformUtilAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformUtilAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUtilAttribute>.NativeClassPtr);
			PlatformUtilAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtilAttribute>.NativeClassPtr, 100663454);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000070B8 File Offset: 0x000052B8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformUtilAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformUtilAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtilAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002A08 File Offset: 0x00000C08
		public PlatformUtilAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
