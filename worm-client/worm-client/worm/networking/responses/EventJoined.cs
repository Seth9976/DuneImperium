using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000072 RID: 114
	public class EventJoined : NetworkMessageEvent
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x00026624 File Offset: 0x00024824
		// Note: this type is marked as 'beforefieldinit'.
		static EventJoined()
		{
			Il2CppClassPointerStore<EventJoined>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventJoined");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventJoined>.NativeClassPtr);
			EventJoined.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventJoined>.NativeClassPtr, "entry");
			EventJoined.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventJoined>.NativeClassPtr, 100663949);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0002667C File Offset: 0x0002487C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventJoined()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventJoined>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventJoined.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000042F8 File Offset: 0x000024F8
		public EventJoined(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000266B8 File Offset: 0x000248B8
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00004301 File Offset: 0x00002501
		public unsafe EventEntry entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventJoined.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventJoined.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
