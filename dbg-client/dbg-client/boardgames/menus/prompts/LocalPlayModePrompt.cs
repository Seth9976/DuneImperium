using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001F6 RID: 502
	public class LocalPlayModePrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x06001759 RID: 5977 RVA: 0x0000D080 File Offset: 0x0000B280
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayModePrompt()
		{
			Il2CppClassPointerStore<LocalPlayModePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "LocalPlayModePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayModePrompt>.NativeClassPtr);
			LocalPlayModePrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayModePrompt>.NativeClassPtr, 100666716);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00069618 File Offset: 0x00067818
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 524574, RefRangeEnd = 524584, XrefRangeStart = 524574, XrefRangeEnd = 524584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayModePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayModePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayModePrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0000D0B9 File Offset: 0x0000B2B9
		public LocalPlayModePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
