using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000040 RID: 64
	public sealed class StringChoicePromptBehaviour : ChoicePromptBehaviour<string>
	{
		// Token: 0x06000259 RID: 601 RVA: 0x000032CB File Offset: 0x000014CB
		// Note: this type is marked as 'beforefieldinit'.
		static StringChoicePromptBehaviour()
		{
			Il2CppClassPointerStore<StringChoicePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "StringChoicePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringChoicePromptBehaviour>.NativeClassPtr);
			StringChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringChoicePromptBehaviour>.NativeClassPtr, 100663580);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000B878 File Offset: 0x00009A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214822, XrefRangeEnd = 1214825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringChoicePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringChoicePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003304 File Offset: 0x00001504
		public StringChoicePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
