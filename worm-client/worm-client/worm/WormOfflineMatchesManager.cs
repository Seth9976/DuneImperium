using System;
using boardgames.menus;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using worm.canis.match;

namespace worm
{
	// Token: 0x02000055 RID: 85
	public class WormOfflineMatchesManager : GenericOfflineMatchesManager<WormMatchInitData>
	{
		// Token: 0x06000363 RID: 867 RVA: 0x0000386A File Offset: 0x00001A6A
		// Note: this type is marked as 'beforefieldinit'.
		static WormOfflineMatchesManager()
		{
			Il2CppClassPointerStore<WormOfflineMatchesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormOfflineMatchesManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOfflineMatchesManager>.NativeClassPtr);
			WormOfflineMatchesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOfflineMatchesManager>.NativeClassPtr, 100663865);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0002368C File Offset: 0x0002188C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692072, XrefRangeEnd = 692075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOfflineMatchesManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOfflineMatchesManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOfflineMatchesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000038A3 File Offset: 0x00001AA3
		public WormOfflineMatchesManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
