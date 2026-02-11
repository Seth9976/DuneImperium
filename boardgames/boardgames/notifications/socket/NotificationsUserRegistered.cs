using System;
using Canis.json.events;
using dwd.core.notifications.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.notifications.socket
{
	// Token: 0x02000115 RID: 277
	public class NotificationsUserRegistered : NetworkMessageEvent
	{
		// Token: 0x06000E74 RID: 3700 RVA: 0x0003CD9C File Offset: 0x0003AF9C
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationsUserRegistered()
		{
			Il2CppClassPointerStore<NotificationsUserRegistered>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.notifications.socket", "NotificationsUserRegistered");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsUserRegistered>.NativeClassPtr);
			NotificationsUserRegistered.NativeFieldInfoPtr_Notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsUserRegistered>.NativeClassPtr, "Notes");
			NotificationsUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsUserRegistered>.NativeClassPtr, 100665352);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationsUserRegistered()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsUserRegistered>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00008C51 File Offset: 0x00006E51
		public NotificationsUserRegistered(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0003CE30 File Offset: 0x0003B030
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00008C5A File Offset: 0x00006E5A
		public unsafe Il2CppReferenceArray<Notification> Notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsUserRegistered.NativeFieldInfoPtr_Notes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Notification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsUserRegistered.NativeFieldInfoPtr_Notes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_Notes;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
