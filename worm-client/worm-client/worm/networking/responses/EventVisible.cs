using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000078 RID: 120
	public class EventVisible : NetworkMessageEvent
	{
		// Token: 0x06000498 RID: 1176 RVA: 0x00026B50 File Offset: 0x00024D50
		// Note: this type is marked as 'beforefieldinit'.
		static EventVisible()
		{
			Il2CppClassPointerStore<EventVisible>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventVisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventVisible>.NativeClassPtr);
			EventVisible.NativeFieldInfoPtr_eventDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventVisible>.NativeClassPtr, "eventDefinition");
			EventVisible.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventVisible>.NativeClassPtr, 100663955);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00026BA8 File Offset: 0x00024DA8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventVisible()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventVisible>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventVisible.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000044E1 File Offset: 0x000026E1
		public EventVisible(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00026BE4 File Offset: 0x00024DE4
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x000044EA File Offset: 0x000026EA
		public unsafe EventDefinition eventDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventVisible.NativeFieldInfoPtr_eventDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventVisible.NativeFieldInfoPtr_eventDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_eventDefinition;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
