using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input.multitouch
{
	// Token: 0x02000064 RID: 100
	public class GestureEndedEvent : GestureEvent
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x0000435A File Offset: 0x0000255A
		// Note: this type is marked as 'beforefieldinit'.
		static GestureEndedEvent()
		{
			Il2CppClassPointerStore<GestureEndedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "GestureEndedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GestureEndedEvent>.NativeClassPtr);
			GestureEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureEndedEvent>.NativeClassPtr, 100663725);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00012BD4 File Offset: 0x00010DD4
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GestureEndedEvent(Gesture gesture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GestureEndedEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gesture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00004393 File Offset: 0x00002593
		public GestureEndedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gesture_0;
	}
}
