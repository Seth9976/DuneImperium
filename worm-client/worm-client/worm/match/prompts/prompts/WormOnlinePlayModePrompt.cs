using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000BC RID: 188
	public class WormOnlinePlayModePrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x00005C91 File Offset: 0x00003E91
		// Note: this type is marked as 'beforefieldinit'.
		static WormOnlinePlayModePrompt()
		{
			Il2CppClassPointerStore<WormOnlinePlayModePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormOnlinePlayModePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOnlinePlayModePrompt>.NativeClassPtr);
			WormOnlinePlayModePrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOnlinePlayModePrompt>.NativeClassPtr, 100664288);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0002F250 File Offset: 0x0002D450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696835, RefRangeEnd = 696837, XrefRangeStart = 696835, XrefRangeEnd = 696837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOnlinePlayModePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOnlinePlayModePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOnlinePlayModePrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00005CCA File Offset: 0x00003ECA
		public WormOnlinePlayModePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
