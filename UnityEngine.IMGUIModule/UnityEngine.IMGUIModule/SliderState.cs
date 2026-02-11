using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public class SliderState : Object
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x0000450A File Offset: 0x0000270A
		// Note: this type is marked as 'beforefieldinit'.
		static SliderState()
		{
			Il2CppClassPointerStore<SliderState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "SliderState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderState>.NativeClassPtr);
			SliderState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderState>.NativeClassPtr, 100663657);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00012C44 File Offset: 0x00010E44
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00004543 File Offset: 0x00002743
		public SliderState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
