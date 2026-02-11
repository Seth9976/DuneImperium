using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input.multitouch
{
	// Token: 0x02000066 RID: 102
	public class GestureStartedEvent : GestureEvent
	{
		// Token: 0x060003DB RID: 987 RVA: 0x000043C4 File Offset: 0x000025C4
		// Note: this type is marked as 'beforefieldinit'.
		static GestureStartedEvent()
		{
			Il2CppClassPointerStore<GestureStartedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "GestureStartedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GestureStartedEvent>.NativeClassPtr);
			GestureStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureStartedEvent>.NativeClassPtr, 100663727);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00012CF4 File Offset: 0x00010EF4
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GestureStartedEvent(Gesture gesture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GestureStartedEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gesture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000043FD File Offset: 0x000025FD
		public GestureStartedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gesture_0;
	}
}
