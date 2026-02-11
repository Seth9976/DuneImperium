using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D5 RID: 213
	public sealed class ParamArrayAttribute : Attribute
	{
		// Token: 0x06000DCD RID: 3533 RVA: 0x000054E1 File Offset: 0x000036E1
		// Note: this type is marked as 'beforefieldinit'.
		static ParamArrayAttribute()
		{
			Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParamArrayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr);
			ParamArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr, 100665727);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00066928 File Offset: 0x00064B28
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamArrayAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0000551A File Offset: 0x0000371A
		public ParamArrayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
