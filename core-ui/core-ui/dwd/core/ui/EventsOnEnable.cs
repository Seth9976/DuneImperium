using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.ui
{
	// Token: 0x02000013 RID: 19
	public class EventsOnEnable : MonoBehaviour
	{
		// Token: 0x060000BD RID: 189 RVA: 0x0000522C File Offset: 0x0000342C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsOnEnable()
		{
			Il2CppClassPointerStore<EventsOnEnable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui", "EventsOnEnable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsOnEnable>.NativeClassPtr);
			EventsOnEnable.NativeFieldInfoPtr_OnEnableEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnEnable>.NativeClassPtr, "OnEnableEvent");
			EventsOnEnable.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnEnable>.NativeClassPtr, 100663400);
			EventsOnEnable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnEnable>.NativeClassPtr, 100663401);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005298 File Offset: 0x00003498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnEnable.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000052CC File Offset: 0x000034CC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsOnEnable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsOnEnable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnEnable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002537 File Offset: 0x00000737
		public EventsOnEnable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005308 File Offset: 0x00003508
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002540 File Offset: 0x00000740
		public unsafe UnityEvent OnEnableEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnEnable.NativeFieldInfoPtr_OnEnableEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnEnable.NativeFieldInfoPtr_OnEnableEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_OnEnableEvent;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
