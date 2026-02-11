using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.prompts
{
	// Token: 0x020000FE RID: 254
	public class UIScalePrompt : ResolvablePrompt<int>
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00007176 File Offset: 0x00005376
		// Note: this type is marked as 'beforefieldinit'.
		static UIScalePrompt()
		{
			Il2CppClassPointerStore<UIScalePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompts", "UIScalePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScalePrompt>.NativeClassPtr);
			UIScalePrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalePrompt>.NativeClassPtr, 100664879);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0003FBB8 File Offset: 0x0003DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507256, XrefRangeEnd = 507259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScalePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScalePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalePrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000071AF File Offset: 0x000053AF
		public UIScalePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
