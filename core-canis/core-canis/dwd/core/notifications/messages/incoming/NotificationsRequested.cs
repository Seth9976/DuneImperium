using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.notifications.messages.incoming
{
	// Token: 0x02000121 RID: 289
	public class NotificationsRequested : NetworkMessageEvent
	{
		// Token: 0x0600103A RID: 4154 RVA: 0x00053F94 File Offset: 0x00052194
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationsRequested()
		{
			Il2CppClassPointerStore<NotificationsRequested>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.notifications.messages.incoming", "NotificationsRequested");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsRequested>.NativeClassPtr);
			NotificationsRequested.NativeFieldInfoPtr_NotificationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsRequested>.NativeClassPtr, "NotificationList");
			NotificationsRequested.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsRequested>.NativeClassPtr, 100665665);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00053FEC File Offset: 0x000521EC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationsRequested()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsRequested>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsRequested.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000079A9 File Offset: 0x00005BA9
		public NotificationsRequested(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00054028 File Offset: 0x00052228
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x000079B2 File Offset: 0x00005BB2
		public unsafe Il2CppReferenceArray<Notification> NotificationList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsRequested.NativeFieldInfoPtr_NotificationList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Notification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsRequested.NativeFieldInfoPtr_NotificationList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr_NotificationList;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
