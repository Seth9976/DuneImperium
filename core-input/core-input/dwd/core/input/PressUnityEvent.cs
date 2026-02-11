using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace dwd.core.input
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class PressUnityEvent : UnityEvent<Press>
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00003200 File Offset: 0x00001400
		// Note: this type is marked as 'beforefieldinit'.
		static PressUnityEvent()
		{
			Il2CppClassPointerStore<PressUnityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "PressUnityEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressUnityEvent>.NativeClassPtr);
			PressUnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressUnityEvent>.NativeClassPtr, 100663551);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120352, XrefRangeEnd = 1120355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressUnityEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressUnityEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressUnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00003239 File Offset: 0x00001439
		public PressUnityEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
