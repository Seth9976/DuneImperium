using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003BC RID: 956
	public sealed class IsByRefLikeAttribute : Attribute
	{
		// Token: 0x06003927 RID: 14631 RVA: 0x000151D5 File Offset: 0x000133D5
		// Note: this type is marked as 'beforefieldinit'.
		static IsByRefLikeAttribute()
		{
			Il2CppClassPointerStore<IsByRefLikeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IsByRefLikeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsByRefLikeAttribute>.NativeClassPtr);
			IsByRefLikeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsByRefLikeAttribute>.NativeClassPtr, 100671829);
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x0011516C File Offset: 0x0011336C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsByRefLikeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsByRefLikeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsByRefLikeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0001520E File Offset: 0x0001340E
		public IsByRefLikeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
