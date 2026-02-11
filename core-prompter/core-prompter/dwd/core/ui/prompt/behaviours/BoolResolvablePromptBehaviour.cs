using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000035 RID: 53
	public sealed class BoolResolvablePromptBehaviour : ResolvablePromptBehaviour<bool>
	{
		// Token: 0x06000203 RID: 515 RVA: 0x0000307C File Offset: 0x0000127C
		// Note: this type is marked as 'beforefieldinit'.
		static BoolResolvablePromptBehaviour()
		{
			Il2CppClassPointerStore<BoolResolvablePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "BoolResolvablePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolResolvablePromptBehaviour>.NativeClassPtr);
			BoolResolvablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolResolvablePromptBehaviour>.NativeClassPtr, 100663526);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000A624 File Offset: 0x00008824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214361, XrefRangeEnd = 1214364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolResolvablePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolResolvablePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolResolvablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000030B5 File Offset: 0x000012B5
		public BoolResolvablePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
