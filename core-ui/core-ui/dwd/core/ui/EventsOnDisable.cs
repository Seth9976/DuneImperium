using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.ui
{
	// Token: 0x02000012 RID: 18
	public class EventsOnDisable : MonoBehaviour
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00005120 File Offset: 0x00003320
		// Note: this type is marked as 'beforefieldinit'.
		static EventsOnDisable()
		{
			Il2CppClassPointerStore<EventsOnDisable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui", "EventsOnDisable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsOnDisable>.NativeClassPtr);
			EventsOnDisable.NativeFieldInfoPtr_OnDisableEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnDisable>.NativeClassPtr, "OnDisableEvent");
			EventsOnDisable.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnDisable>.NativeClassPtr, 100663398);
			EventsOnDisable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnDisable>.NativeClassPtr, 100663399);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000518C File Offset: 0x0000338C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnDisable.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000051C0 File Offset: 0x000033C0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsOnDisable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsOnDisable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnDisable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000250F File Offset: 0x0000070F
		public EventsOnDisable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000051FC File Offset: 0x000033FC
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002518 File Offset: 0x00000718
		public unsafe UnityEvent OnDisableEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnDisable.NativeFieldInfoPtr_OnDisableEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnDisable.NativeFieldInfoPtr_OnDisableEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_OnDisableEvent;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
