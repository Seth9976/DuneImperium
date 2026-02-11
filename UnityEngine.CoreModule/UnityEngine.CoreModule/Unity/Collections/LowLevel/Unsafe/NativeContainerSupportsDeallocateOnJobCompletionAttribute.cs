using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004A RID: 74
	public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x06000283 RID: 643 RVA: 0x00003498 File Offset: 0x00001698
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsDeallocateOnJobCompletionAttribute()
		{
			Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsDeallocateOnJobCompletionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr);
			NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr, 100663518);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001CF44 File Offset: 0x0001B144
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsDeallocateOnJobCompletionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000034D1 File Offset: 0x000016D1
		public NativeContainerSupportsDeallocateOnJobCompletionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
