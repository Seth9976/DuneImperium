using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000BA RID: 186
	public class WormEventsSelectPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x00005B5E File Offset: 0x00003D5E
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsSelectPrompt()
		{
			Il2CppClassPointerStore<WormEventsSelectPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormEventsSelectPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsSelectPrompt>.NativeClassPtr);
			WormEventsSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsSelectPrompt>.NativeClassPtr, 100664277);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0002EC2C File Offset: 0x0002CE2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696835, RefRangeEnd = 696837, XrefRangeStart = 696834, XrefRangeEnd = 696835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsSelectPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsSelectPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00005B97 File Offset: 0x00003D97
		public WormEventsSelectPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
