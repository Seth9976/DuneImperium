using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.notifications.messages.outgoing
{
	// Token: 0x0200011F RID: 287
	public class GetNotifications : NetworkMessageEvent
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x000078D3 File Offset: 0x00005AD3
		// Note: this type is marked as 'beforefieldinit'.
		static GetNotifications()
		{
			Il2CppClassPointerStore<GetNotifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.notifications.messages.outgoing", "GetNotifications");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetNotifications>.NativeClassPtr);
			GetNotifications.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNotifications>.NativeClassPtr, 100665662);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00053D54 File Offset: 0x00051F54
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetNotifications()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetNotifications>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetNotifications.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0000790C File Offset: 0x00005B0C
		public GetNotifications(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
