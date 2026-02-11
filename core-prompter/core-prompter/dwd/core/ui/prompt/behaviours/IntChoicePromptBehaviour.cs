using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000038 RID: 56
	public sealed class IntChoicePromptBehaviour : ChoicePromptBehaviour<int>
	{
		// Token: 0x0600020F RID: 527 RVA: 0x000030D0 File Offset: 0x000012D0
		// Note: this type is marked as 'beforefieldinit'.
		static IntChoicePromptBehaviour()
		{
			Il2CppClassPointerStore<IntChoicePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "IntChoicePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntChoicePromptBehaviour>.NativeClassPtr);
			IntChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoicePromptBehaviour>.NativeClassPtr, 100663532);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214392, XrefRangeEnd = 1214395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntChoicePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntChoicePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00003109 File Offset: 0x00001309
		public IntChoicePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
