using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.ui
{
	// Token: 0x02000010 RID: 16
	public class EventsOnAwake : MonoBehaviour
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00004F08 File Offset: 0x00003108
		// Note: this type is marked as 'beforefieldinit'.
		static EventsOnAwake()
		{
			Il2CppClassPointerStore<EventsOnAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui", "EventsOnAwake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsOnAwake>.NativeClassPtr);
			EventsOnAwake.NativeFieldInfoPtr_OnAwakeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnAwake>.NativeClassPtr, "OnAwakeEvent");
			EventsOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnAwake>.NativeClassPtr, 100663394);
			EventsOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnAwake>.NativeClassPtr, 100663395);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004F74 File Offset: 0x00003174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004FA8 File Offset: 0x000031A8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsOnAwake()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsOnAwake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000024BF File Offset: 0x000006BF
		public EventsOnAwake(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004FE4 File Offset: 0x000031E4
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000024C8 File Offset: 0x000006C8
		public unsafe UnityEvent OnAwakeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnAwake.NativeFieldInfoPtr_OnAwakeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnAwake.NativeFieldInfoPtr_OnAwakeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_OnAwakeEvent;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
