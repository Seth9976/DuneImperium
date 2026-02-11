using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.notifications.messages.incoming
{
	// Token: 0x02000120 RID: 288
	public class Notification : NetworkMessageEvent
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x00053D90 File Offset: 0x00051F90
		// Note: this type is marked as 'beforefieldinit'.
		static Notification()
		{
			Il2CppClassPointerStore<Notification>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.notifications.messages.incoming", "Notification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Notification>.NativeClassPtr);
			Notification.NativeFieldInfoPtr_NotificationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notification>.NativeClassPtr, "NotificationID");
			Notification.NativeFieldInfoPtr_payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notification>.NativeClassPtr, "payload");
			Notification.NativeFieldInfoPtr_Payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notification>.NativeClassPtr, "Payload");
			Notification.NativeFieldInfoPtr_NotificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notification>.NativeClassPtr, "NotificationType");
			Notification.NativeMethodInfoPtr__ctor_Public_Void_NotificationID_NotificationTypes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notification>.NativeClassPtr, 100665663);
			Notification.NativeMethodInfoPtr_get_RawPayload_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notification>.NativeClassPtr, 100665664);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00053E38 File Offset: 0x00052038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869501, XrefRangeEnd = 869520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Notification(NotificationID notificationID, NotificationTypes notificationType, string payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Notification>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notificationID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notificationType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(payload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notification.NativeMethodInfoPtr__ctor_Public_Void_NotificationID_NotificationTypes_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00053EA4 File Offset: 0x000520A4
		public unsafe string RawPayload
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notification.NativeMethodInfoPtr_get_RawPayload_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00007915 File Offset: 0x00005B15
		public Notification(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00053EDC File Offset: 0x000520DC
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x0000791E File Offset: 0x00005B1E
		public unsafe NotificationID NotificationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_NotificationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_NotificationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00053F0C File Offset: 0x0005210C
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x0000793D File Offset: 0x00005B3D
		public unsafe string payload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_payload);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_payload), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00053F34 File Offset: 0x00052134
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x0000795C File Offset: 0x00005B5C
		public unsafe NetworkMessageEvent Payload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_Payload);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_Payload), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00053F64 File Offset: 0x00052164
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x0000797B File Offset: 0x00005B7B
		public Nullable<NotificationTypes> NotificationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_NotificationType);
				return new Nullable<NotificationTypes>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<NotificationTypes>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notification.NativeFieldInfoPtr_NotificationType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<NotificationTypes>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeFieldInfoPtr_NotificationID;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr_payload;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr_Payload;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr_NotificationType;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NotificationID_NotificationTypes_String_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_get_RawPayload_Public_get_String_0;
	}
}
