using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.CompilerServices
{
	// Token: 0x02000028 RID: 40
	public class SkipLocalsInitAttribute : Attribute
	{
		// Token: 0x0600029D RID: 669 RVA: 0x00002E22 File Offset: 0x00001022
		// Note: this type is marked as 'beforefieldinit'.
		static SkipLocalsInitAttribute()
		{
			Il2CppClassPointerStore<SkipLocalsInitAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.CompilerServices", "SkipLocalsInitAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipLocalsInitAttribute>.NativeClassPtr);
			SkipLocalsInitAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipLocalsInitAttribute>.NativeClassPtr, 100666938);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000E18C File Offset: 0x0000C38C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkipLocalsInitAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipLocalsInitAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipLocalsInitAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002E5B File Offset: 0x0000105B
		public SkipLocalsInitAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
