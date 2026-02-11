using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.notifications.socket
{
	// Token: 0x02000113 RID: 275
	public class NotificationDeleted : NetworkMessageEvent
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x00008BC8 File Offset: 0x00006DC8
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationDeleted()
		{
			Il2CppClassPointerStore<NotificationDeleted>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.notifications.socket", "NotificationDeleted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationDeleted>.NativeClassPtr);
			NotificationDeleted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDeleted>.NativeClassPtr, 100665350);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0003CC58 File Offset: 0x0003AE58
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationDeleted()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationDeleted>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDeleted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00008C01 File Offset: 0x00006E01
		public NotificationDeleted(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
