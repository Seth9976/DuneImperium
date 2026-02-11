using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000076 RID: 118
	public class EventQueueLeft : NetworkMessageEvent
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x0000445D File Offset: 0x0000265D
		// Note: this type is marked as 'beforefieldinit'.
		static EventQueueLeft()
		{
			Il2CppClassPointerStore<EventQueueLeft>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventQueueLeft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQueueLeft>.NativeClassPtr);
			EventQueueLeft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueueLeft>.NativeClassPtr, 100663953);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00026AD8 File Offset: 0x00024CD8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventQueueLeft()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventQueueLeft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQueueLeft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00004496 File Offset: 0x00002696
		public EventQueueLeft(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
