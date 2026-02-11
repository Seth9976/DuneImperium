using System;
using Canis.json.events;
using Canis.utils.ids;
using dwd.core;
using dwd.core.notifications.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using NativeWebSocket;
using platform.websocket;
using UnityEngine;

namespace boardgames.notifications.socket
{
	// Token: 0x02000116 RID: 278
	public class SocketNotificationsProvider : MonoBehaviour
	{
		// Token: 0x06000E79 RID: 3705 RVA: 0x0003CE60 File Offset: 0x0003B060
		// Note: this type is marked as 'beforefieldinit'.
		static SocketNotificationsProvider()
		{
			Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.notifications.socket", "SocketNotificationsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr);
			SocketNotificationsProvider.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "socket");
			SocketNotificationsProvider.NativeFieldInfoPtr_messagesToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "messagesToProcess");
			SocketNotificationsProvider.NativeFieldInfoPtr_ackQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "ackQueue");
			SocketNotificationsProvider.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "all");
			SocketNotificationsProvider.NativeFieldInfoPtr_tryReconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "tryReconnect");
			SocketNotificationsProvider.NativeFieldInfoPtr_reconnectAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "reconnectAttempts");
			SocketNotificationsProvider.NativeFieldInfoPtr_QuickReconnectAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "QuickReconnectAttempts");
			SocketNotificationsProvider.NativeFieldInfoPtr__RequestError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "<RequestError>k__BackingField");
			SocketNotificationsProvider.NativeFieldInfoPtr__All_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "<All>k__BackingField");
			SocketNotificationsProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665353);
			SocketNotificationsProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665354);
			SocketNotificationsProvider.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665355);
			SocketNotificationsProvider.NativeMethodInfoPtr_set_RequestError_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665356);
			SocketNotificationsProvider.NativeMethodInfoPtr_get_All_Public_Virtual_Final_New_get_ReadOnlyCollection_1_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665357);
			SocketNotificationsProvider.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665358);
			SocketNotificationsProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665359);
			SocketNotificationsProvider.NativeMethodInfoPtr_Acknowledge_Public_Virtual_Final_New_Void_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665360);
			SocketNotificationsProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665361);
			SocketNotificationsProvider.NativeMethodInfoPtr_RequestData_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665362);
			SocketNotificationsProvider.NativeMethodInfoPtr_Disconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665363);
			SocketNotificationsProvider.NativeMethodInfoPtr_OnConnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665364);
			SocketNotificationsProvider.NativeMethodInfoPtr_DeserializeMessage_Private_NetworkMessageEvent_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665365);
			SocketNotificationsProvider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665366);
			SocketNotificationsProvider.NativeMethodInfoPtr_AttemptReconnect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665367);
			SocketNotificationsProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665368);
			SocketNotificationsProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665369);
			SocketNotificationsProvider.NativeMethodInfoPtr__RequestData_b__22_0_Private_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665370);
			SocketNotificationsProvider.NativeMethodInfoPtr__RequestData_b__22_1_Private_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665371);
			SocketNotificationsProvider.NativeMethodInfoPtr__RequestData_b__22_2_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665372);
			SocketNotificationsProvider.NativeMethodInfoPtr__AttemptReconnect_b__27_0_Private_Task_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, 100665373);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996435, XrefRangeEnd = 996436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0003D124 File Offset: 0x0003B324
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996436, XrefRangeEnd = 996437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0003D160 File Offset: 0x0003B360
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x0003D198 File Offset: 0x0003B398
		public unsafe virtual ErrorInfo RequestError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_set_RequestError_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x0003D220 File Offset: 0x0003B420
		public unsafe virtual ReadOnlyCollection<Notification> All
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_get_All_Public_Virtual_Final_New_get_ReadOnlyCollection_1_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Notification>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0003D264 File Offset: 0x0003B464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996437, XrefRangeEnd = 996444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0003D298 File Offset: 0x0003B498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996444, XrefRangeEnd = 996464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Acknowledge(Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_Acknowledge_Public_Virtual_Final_New_Void_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0003D2DC File Offset: 0x0003B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996464, XrefRangeEnd = 996474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0003D310 File Offset: 0x0003B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996474, XrefRangeEnd = 996484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task RequestData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_RequestData_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0003D350 File Offset: 0x0003B550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 996494, RefRangeEnd = 996497, XrefRangeStart = 996484, XrefRangeEnd = 996494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_Disconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0003D384 File Offset: 0x0003B584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996555, RefRangeEnd = 996556, XrefRangeStart = 996497, XrefRangeEnd = 996555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_OnConnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0003D3B8 File Offset: 0x0003B5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996556, XrefRangeEnd = 996585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkMessageEvent DeserializeMessage(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_DeserializeMessage_Private_NetworkMessageEvent_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0003D408 File Offset: 0x0003B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996585, XrefRangeEnd = 996669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0003D43C File Offset: 0x0003B63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996669, XrefRangeEnd = 996674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AttemptReconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_AttemptReconnect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0003D47C File Offset: 0x0003B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996674, XrefRangeEnd = 996675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996675, XrefRangeEnd = 996702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketNotificationsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0003D4EC File Offset: 0x0003B6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996702, XrefRangeEnd = 996708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RequestData_b__22_0(global::Il2CppSystem.Object _, string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr__RequestData_b__22_0_Private_Void_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0003D540 File Offset: 0x0003B740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483004, RefRangeEnd = 483006, XrefRangeStart = 483004, XrefRangeEnd = 483006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RequestData_b__22_1(global::Il2CppSystem.Object _, int _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr__RequestData_b__22_1_Private_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0003D590 File Offset: 0x0003B790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996708, XrefRangeEnd = 996709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RequestData_b__22_2(global::Il2CppSystem.Object _, EventArgs _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr__RequestData_b__22_2_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0003D5E4 File Offset: 0x0003B7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996709, XrefRangeEnd = 996713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebSocketCloseCode> _AttemptReconnect_b__27_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.NativeMethodInfoPtr__AttemptReconnect_b__27_0_Private_Task_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebSocketCloseCode>>(intPtr3) : null;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00008C79 File Offset: 0x00006E79
		public SocketNotificationsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0003D624 File Offset: 0x0003B824
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00008C82 File Offset: 0x00006E82
		public unsafe DWDWebSocket<NetworkMessageEvent> socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<NetworkMessageEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0003D654 File Offset: 0x0003B854
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00008CA1 File Offset: 0x00006EA1
		public unsafe List<NetworkMessageEvent> messagesToProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_messagesToProcess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NetworkMessageEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_messagesToProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0003D684 File Offset: 0x0003B884
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00008CC0 File Offset: 0x00006EC0
		public unsafe Queue<NotificationID> ackQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_ackQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<NotificationID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_ackQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0003D6B4 File Offset: 0x0003B8B4
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x00008CDF File Offset: 0x00006EDF
		public unsafe VersionedList<Notification> all
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_all);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<Notification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_all), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0003D6E4 File Offset: 0x0003B8E4
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x00008CFE File Offset: 0x00006EFE
		public unsafe bool tryReconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_tryReconnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_tryReconnect)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0003D70C File Offset: 0x0003B90C
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00008D19 File Offset: 0x00006F19
		public unsafe int reconnectAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_reconnectAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr_reconnectAttempts)) = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0003D734 File Offset: 0x0003B934
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x00008D34 File Offset: 0x00006F34
		public unsafe static int QuickReconnectAttempts
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SocketNotificationsProvider.NativeFieldInfoPtr_QuickReconnectAttempts, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SocketNotificationsProvider.NativeFieldInfoPtr_QuickReconnectAttempts, (void*)(&value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0003D750 File Offset: 0x0003B950
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00008D42 File Offset: 0x00006F42
		public ErrorInfo _RequestError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr__RequestError_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr__RequestError_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0003D780 File Offset: 0x0003B980
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00008D70 File Offset: 0x00006F70
		public unsafe ReadOnlyCollection<Notification> _All_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr__All_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Notification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.NativeFieldInfoPtr__All_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_messagesToProcess;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_ackQueue;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_tryReconnect;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_reconnectAttempts;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_QuickReconnectAttempts;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr__RequestError_k__BackingField;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr__All_k__BackingField;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestError_Private_set_Void_ErrorInfo_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Virtual_Final_New_get_ReadOnlyCollection_1_Notification_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_Notification_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_Acknowledge_Public_Virtual_Final_New_Void_Notification_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_RequestData_Private_Task_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_OnConnect_Private_Void_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMessage_Private_NetworkMessageEvent_Il2CppStructArray_1_Byte_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_AttemptReconnect_Private_IEnumerator_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr__RequestData_b__22_0_Private_Void_Object_String_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr__RequestData_b__22_1_Private_Void_Object_Int32_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr__RequestData_b__22_2_Private_Void_Object_EventArgs_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr__AttemptReconnect_b__27_0_Private_Task_1_WebSocketCloseCode_0;

		// Token: 0x02000257 RID: 599
		[ObfuscatedName("boardgames.notifications.socket.SocketNotificationsProvider+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001B94 RID: 7060 RVA: 0x000662C4 File Offset: 0x000644C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<SocketNotificationsProvider.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketNotificationsProvider.__c__DisplayClass20_0>.NativeClassPtr);
				SocketNotificationsProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_notice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider.__c__DisplayClass20_0>.NativeClassPtr, "notice");
				SocketNotificationsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider.__c__DisplayClass20_0>.NativeClassPtr, 100665374);
				SocketNotificationsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider.__c__DisplayClass20_0>.NativeClassPtr, 100665375);
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x0006632C File Offset: 0x0006452C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketNotificationsProvider.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B96 RID: 7062 RVA: 0x00066368 File Offset: 0x00064568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996322, XrefRangeEnd = 996327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Acknowledge_b__0(Notification n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000823 RID: 2083
			// (get) Token: 0x06001B98 RID: 7064 RVA: 0x000663B8 File Offset: 0x000645B8
			// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0000EEFD File Offset: 0x0000D0FD
			public unsafe Notification notice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_notice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Notification>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_notice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010C1 RID: 4289
			private static readonly IntPtr NativeFieldInfoPtr_notice;

			// Token: 0x040010C2 RID: 4290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010C3 RID: 4291
			private static readonly IntPtr NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0;
		}

		// Token: 0x02000258 RID: 600
		[ObfuscatedName("boardgames.notifications.socket.SocketNotificationsProvider+<AttemptReconnect>d__27")]
		public sealed class _AttemptReconnect_d__27 : global::Il2CppSystem.Object
		{
			// Token: 0x06001B9A RID: 7066 RVA: 0x000663E8 File Offset: 0x000645E8
			// Note: this type is marked as 'beforefieldinit'.
			static _AttemptReconnect_d__27()
			{
				Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "<AttemptReconnect>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr);
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, "<>1__state");
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, "<>2__current");
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, "<>4__this");
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, 100665376);
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, 100665377);
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, 100665378);
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, 100665379);
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, 100665380);
				SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr, 100665381);
			}

			// Token: 0x06001B9B RID: 7067 RVA: 0x000664C8 File Offset: 0x000646C8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AttemptReconnect_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketNotificationsProvider._AttemptReconnect_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B9C RID: 7068 RVA: 0x00066510 File Offset: 0x00064710
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B9D RID: 7069 RVA: 0x00066544 File Offset: 0x00064744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996327, XrefRangeEnd = 996342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00066580 File Offset: 0x00064780
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B9F RID: 7071 RVA: 0x000665C0 File Offset: 0x000647C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996342, XrefRangeEnd = 996347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x000665F4 File Offset: 0x000647F4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._AttemptReconnect_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BA1 RID: 7073 RVA: 0x0000EF1C File Offset: 0x0000D11C
			public _AttemptReconnect_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000824 RID: 2084
			// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00066634 File Offset: 0x00064834
			// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x0000EF25 File Offset: 0x0000D125
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x0006665C File Offset: 0x0006485C
			// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0000EF40 File Offset: 0x0000D140
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0006668C File Offset: 0x0006488C
			// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000EF5F File Offset: 0x0000D15F
			public unsafe SocketNotificationsProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketNotificationsProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._AttemptReconnect_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010C4 RID: 4292
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010C5 RID: 4293
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010C6 RID: 4294
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010C7 RID: 4295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010C8 RID: 4296
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010C9 RID: 4297
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010CA RID: 4298
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010CB RID: 4299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010CC RID: 4300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000259 RID: 601
		[ObfuscatedName("boardgames.notifications.socket.SocketNotificationsProvider+<RequestData>d__22")]
		public sealed class _RequestData_d__22 : ValueType
		{
			// Token: 0x06001BA8 RID: 7080 RVA: 0x000666BC File Offset: 0x000648BC
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestData_d__22()
			{
				Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketNotificationsProvider>.NativeClassPtr, "<RequestData>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr);
				SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr, "<>1__state");
				SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr, "<>t__builder");
				SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr, "<>4__this");
				SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr, "<>u__1");
				SocketNotificationsProvider._RequestData_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr, 100665382);
				SocketNotificationsProvider._RequestData_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr, 100665383);
			}

			// Token: 0x06001BA9 RID: 7081 RVA: 0x00066760 File Offset: 0x00064960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996347, XrefRangeEnd = 996431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._RequestData_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAA RID: 7082 RVA: 0x00066798 File Offset: 0x00064998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996431, XrefRangeEnd = 996435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketNotificationsProvider._RequestData_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BAB RID: 7083 RVA: 0x0000EF7E File Offset: 0x0000D17E
			public _RequestData_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BAC RID: 7084 RVA: 0x0000EF87 File Offset: 0x0000D187
			public _RequestData_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketNotificationsProvider._RequestData_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x06001BAD RID: 7085 RVA: 0x000667E0 File Offset: 0x000649E0
			// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0000EF99 File Offset: 0x0000D199
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00066808 File Offset: 0x00064A08
			// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00066838 File Offset: 0x00064A38
			// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000EFE2 File Offset: 0x0000D1E2
			public unsafe SocketNotificationsProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketNotificationsProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00066868 File Offset: 0x00064A68
			// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0000F001 File Offset: 0x0000D201
			public TaskAwaiter<WebSocketCloseCode> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<WebSocketCloseCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketNotificationsProvider._RequestData_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebSocketCloseCode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040010CD RID: 4301
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010CE RID: 4302
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040010CF RID: 4303
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010D0 RID: 4304
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040010D1 RID: 4305
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010D2 RID: 4306
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
