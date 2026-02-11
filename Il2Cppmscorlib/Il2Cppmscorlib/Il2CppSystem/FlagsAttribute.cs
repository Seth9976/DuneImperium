using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000093 RID: 147
	[Serializable]
	public class FlagsAttribute : Attribute
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x00004795 File Offset: 0x00002995
		// Note: this type is marked as 'beforefieldinit'.
		static FlagsAttribute()
		{
			Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FlagsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr);
			FlagsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr, 100665056);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000535D8 File Offset: 0x000517D8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlagsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlagsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000047CE File Offset: 0x000029CE
		public FlagsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
