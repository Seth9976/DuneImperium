using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace lotus.ui
{
	// Token: 0x020000DE RID: 222
	public class EventsForMouseOnCollider : MonoBehaviour
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x000343D8 File Offset: 0x000325D8
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForMouseOnCollider()
		{
			Il2CppClassPointerStore<EventsForMouseOnCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.ui", "EventsForMouseOnCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForMouseOnCollider>.NativeClassPtr);
			EventsForMouseOnCollider.NativeFieldInfoPtr_onMouseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForMouseOnCollider>.NativeClassPtr, "onMouseEvent");
			EventsForMouseOnCollider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseOnCollider>.NativeClassPtr, 100665063);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00034430 File Offset: 0x00032630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForMouseOnCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForMouseOnCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseOnCollider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000070F4 File Offset: 0x000052F4
		public EventsForMouseOnCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0003446C File Offset: 0x0003266C
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x000070FD File Offset: 0x000052FD
		public unsafe UnityEvent onMouseEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseOnCollider.NativeFieldInfoPtr_onMouseEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseOnCollider.NativeFieldInfoPtr_onMouseEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_onMouseEvent;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
