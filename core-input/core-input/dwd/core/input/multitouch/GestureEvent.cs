using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.input.multitouch
{
	// Token: 0x02000065 RID: 101
	public class GestureEvent : DWDEvent
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x00012C20 File Offset: 0x00010E20
		// Note: this type is marked as 'beforefieldinit'.
		static GestureEvent()
		{
			Il2CppClassPointerStore<GestureEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "GestureEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GestureEvent>.NativeClassPtr);
			GestureEvent.NativeFieldInfoPtr_Gesture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GestureEvent>.NativeClassPtr, "Gesture");
			GestureEvent.NativeMethodInfoPtr__ctor_Protected_Void_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GestureEvent>.NativeClassPtr, 100663726);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00012C78 File Offset: 0x00010E78
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GestureEvent(Gesture gesture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GestureEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gesture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GestureEvent.NativeMethodInfoPtr__ctor_Protected_Void_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000439C File Offset: 0x0000259C
		public GestureEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00012CC4 File Offset: 0x00010EC4
		// (set) Token: 0x060003DA RID: 986 RVA: 0x000043A5 File Offset: 0x000025A5
		public unsafe Gesture Gesture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GestureEvent.NativeFieldInfoPtr_Gesture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GestureEvent.NativeFieldInfoPtr_Gesture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_Gesture;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Gesture_0;
	}
}
