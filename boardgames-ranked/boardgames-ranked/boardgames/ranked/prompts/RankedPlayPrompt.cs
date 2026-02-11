using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.prompts
{
	// Token: 0x02000009 RID: 9
	public class RankedPlayPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000021B6 File Offset: 0x000003B6
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayPrompt()
		{
			Il2CppClassPointerStore<RankedPlayPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.prompts", "RankedPlayPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayPrompt>.NativeClassPtr);
			RankedPlayPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayPrompt>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000041A4 File Offset: 0x000023A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696835, RefRangeEnd = 696837, XrefRangeStart = 696835, XrefRangeEnd = 696837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021EF File Offset: 0x000003EF
		public RankedPlayPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
