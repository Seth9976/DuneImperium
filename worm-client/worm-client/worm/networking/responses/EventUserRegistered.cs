using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000077 RID: 119
	public class EventUserRegistered : NetworkMessageEvent
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x0000449F File Offset: 0x0000269F
		// Note: this type is marked as 'beforefieldinit'.
		static EventUserRegistered()
		{
			Il2CppClassPointerStore<EventUserRegistered>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventUserRegistered");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventUserRegistered>.NativeClassPtr);
			EventUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventUserRegistered>.NativeClassPtr, 100663954);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00026B14 File Offset: 0x00024D14
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventUserRegistered()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventUserRegistered>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000044D8 File Offset: 0x000026D8
		public EventUserRegistered(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
