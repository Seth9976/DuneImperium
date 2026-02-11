using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace lotus
{
	// Token: 0x02000040 RID: 64
	public class AnimationSignalEvent : UnityEvent<string>
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00004179 File Offset: 0x00002379
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationSignalEvent()
		{
			Il2CppClassPointerStore<AnimationSignalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "AnimationSignalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSignalEvent>.NativeClassPtr);
			AnimationSignalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalEvent>.NativeClassPtr, 100663753);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00016064 File Offset: 0x00014264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1109599, RefRangeEnd = 1109600, XrefRangeStart = 1109596, XrefRangeEnd = 1109599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationSignalEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSignalEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000041B2 File Offset: 0x000023B2
		public AnimationSignalEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
