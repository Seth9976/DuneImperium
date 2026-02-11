using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000034 RID: 52
	public sealed class BoolChoicePromptBehaviour : ChoicePromptBehaviour<bool>
	{
		// Token: 0x06000200 RID: 512 RVA: 0x0000303A File Offset: 0x0000123A
		// Note: this type is marked as 'beforefieldinit'.
		static BoolChoicePromptBehaviour()
		{
			Il2CppClassPointerStore<BoolChoicePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "BoolChoicePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolChoicePromptBehaviour>.NativeClassPtr);
			BoolChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolChoicePromptBehaviour>.NativeClassPtr, 100663525);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000A5E8 File Offset: 0x000087E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214358, XrefRangeEnd = 1214361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolChoicePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolChoicePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00003073 File Offset: 0x00001273
		public BoolChoicePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
