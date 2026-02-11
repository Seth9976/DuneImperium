using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.notifications.messages.outgoing
{
	// Token: 0x0200011E RID: 286
	public class AcknowledgeNotification : NetworkMessageEvent
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x00053C80 File Offset: 0x00051E80
		// Note: this type is marked as 'beforefieldinit'.
		static AcknowledgeNotification()
		{
			Il2CppClassPointerStore<AcknowledgeNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.notifications.messages.outgoing", "AcknowledgeNotification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcknowledgeNotification>.NativeClassPtr);
			AcknowledgeNotification.NativeFieldInfoPtr_NotificationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcknowledgeNotification>.NativeClassPtr, "NotificationID");
			AcknowledgeNotification.NativeMethodInfoPtr__ctor_Public_Void_NotificationID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeNotification>.NativeClassPtr, 100665661);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00053CD8 File Offset: 0x00051ED8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcknowledgeNotification(NotificationID notificationID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcknowledgeNotification>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notificationID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcknowledgeNotification.NativeMethodInfoPtr__ctor_Public_Void_NotificationID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000078AB File Offset: 0x00005AAB
		public AcknowledgeNotification(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00053D24 File Offset: 0x00051F24
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x000078B4 File Offset: 0x00005AB4
		public unsafe NotificationID NotificationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcknowledgeNotification.NativeFieldInfoPtr_NotificationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcknowledgeNotification.NativeFieldInfoPtr_NotificationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeFieldInfoPtr_NotificationID;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NotificationID_0;
	}
}
