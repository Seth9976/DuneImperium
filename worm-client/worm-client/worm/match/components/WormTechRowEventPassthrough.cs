using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components
{
	// Token: 0x0200021A RID: 538
	public class WormTechRowEventPassthrough : PlaymatTogglePassthrough<WormTechRowManager>
	{
		// Token: 0x060017A5 RID: 6053 RVA: 0x0000E1B5 File Offset: 0x0000C3B5
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechRowEventPassthrough()
		{
			Il2CppClassPointerStore<WormTechRowEventPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormTechRowEventPassthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechRowEventPassthrough>.NativeClassPtr);
			WormTechRowEventPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowEventPassthrough>.NativeClassPtr, 100666584);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0005FD30 File Offset: 0x0005DF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717637, XrefRangeEnd = 717640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechRowEventPassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechRowEventPassthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowEventPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0000E1EE File Offset: 0x0000C3EE
		public WormTechRowEventPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
