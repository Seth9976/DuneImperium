using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000004 RID: 4
	public sealed class IsByRefLikeAttribute : Attribute
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020D4 File Offset: 0x000002D4
		// Note: this type is marked as 'beforefieldinit'.
		static IsByRefLikeAttribute()
		{
			Il2CppClassPointerStore<IsByRefLikeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "System.Runtime.CompilerServices", "IsByRefLikeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsByRefLikeAttribute>.NativeClassPtr);
			IsByRefLikeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsByRefLikeAttribute>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002788 File Offset: 0x00000988
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

		// Token: 0x06000009 RID: 9 RVA: 0x0000210D File Offset: 0x0000030D
		public IsByRefLikeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
