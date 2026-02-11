using System;
using Canis.utils;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using dwd.core.notifications.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Networking;

namespace platformCore.notifications
{
	// Token: 0x0200000D RID: 13
	public class PlatformNotificationsSource : VersionedModel
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00004748 File Offset: 0x00002948
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformNotificationsSource()
		{
			Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.notifications", "PlatformNotificationsSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr);
			PlatformNotificationsSource.NativeFieldInfoPtr_writableAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "writableAll");
			PlatformNotificationsSource.NativeFieldInfoPtr_processedNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "processedNotifications");
			PlatformNotificationsSource.NativeFieldInfoPtr_readonlyAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "readonlyAll");
			PlatformNotificationsSource.NativeFieldInfoPtr_autoAcknowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "autoAcknowledge");
			PlatformNotificationsSource.NativeFieldInfoPtr_executor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "executor");
			PlatformNotificationsSource.NativeFieldInfoPtr_NotificationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "NotificationURL");
			PlatformNotificationsSource.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "Client");
			PlatformNotificationsSource.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "loading");
			PlatformNotificationsSource.NativeFieldInfoPtr__RequestError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "<RequestError>k__BackingField");
			PlatformNotificationsSource.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "<Initialized>k__BackingField");
			PlatformNotificationsSource.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663355);
			PlatformNotificationsSource.NativeMethodInfoPtr__ctor_Public_Void_String_Predicate_1_Notification_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663356);
			PlatformNotificationsSource.NativeMethodInfoPtr_get_All_Public_Virtual_Final_New_get_ReadOnlyCollection_1_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663357);
			PlatformNotificationsSource.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663358);
			PlatformNotificationsSource.NativeMethodInfoPtr_set_RequestError_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663359);
			PlatformNotificationsSource.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663360);
			PlatformNotificationsSource.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663361);
			PlatformNotificationsSource.NativeMethodInfoPtr_assertInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663362);
			PlatformNotificationsSource.NativeMethodInfoPtr_postHandle_Protected_Virtual_New_Void_NotificationsRequested_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663363);
			PlatformNotificationsSource.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663364);
			PlatformNotificationsSource.NativeMethodInfoPtr_LongPollForNotifications_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663365);
			PlatformNotificationsSource.NativeMethodInfoPtr_Acknowledge_Public_Virtual_Final_New_Void_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663366);
			PlatformNotificationsSource.NativeMethodInfoPtr_AcknowledgeAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663367);
			PlatformNotificationsSource.NativeMethodInfoPtr_addNotification_Private_Boolean_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663368);
			PlatformNotificationsSource.NativeMethodInfoPtr_handle_Private_Void_NotificationsRequested_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663369);
			PlatformNotificationsSource.NativeMethodInfoPtr_handle_Private_Void_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663370);
			PlatformNotificationsSource.NativeMethodInfoPtr_ALWAYS_AUTO_ACKNOWLEDGE_Public_Static_Boolean_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663371);
			PlatformNotificationsSource.NativeMethodInfoPtr_NEVER_AUTO_ACKNOWLEDGE_Public_Static_Boolean_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663372);
			PlatformNotificationsSource.NativeMethodInfoPtr__Request_b__22_1_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663373);
			PlatformNotificationsSource.NativeMethodInfoPtr__LongPollForNotifications_b__23_1_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, 100663374);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000049D0 File Offset: 0x00002BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250221, XrefRangeEnd = 1250233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotificationsSource(string notificationURL, string client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(notificationURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004A30 File Offset: 0x00002C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250271, RefRangeEnd = 1250272, XrefRangeStart = 1250233, XrefRangeEnd = 1250271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotificationsSource(string notificationURL, Predicate<Notification> autoAcknowledge, string client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(notificationURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(autoAcknowledge);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr__ctor_Public_Void_String_Predicate_1_Notification_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004AA0 File Offset: 0x00002CA0
		public unsafe virtual ReadOnlyCollection<Notification> All
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_get_All_Public_Virtual_Final_New_get_ReadOnlyCollection_1_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Notification>>(intPtr3) : null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00004AE0 File Offset: 0x00002CE0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00004B18 File Offset: 0x00002D18
		public unsafe virtual ErrorInfo RequestError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250272, XrefRangeEnd = 1250273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_set_RequestError_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004B60 File Offset: 0x00002D60
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00004B9C File Offset: 0x00002D9C
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004BDC File Offset: 0x00002DDC
		[CallerCount(0)]
		public unsafe void assertInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_assertInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004C10 File Offset: 0x00002E10
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void postHandle(NotificationsRequested evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformNotificationsSource.NativeMethodInfoPtr_postHandle_Protected_Virtual_New_Void_NotificationsRequested_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004C60 File Offset: 0x00002E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250273, XrefRangeEnd = 1250300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004C94 File Offset: 0x00002E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250300, XrefRangeEnd = 1250305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LongPollForNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_LongPollForNotifications_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004CD4 File Offset: 0x00002ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250305, XrefRangeEnd = 1250349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Acknowledge(Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_Acknowledge_Public_Virtual_Final_New_Void_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004D18 File Offset: 0x00002F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250349, XrefRangeEnd = 1250383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcknowledgeAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_AcknowledgeAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004D4C File Offset: 0x00002F4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1250400, RefRangeEnd = 1250403, XrefRangeStart = 1250383, XrefRangeEnd = 1250400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool addNotification(Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_addNotification_Private_Boolean_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004D9C File Offset: 0x00002F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1250415, RefRangeEnd = 1250417, XrefRangeStart = 1250403, XrefRangeEnd = 1250415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handle(NotificationsRequested evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_handle_Private_Void_NotificationsRequested_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004DE0 File Offset: 0x00002FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250417, XrefRangeEnd = 1250419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handle(Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_handle_Private_Void_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004E24 File Offset: 0x00003024
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ALWAYS_AUTO_ACKNOWLEDGE(Notification notice)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_ALWAYS_AUTO_ACKNOWLEDGE_Public_Static_Boolean_Notification_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004E68 File Offset: 0x00003068
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NEVER_AUTO_ACKNOWLEDGE(Notification notice)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr_NEVER_AUTO_ACKNOWLEDGE_Public_Static_Boolean_Notification_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004EAC File Offset: 0x000030AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250419, XrefRangeEnd = 1250440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Request_b__22_1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr__Request_b__22_1_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004EF0 File Offset: 0x000030F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250440, XrefRangeEnd = 1250451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LongPollForNotifications_b__23_1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.NativeMethodInfoPtr__LongPollForNotifications_b__23_1_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000024C6 File Offset: 0x000006C6
		public PlatformNotificationsSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000024CF File Offset: 0x000006CF
		public unsafe List<Notification> writableAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_writableAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Notification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_writableAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004F64 File Offset: 0x00003164
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000024EE File Offset: 0x000006EE
		public unsafe HashSet<NotificationID> processedNotifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_processedNotifications);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<NotificationID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_processedNotifications), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004F94 File Offset: 0x00003194
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000250D File Offset: 0x0000070D
		public unsafe ReadOnlyCollection<Notification> readonlyAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_readonlyAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Notification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_readonlyAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004FC4 File Offset: 0x000031C4
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000252C File Offset: 0x0000072C
		public unsafe Predicate<Notification> autoAcknowledge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_autoAcknowledge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Notification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_autoAcknowledge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004FF4 File Offset: 0x000031F4
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000254B File Offset: 0x0000074B
		public unsafe CommandExecutor executor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_executor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandExecutor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_executor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00005024 File Offset: 0x00003224
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000256A File Offset: 0x0000076A
		public unsafe string NotificationURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_NotificationURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_NotificationURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000504C File Offset: 0x0000324C
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002589 File Offset: 0x00000789
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00005074 File Offset: 0x00003274
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000025A8 File Offset: 0x000007A8
		public unsafe bool loading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_loading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr_loading)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000509C File Offset: 0x0000329C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000025C3 File Offset: 0x000007C3
		public ErrorInfo _RequestError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr__RequestError_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr__RequestError_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000050CC File Offset: 0x000032CC
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000025F1 File Offset: 0x000007F1
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_writableAll;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_processedNotifications;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_readonlyAll;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_autoAcknowledge;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_executor;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_NotificationURL;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_loading;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__RequestError_k__BackingField;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Predicate_1_Notification_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Virtual_Final_New_get_ReadOnlyCollection_1_Notification_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestError_Private_set_Void_ErrorInfo_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_assertInitialized_Private_Void_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_postHandle_Protected_Virtual_New_Void_NotificationsRequested_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_LongPollForNotifications_Public_IEnumerator_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Acknowledge_Public_Virtual_Final_New_Void_Notification_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_AcknowledgeAll_Public_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_addNotification_Private_Boolean_Notification_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_handle_Private_Void_NotificationsRequested_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_handle_Private_Void_Notification_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_ALWAYS_AUTO_ACKNOWLEDGE_Public_Static_Boolean_Notification_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_NEVER_AUTO_ACKNOWLEDGE_Public_Static_Boolean_Notification_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__Request_b__22_1_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__LongPollForNotifications_b__23_1_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x0200001A RID: 26
		[ObfuscatedName("platformCore.notifications.PlatformNotificationsSource+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000150 RID: 336 RVA: 0x000070F8 File Offset: 0x000052F8
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<PlatformNotificationsSource.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotificationsSource.__O>.NativeClassPtr);
				PlatformNotificationsSource.__O.NativeFieldInfoPtr__0___ALWAYS_AUTO_ACKNOWLEDGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__O>.NativeClassPtr, "<0>__ALWAYS_AUTO_ACKNOWLEDGE");
				PlatformNotificationsSource.__O.NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__O>.NativeClassPtr, "<1>__NEVER_AUTO_ACKNOWLEDGE");
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00002C8F File Offset: 0x00000E8F
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000152 RID: 338 RVA: 0x0000714C File Offset: 0x0000534C
			// (set) Token: 0x06000153 RID: 339 RVA: 0x00002C98 File Offset: 0x00000E98
			public unsafe static Predicate<Notification> _0___ALWAYS_AUTO_ACKNOWLEDGE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__O.NativeFieldInfoPtr__0___ALWAYS_AUTO_ACKNOWLEDGE, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Notification>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__O.NativeFieldInfoPtr__0___ALWAYS_AUTO_ACKNOWLEDGE, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000154 RID: 340 RVA: 0x00007174 File Offset: 0x00005374
			// (set) Token: 0x06000155 RID: 341 RVA: 0x00002CAA File Offset: 0x00000EAA
			public unsafe static Predicate<Notification> _1___NEVER_AUTO_ACKNOWLEDGE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__O.NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Notification>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__O.NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000C5 RID: 197
			private static readonly IntPtr NativeFieldInfoPtr__0___ALWAYS_AUTO_ACKNOWLEDGE;

			// Token: 0x040000C6 RID: 198
			private static readonly IntPtr NativeFieldInfoPtr__1___NEVER_AUTO_ACKNOWLEDGE;
		}

		// Token: 0x0200001B RID: 27
		[ObfuscatedName("platformCore.notifications.PlatformNotificationsSource+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000156 RID: 342 RVA: 0x0000719C File Offset: 0x0000539C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr);
				PlatformNotificationsSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, "<>9");
				PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, "<>9__22_0");
				PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, "<>9__23_0");
				PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__23_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, "<>9__23_2");
				PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, "<>9__24_0");
				PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, "<>9__25_0");
				PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, "<>9__26_0");
				PlatformNotificationsSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, 100663376);
				PlatformNotificationsSource.__c.NativeMethodInfoPtr__Request_b__22_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, 100663377);
				PlatformNotificationsSource.__c.NativeMethodInfoPtr__LongPollForNotifications_b__23_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, 100663378);
				PlatformNotificationsSource.__c.NativeMethodInfoPtr__LongPollForNotifications_b__23_2_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, 100663379);
				PlatformNotificationsSource.__c.NativeMethodInfoPtr__Acknowledge_b__24_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, 100663380);
				PlatformNotificationsSource.__c.NativeMethodInfoPtr__AcknowledgeAll_b__25_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, 100663381);
				PlatformNotificationsSource.__c.NativeMethodInfoPtr__addNotification_b__26_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr, 100663382);
			}

			// Token: 0x06000157 RID: 343 RVA: 0x000072E0 File Offset: 0x000054E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotificationsSource.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000158 RID: 344 RVA: 0x0000731C File Offset: 0x0000551C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250137, XrefRangeEnd = 1250145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Request_b__22_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c.NativeMethodInfoPtr__Request_b__22_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00007360 File Offset: 0x00005560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250145, XrefRangeEnd = 1250153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LongPollForNotifications_b__23_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c.NativeMethodInfoPtr__LongPollForNotifications_b__23_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015A RID: 346 RVA: 0x000073A4 File Offset: 0x000055A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250153, XrefRangeEnd = 1250167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LongPollForNotifications_b__23_2(ErrorInfo status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(status));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c.NativeMethodInfoPtr__LongPollForNotifications_b__23_2_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015B RID: 347 RVA: 0x000073EC File Offset: 0x000055EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250167, XrefRangeEnd = 1250175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Acknowledge_b__24_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c.NativeMethodInfoPtr__Acknowledge_b__24_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00007430 File Offset: 0x00005630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250175, XrefRangeEnd = 1250183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AcknowledgeAll_b__25_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c.NativeMethodInfoPtr__AcknowledgeAll_b__25_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00007474 File Offset: 0x00005674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250183, XrefRangeEnd = 1250191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _addNotification_b__26_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c.NativeMethodInfoPtr__addNotification_b__26_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00002CBC File Offset: 0x00000EBC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600015F RID: 351 RVA: 0x000074B8 File Offset: 0x000056B8
			// (set) Token: 0x06000160 RID: 352 RVA: 0x00002CC5 File Offset: 0x00000EC5
			public unsafe static PlatformNotificationsSource.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformNotificationsSource.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000161 RID: 353 RVA: 0x000074E0 File Offset: 0x000056E0
			// (set) Token: 0x06000162 RID: 354 RVA: 0x00002CD7 File Offset: 0x00000ED7
			public unsafe static Action<UnityWebRequest> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000163 RID: 355 RVA: 0x00007508 File Offset: 0x00005708
			// (set) Token: 0x06000164 RID: 356 RVA: 0x00002CE9 File Offset: 0x00000EE9
			public unsafe static Action<UnityWebRequest> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000165 RID: 357 RVA: 0x00007530 File Offset: 0x00005730
			// (set) Token: 0x06000166 RID: 358 RVA: 0x00002CFB File Offset: 0x00000EFB
			public unsafe static Action<ErrorInfo> __9__23_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__23_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__23_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000167 RID: 359 RVA: 0x00007558 File Offset: 0x00005758
			// (set) Token: 0x06000168 RID: 360 RVA: 0x00002D0D File Offset: 0x00000F0D
			public unsafe static Action<UnityWebRequest> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000169 RID: 361 RVA: 0x00007580 File Offset: 0x00005780
			// (set) Token: 0x0600016A RID: 362 RVA: 0x00002D1F File Offset: 0x00000F1F
			public unsafe static Action<UnityWebRequest> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600016B RID: 363 RVA: 0x000075A8 File Offset: 0x000057A8
			// (set) Token: 0x0600016C RID: 364 RVA: 0x00002D31 File Offset: 0x00000F31
			public unsafe static Action<UnityWebRequest> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformNotificationsSource.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000C7 RID: 199
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000C8 RID: 200
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x040000C9 RID: 201
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x040000CA RID: 202
			private static readonly IntPtr NativeFieldInfoPtr___9__23_2;

			// Token: 0x040000CB RID: 203
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x040000CC RID: 204
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x040000CD RID: 205
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x040000CE RID: 206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000CF RID: 207
			private static readonly IntPtr NativeMethodInfoPtr__Request_b__22_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x040000D0 RID: 208
			private static readonly IntPtr NativeMethodInfoPtr__LongPollForNotifications_b__23_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x040000D1 RID: 209
			private static readonly IntPtr NativeMethodInfoPtr__LongPollForNotifications_b__23_2_Internal_Void_ErrorInfo_0;

			// Token: 0x040000D2 RID: 210
			private static readonly IntPtr NativeMethodInfoPtr__Acknowledge_b__24_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x040000D3 RID: 211
			private static readonly IntPtr NativeMethodInfoPtr__AcknowledgeAll_b__25_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x040000D4 RID: 212
			private static readonly IntPtr NativeMethodInfoPtr__addNotification_b__26_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x0200001C RID: 28
		[ObfuscatedName("platformCore.notifications.PlatformNotificationsSource+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x0600016D RID: 365 RVA: 0x000075D0 File Offset: 0x000057D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<PlatformNotificationsSource.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotificationsSource.__c__DisplayClass22_0>.NativeClassPtr);
				PlatformNotificationsSource.__c__DisplayClass22_0.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c__DisplayClass22_0>.NativeClassPtr, "url");
				PlatformNotificationsSource.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				PlatformNotificationsSource.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c__DisplayClass22_0>.NativeClassPtr, 100663383);
				PlatformNotificationsSource.__c__DisplayClass22_0.NativeMethodInfoPtr__Request_b__2_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource.__c__DisplayClass22_0>.NativeClassPtr, 100663384);
			}

			// Token: 0x0600016E RID: 366 RVA: 0x0000764C File Offset: 0x0000584C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotificationsSource.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016F RID: 367 RVA: 0x00007688 File Offset: 0x00005888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250191, XrefRangeEnd = 1250202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Request_b__2(ErrorInfo status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(status));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource.__c__DisplayClass22_0.NativeMethodInfoPtr__Request_b__2_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000170 RID: 368 RVA: 0x00002D43 File Offset: 0x00000F43
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x06000171 RID: 369 RVA: 0x000076D0 File Offset: 0x000058D0
			// (set) Token: 0x06000172 RID: 370 RVA: 0x00002D4C File Offset: 0x00000F4C
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.__c__DisplayClass22_0.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.__c__DisplayClass22_0.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000173 RID: 371 RVA: 0x000076F8 File Offset: 0x000058F8
			// (set) Token: 0x06000174 RID: 372 RVA: 0x00002D6B File Offset: 0x00000F6B
			public unsafe PlatformNotificationsSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformNotificationsSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D5 RID: 213
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x040000D6 RID: 214
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000D7 RID: 215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000D8 RID: 216
			private static readonly IntPtr NativeMethodInfoPtr__Request_b__2_Internal_Void_ErrorInfo_0;
		}

		// Token: 0x0200001D RID: 29
		[ObfuscatedName("platformCore.notifications.PlatformNotificationsSource+<LongPollForNotifications>d__23")]
		public sealed class _LongPollForNotifications_d__23 : Object
		{
			// Token: 0x06000175 RID: 373 RVA: 0x00007728 File Offset: 0x00005928
			// Note: this type is marked as 'beforefieldinit'.
			static _LongPollForNotifications_d__23()
			{
				Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformNotificationsSource>.NativeClassPtr, "<LongPollForNotifications>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr);
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, "<>1__state");
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, "<>2__current");
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, "<>4__this");
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, 100663385);
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, 100663386);
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, 100663387);
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, 100663388);
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, 100663389);
				PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr, 100663390);
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00007808 File Offset: 0x00005A08
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LongPollForNotifications_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotificationsSource._LongPollForNotifications_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00007850 File Offset: 0x00005A50
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000178 RID: 376 RVA: 0x00007884 File Offset: 0x00005A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250202, XrefRangeEnd = 1250216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000179 RID: 377 RVA: 0x000078C0 File Offset: 0x00005AC0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00007900 File Offset: 0x00005B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250216, XrefRangeEnd = 1250221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x0600017B RID: 379 RVA: 0x00007934 File Offset: 0x00005B34
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00002D8A File Offset: 0x00000F8A
			public _LongPollForNotifications_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600017D RID: 381 RVA: 0x00007974 File Offset: 0x00005B74
			// (set) Token: 0x0600017E RID: 382 RVA: 0x00002D93 File Offset: 0x00000F93
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600017F RID: 383 RVA: 0x0000799C File Offset: 0x00005B9C
			// (set) Token: 0x06000180 RID: 384 RVA: 0x00002DAE File Offset: 0x00000FAE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000181 RID: 385 RVA: 0x000079CC File Offset: 0x00005BCC
			// (set) Token: 0x06000182 RID: 386 RVA: 0x00002DCD File Offset: 0x00000FCD
			public unsafe PlatformNotificationsSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformNotificationsSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformNotificationsSource._LongPollForNotifications_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D9 RID: 217
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000DA RID: 218
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000DB RID: 219
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000DC RID: 220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000DD RID: 221
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000DE RID: 222
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000DF RID: 223
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000E0 RID: 224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000E1 RID: 225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
