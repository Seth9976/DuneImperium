using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000041 RID: 65
	public sealed class StringResolvablePromptBehaviour : ResolvablePromptBehaviour<string>
	{
		// Token: 0x0600025C RID: 604 RVA: 0x0000330D File Offset: 0x0000150D
		// Note: this type is marked as 'beforefieldinit'.
		static StringResolvablePromptBehaviour()
		{
			Il2CppClassPointerStore<StringResolvablePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "StringResolvablePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringResolvablePromptBehaviour>.NativeClassPtr);
			StringResolvablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringResolvablePromptBehaviour>.NativeClassPtr, 100663581);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000B8B4 File Offset: 0x00009AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214825, XrefRangeEnd = 1214828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringResolvablePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringResolvablePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringResolvablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00003346 File Offset: 0x00001546
		public StringResolvablePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
