using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x02000026 RID: 38
	public class PlatformPropertyAttribute : PropertyAttribute
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00002964 File Offset: 0x00000B64
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformPropertyAttribute()
		{
			Il2CppClassPointerStore<PlatformPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformPropertyAttribute>.NativeClassPtr);
			PlatformPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPropertyAttribute>.NativeClassPtr, 100663439);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006CE8 File Offset: 0x00004EE8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformPropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformPropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000299D File Offset: 0x00000B9D
		public PlatformPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
