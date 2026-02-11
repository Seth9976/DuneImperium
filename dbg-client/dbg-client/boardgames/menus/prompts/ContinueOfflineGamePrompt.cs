using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E9 RID: 489
	public class ContinueOfflineGamePrompt : ContinueGamePrompt
	{
		// Token: 0x060016E8 RID: 5864 RVA: 0x0000CDCD File Offset: 0x0000AFCD
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueOfflineGamePrompt()
		{
			Il2CppClassPointerStore<ContinueOfflineGamePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ContinueOfflineGamePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueOfflineGamePrompt>.NativeClassPtr);
			ContinueOfflineGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueOfflineGamePrompt>.NativeClassPtr, 100666650);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00067C70 File Offset: 0x00065E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524986, RefRangeEnd = 524987, XrefRangeStart = 524977, XrefRangeEnd = 524986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueOfflineGamePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueOfflineGamePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueOfflineGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0000CE06 File Offset: 0x0000B006
		public ContinueOfflineGamePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
