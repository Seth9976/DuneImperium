using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000390 RID: 912
	public sealed class OptionalAttribute : Attribute
	{
		// Token: 0x060037C4 RID: 14276 RVA: 0x000146F1 File Offset: 0x000128F1
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalAttribute()
		{
			Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "OptionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr);
			OptionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr, 100671639);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00110524 File Offset: 0x0010E724
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x0001472A File Offset: 0x0001292A
		public OptionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
