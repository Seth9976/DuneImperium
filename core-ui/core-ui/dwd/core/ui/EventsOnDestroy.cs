using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.ui
{
	// Token: 0x02000011 RID: 17
	public class EventsOnDestroy : MonoBehaviour
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00005014 File Offset: 0x00003214
		// Note: this type is marked as 'beforefieldinit'.
		static EventsOnDestroy()
		{
			Il2CppClassPointerStore<EventsOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui", "EventsOnDestroy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsOnDestroy>.NativeClassPtr);
			EventsOnDestroy.NativeFieldInfoPtr_OnDestroyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnDestroy>.NativeClassPtr, "OnDestroyEvent");
			EventsOnDestroy.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnDestroy>.NativeClassPtr, 100663396);
			EventsOnDestroy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnDestroy>.NativeClassPtr, 100663397);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005080 File Offset: 0x00003280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnDestroy.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000050B4 File Offset: 0x000032B4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsOnDestroy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsOnDestroy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnDestroy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000024E7 File Offset: 0x000006E7
		public EventsOnDestroy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000050F0 File Offset: 0x000032F0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000024F0 File Offset: 0x000006F0
		public unsafe UnityEvent OnDestroyEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnDestroy.NativeFieldInfoPtr_OnDestroyEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnDestroy.NativeFieldInfoPtr_OnDestroyEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_OnDestroyEvent;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
