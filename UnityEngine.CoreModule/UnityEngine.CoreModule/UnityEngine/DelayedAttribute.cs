using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000117 RID: 279
	public sealed class DelayedAttribute : PropertyAttribute
	{
		// Token: 0x060016BE RID: 5822 RVA: 0x00008FD8 File Offset: 0x000071D8
		// Note: this type is marked as 'beforefieldinit'.
		static DelayedAttribute()
		{
			Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DelayedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr);
			DelayedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr, 100666437);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0006D35C File Offset: 0x0006B55C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00009011 File Offset: 0x00007211
		public DelayedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
