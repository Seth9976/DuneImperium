using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components
{
	// Token: 0x020001FB RID: 507
	public class WormImperiumRowEventPassthrough : PlaymatTogglePassthrough<WormShowImperiumRow>
	{
		// Token: 0x0600166A RID: 5738 RVA: 0x0000D7EF File Offset: 0x0000B9EF
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumRowEventPassthrough()
		{
			Il2CppClassPointerStore<WormImperiumRowEventPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormImperiumRowEventPassthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumRowEventPassthrough>.NativeClassPtr);
			WormImperiumRowEventPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowEventPassthrough>.NativeClassPtr, 100666408);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0005C278 File Offset: 0x0005A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716461, XrefRangeEnd = 716464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumRowEventPassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumRowEventPassthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowEventPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000D828 File Offset: 0x0000BA28
		public WormImperiumRowEventPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
