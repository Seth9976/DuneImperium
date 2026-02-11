using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace lib.canis.voodoo.src.voodoo.renderAnimator
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public sealed class EventTrigger : ValueType
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		// Note: this type is marked as 'beforefieldinit'.
		static EventTrigger()
		{
			Il2CppClassPointerStore<EventTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.canis.voodoo.src.voodoo.renderAnimator", "EventTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr);
			EventTrigger.NativeFieldInfoPtr_triggerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, "triggerName");
			EventTrigger.NativeFieldInfoPtr_eventToInvoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, "eventToInvoke");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000251A File Offset: 0x0000071A
		public EventTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002523 File Offset: 0x00000723
		public EventTrigger()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr))
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000AA00 File Offset: 0x00008C00
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002535 File Offset: 0x00000735
		public unsafe string triggerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.NativeFieldInfoPtr_triggerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.NativeFieldInfoPtr_triggerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000AA28 File Offset: 0x00008C28
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002554 File Offset: 0x00000754
		public unsafe UnityEvent eventToInvoke
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.NativeFieldInfoPtr_eventToInvoke);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.NativeFieldInfoPtr_eventToInvoke), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_triggerName;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_eventToInvoke;
	}
}
