using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000075 RID: 117
	public class EventQueueJoined : NetworkMessageEvent
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x00026A1C File Offset: 0x00024C1C
		// Note: this type is marked as 'beforefieldinit'.
		static EventQueueJoined()
		{
			Il2CppClassPointerStore<EventQueueJoined>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventQueueJoined");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQueueJoined>.NativeClassPtr);
			EventQueueJoined.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueueJoined>.NativeClassPtr, "waitTime");
			EventQueueJoined.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueueJoined>.NativeClassPtr, 100663952);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00026A74 File Offset: 0x00024C74
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventQueueJoined()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventQueueJoined>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQueueJoined.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00004439 File Offset: 0x00002639
		public EventQueueJoined(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00026AB0 File Offset: 0x00024CB0
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00004442 File Offset: 0x00002642
		public unsafe int waitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueueJoined.NativeFieldInfoPtr_waitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueueJoined.NativeFieldInfoPtr_waitTime)) = value;
			}
		}

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_waitTime;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
