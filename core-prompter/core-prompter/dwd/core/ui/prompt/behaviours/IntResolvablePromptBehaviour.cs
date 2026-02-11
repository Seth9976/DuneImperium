using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000039 RID: 57
	public sealed class IntResolvablePromptBehaviour : ResolvablePromptBehaviour<int>
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00003112 File Offset: 0x00001312
		// Note: this type is marked as 'beforefieldinit'.
		static IntResolvablePromptBehaviour()
		{
			Il2CppClassPointerStore<IntResolvablePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "IntResolvablePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntResolvablePromptBehaviour>.NativeClassPtr);
			IntResolvablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntResolvablePromptBehaviour>.NativeClassPtr, 100663533);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214395, XrefRangeEnd = 1214398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntResolvablePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntResolvablePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntResolvablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000314B File Offset: 0x0000134B
		public IntResolvablePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
