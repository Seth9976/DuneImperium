using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020001D9 RID: 473
	[Serializable]
	public class PlayerEditorConnectionEvents : Object
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x000930DC File Offset: 0x000912DC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEditorConnectionEvents()
		{
			Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerEditorConnectionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr);
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "messageTypeSubscribers");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "connectionEvent");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "disconnectionEvent");
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667801);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667802);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667803);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667804);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00093198 File Offset: 0x00091398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681291, RefRangeEnd = 681292, XrefRangeStart = 681240, XrefRangeEnd = 681291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeMessageIdSubscribers(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000931F8 File Offset: 0x000913F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681328, RefRangeEnd = 681329, XrefRangeStart = 681292, XrefRangeEnd = 681328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Events.UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityEvent<MessageEventArgs>>(intPtr3) : null;
			}
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00093244 File Offset: 0x00091444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681329, XrefRangeEnd = 681348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00093294 File Offset: 0x00091494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681348, XrefRangeEnd = 681369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEditorConnectionEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x0000CC47 File Offset: 0x0000AE47
		public PlayerEditorConnectionEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000932D0 File Offset: 0x000914D0
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public unsafe List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerEditorConnectionEvents.MessageTypeSubscribers>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x00093300 File Offset: 0x00091500
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x0000CC6F File Offset: 0x0000AE6F
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x00093330 File Offset: 0x00091530
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x0000CC8E File Offset: 0x0000AE8E
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeFieldInfoPtr_messageTypeSubscribers;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeFieldInfoPtr_connectionEvent;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeFieldInfoPtr_disconnectionEvent;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000921 RID: 2337
		[Serializable]
		public class MessageEvent : UnityEngine.Events.UnityEvent<MessageEventArgs>
		{
			// Token: 0x06003B4E RID: 15182 RVA: 0x00016388 File Offset: 0x00014588
			// Note: this type is marked as 'beforefieldinit'.
			static MessageEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr, 100667805);
			}

			// Token: 0x06003B4F RID: 15183 RVA: 0x000BE468 File Offset: 0x000BC668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681223, XrefRangeEnd = 681226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B50 RID: 15184 RVA: 0x000163BC File Offset: 0x000145BC
			public MessageEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002D0B RID: 11531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000922 RID: 2338
		[Serializable]
		public class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
		{
			// Token: 0x06003B51 RID: 15185 RVA: 0x000163C5 File Offset: 0x000145C5
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionChangeEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "ConnectionChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr, 100667806);
			}

			// Token: 0x06003B52 RID: 15186 RVA: 0x000BE4A4 File Offset: 0x000BC6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681226, XrefRangeEnd = 681229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionChangeEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B53 RID: 15187 RVA: 0x000163F9 File Offset: 0x000145F9
			public ConnectionChangeEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002D0C RID: 11532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000923 RID: 2339
		[Serializable]
		public class MessageTypeSubscribers : Object
		{
			// Token: 0x06003B54 RID: 15188 RVA: 0x000BE4E0 File Offset: 0x000BC6E0
			// Note: this type is marked as 'beforefieldinit'.
			static MessageTypeSubscribers()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageTypeSubscribers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "m_messageTypeId");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "subscriberCount");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "messageCallback");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100667807);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100667808);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100667809);
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06003B55 RID: 15189 RVA: 0x000BE584 File Offset: 0x000BC784
			// (set) Token: 0x06003B56 RID: 15190 RVA: 0x000BE5C0 File Offset: 0x000BC7C0
			public unsafe Guid MessageTypeId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681229, XrefRangeEnd = 681230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681230, XrefRangeEnd = 681232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003B57 RID: 15191 RVA: 0x000BE600 File Offset: 0x000BC800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681232, XrefRangeEnd = 681240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageTypeSubscribers()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B58 RID: 15192 RVA: 0x00016402 File Offset: 0x00014602
			public MessageTypeSubscribers(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x06003B59 RID: 15193 RVA: 0x000BE63C File Offset: 0x000BC83C
			// (set) Token: 0x06003B5A RID: 15194 RVA: 0x0001640B File Offset: 0x0001460B
			public unsafe string m_messageTypeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06003B5B RID: 15195 RVA: 0x000BE664 File Offset: 0x000BC864
			// (set) Token: 0x06003B5C RID: 15196 RVA: 0x0001642A File Offset: 0x0001462A
			public unsafe int subscriberCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount)) = value;
				}
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06003B5D RID: 15197 RVA: 0x000BE68C File Offset: 0x000BC88C
			// (set) Token: 0x06003B5E RID: 15198 RVA: 0x00016445 File Offset: 0x00014645
			public unsafe PlayerEditorConnectionEvents.MessageEvent messageCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.MessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D0D RID: 11533
			private static readonly IntPtr NativeFieldInfoPtr_m_messageTypeId;

			// Token: 0x04002D0E RID: 11534
			private static readonly IntPtr NativeFieldInfoPtr_subscriberCount;

			// Token: 0x04002D0F RID: 11535
			private static readonly IntPtr NativeFieldInfoPtr_messageCallback;

			// Token: 0x04002D10 RID: 11536
			private static readonly IntPtr NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0;

			// Token: 0x04002D11 RID: 11537
			private static readonly IntPtr NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0;

			// Token: 0x04002D12 RID: 11538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000924 RID: 2340
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06003B5F RID: 15199 RVA: 0x000BE6BC File Offset: 0x000BC8BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100667810);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100667811);
			}

			// Token: 0x06003B60 RID: 15200 RVA: 0x000BE724 File Offset: 0x000BC924
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B61 RID: 15201 RVA: 0x000BE760 File Offset: 0x000BC960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InvokeMessageIdSubscribers_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B62 RID: 15202 RVA: 0x00016464 File Offset: 0x00014664
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x06003B63 RID: 15203 RVA: 0x000BE7B0 File Offset: 0x000BC9B0
			// (set) Token: 0x06003B64 RID: 15204 RVA: 0x0001646D File Offset: 0x0001466D
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002D13 RID: 11539
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002D14 RID: 11540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D15 RID: 11541
			private static readonly IntPtr NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000925 RID: 2341
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06003B65 RID: 15205 RVA: 0x000BE7D8 File Offset: 0x000BC9D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100667812);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100667813);
			}

			// Token: 0x06003B66 RID: 15206 RVA: 0x000BE840 File Offset: 0x000BCA40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B67 RID: 15207 RVA: 0x000BE87C File Offset: 0x000BCA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddAndCreate_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B68 RID: 15208 RVA: 0x00016488 File Offset: 0x00014688
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06003B69 RID: 15209 RVA: 0x000BE8CC File Offset: 0x000BCACC
			// (set) Token: 0x06003B6A RID: 15210 RVA: 0x00016491 File Offset: 0x00014691
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002D16 RID: 11542
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002D17 RID: 11543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D18 RID: 11544
			private static readonly IntPtr NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000926 RID: 2342
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06003B6B RID: 15211 RVA: 0x000BE8F4 File Offset: 0x000BCAF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100667814);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100667815);
			}

			// Token: 0x06003B6C RID: 15212 RVA: 0x000BE95C File Offset: 0x000BCB5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B6D RID: 15213 RVA: 0x000BE998 File Offset: 0x000BCB98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UnregisterManagedCallback_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B6E RID: 15214 RVA: 0x000164AC File Offset: 0x000146AC
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x06003B6F RID: 15215 RVA: 0x000BE9E8 File Offset: 0x000BCBE8
			// (set) Token: 0x06003B70 RID: 15216 RVA: 0x000164B5 File Offset: 0x000146B5
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04002D19 RID: 11545
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04002D1A RID: 11546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D1B RID: 11547
			private static readonly IntPtr NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000927 RID: 2343
		public sealed class <>c__DisplayClass6_0
		{
		}

		// Token: 0x02000928 RID: 2344
		public sealed class <>c__DisplayClass7_0
		{
		}

		// Token: 0x02000929 RID: 2345
		public sealed class <>c__DisplayClass8_0
		{
		}
	}
}
