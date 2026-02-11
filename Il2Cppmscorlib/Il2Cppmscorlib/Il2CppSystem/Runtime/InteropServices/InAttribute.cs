using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200038E RID: 910
	public sealed class InAttribute : Attribute
	{
		// Token: 0x060037BE RID: 14270 RVA: 0x0001466D File Offset: 0x0001286D
		// Note: this type is marked as 'beforefieldinit'.
		static InAttribute()
		{
			Il2CppClassPointerStore<InAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "InAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAttribute>.NativeClassPtr);
			InAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAttribute>.NativeClassPtr, 100671637);
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x001104AC File Offset: 0x0010E6AC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x000146A6 File Offset: 0x000128A6
		public InAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
