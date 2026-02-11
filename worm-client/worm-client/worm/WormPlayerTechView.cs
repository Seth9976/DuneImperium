using System;
using dbgclient;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm
{
	// Token: 0x02000047 RID: 71
	public class WormPlayerTechView : DBGFanView
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00022660 File Offset: 0x00020860
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerTechView()
		{
			Il2CppClassPointerStore<WormPlayerTechView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormPlayerTechView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerTechView>.NativeClassPtr);
			WormPlayerTechView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTechView>.NativeClassPtr, 100663793);
			WormPlayerTechView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTechView>.NativeClassPtr, 100663794);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000226B8 File Offset: 0x000208B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691374, XrefRangeEnd = 691390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerTechView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000226F4 File Offset: 0x000208F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691390, XrefRangeEnd = 691391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerTechView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerTechView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTechView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003736 File Offset: 0x00001936
		public WormPlayerTechView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
