using System;
using Canis.utils.ids;
using dwd.core.notifications.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.notifications
{
	// Token: 0x0200011C RID: 284
	public sealed class Notifications : MonoBehaviour
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x000537C4 File Offset: 0x000519C4
		// Note: this type is marked as 'beforefieldinit'.
		static Notifications()
		{
			Il2CppClassPointerStore<Notifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.notifications", "Notifications");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Notifications>.NativeClassPtr);
			Notifications.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notifications>.NativeClassPtr, "source");
			Notifications.NativeMethodInfoPtr_SetSource_Public_Void_INotificationsSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665645);
			Notifications.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665646);
			Notifications.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665647);
			Notifications.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665648);
			Notifications.NativeMethodInfoPtr_TryGet_Public_Boolean_NotificationID_byref_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665649);
			Notifications.NativeMethodInfoPtr_TryGet_Public_Boolean_byref_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665650);
			Notifications.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665651);
			Notifications.NativeMethodInfoPtr_Acknowledge_Public_Boolean_NotificationID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665652);
			Notifications.NativeMethodInfoPtr_Acknowledge_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665653);
			Notifications.NativeMethodInfoPtr_Acknowledge_Public_Void_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665654);
			Notifications.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665655);
			Notifications.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications>.NativeClassPtr, 100665656);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000538F8 File Offset: 0x00051AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSource(INotificationsSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_SetSource_Public_Void_INotificationsSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0005393C File Offset: 0x00051B3C
		public unsafe bool Initialized
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 869371, RefRangeEnd = 869376, XrefRangeStart = 869370, XrefRangeEnd = 869371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x00053978 File Offset: 0x00051B78
		public unsafe ErrorInfo RequestError
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869376, XrefRangeEnd = 869385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x000539B0 File Offset: 0x00051BB0
		public unsafe ReadOnlyCollection<Notification> All
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 869389, RefRangeEnd = 869398, XrefRangeStart = 869385, XrefRangeEnd = 869389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Notification>>(intPtr3) : null;
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000539F0 File Offset: 0x00051BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869398, XrefRangeEnd = 869424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGet(NotificationID id, out Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_TryGet_Public_Boolean_NotificationID_byref_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			notice = ((intPtr4 == 0) ? null : new Notification(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00053A60 File Offset: 0x00051C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869424, XrefRangeEnd = 869449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGet<T>(out Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Notifications.MethodInfoStoreGeneric_TryGet_Public_Boolean_byref_Notification_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				notice = ((intPtr4 == 0) ? null : new Notification(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00053AC0 File Offset: 0x00051CC0
		public unsafe ulong Version
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 869453, RefRangeEnd = 869456, XrefRangeStart = 869449, XrefRangeEnd = 869453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00053AFC File Offset: 0x00051CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869474, RefRangeEnd = 869475, XrefRangeStart = 869456, XrefRangeEnd = 869474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Acknowledge(NotificationID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_Acknowledge_Public_Boolean_NotificationID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00053B4C File Offset: 0x00051D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869475, XrefRangeEnd = 869493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Acknowledge(global::Il2CppSystem.Object payload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_Acknowledge_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00053B9C File Offset: 0x00051D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869493, XrefRangeEnd = 869497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Acknowledge(Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_Acknowledge_Public_Void_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00053BE0 File Offset: 0x00051DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869497, XrefRangeEnd = 869501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00053C14 File Offset: 0x00051E14
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Notifications()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Notifications>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00007883 File Offset: 0x00005A83
		public Notifications(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00053C50 File Offset: 0x00051E50
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x0000788C File Offset: 0x00005A8C
		public unsafe INotificationsSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notifications.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INotificationsSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notifications.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Void_INotificationsSource_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_Notification_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_NotificationID_byref_Notification_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_byref_Notification_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_Acknowledge_Public_Boolean_NotificationID_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_Acknowledge_Public_Boolean_Object_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_Acknowledge_Public_Void_Notification_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002C6 RID: 710
		[ObfuscatedName("dwd.core.notifications.Notifications+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600213B RID: 8507 RVA: 0x000951B4 File Offset: 0x000933B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Notifications.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Notifications>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Notifications.__c__DisplayClass12_0>.NativeClassPtr);
				Notifications.__c__DisplayClass12_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notifications.__c__DisplayClass12_0>.NativeClassPtr, "id");
				Notifications.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications.__c__DisplayClass12_0>.NativeClassPtr, 100665657);
				Notifications.__c__DisplayClass12_0.NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications.__c__DisplayClass12_0>.NativeClassPtr, 100665658);
			}

			// Token: 0x0600213C RID: 8508 RVA: 0x0009521C File Offset: 0x0009341C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Notifications.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600213D RID: 8509 RVA: 0x00095258 File Offset: 0x00093458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869365, XrefRangeEnd = 869370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Acknowledge_b__0(Notification x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.__c__DisplayClass12_0.NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600213E RID: 8510 RVA: 0x0000E388 File Offset: 0x0000C588
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x0600213F RID: 8511 RVA: 0x000952A8 File Offset: 0x000934A8
			// (set) Token: 0x06002140 RID: 8512 RVA: 0x0000E391 File Offset: 0x0000C591
			public unsafe NotificationID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notifications.__c__DisplayClass12_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notifications.__c__DisplayClass12_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400170D RID: 5901
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400170E RID: 5902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400170F RID: 5903
			private static readonly IntPtr NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0;
		}

		// Token: 0x020002C7 RID: 711
		[ObfuscatedName("dwd.core.notifications.Notifications+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002141 RID: 8513 RVA: 0x000952D8 File Offset: 0x000934D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<Notifications.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Notifications>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Notifications.__c__DisplayClass13_0>.NativeClassPtr);
				Notifications.__c__DisplayClass13_0.NativeFieldInfoPtr_payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notifications.__c__DisplayClass13_0>.NativeClassPtr, "payload");
				Notifications.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications.__c__DisplayClass13_0>.NativeClassPtr, 100665659);
				Notifications.__c__DisplayClass13_0.NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Notifications.__c__DisplayClass13_0>.NativeClassPtr, 100665660);
			}

			// Token: 0x06002142 RID: 8514 RVA: 0x00095340 File Offset: 0x00093540
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Notifications.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002143 RID: 8515 RVA: 0x0009537C File Offset: 0x0009357C
			[CallerCount(0)]
			public unsafe bool _Acknowledge_b__0(Notification x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Notifications.__c__DisplayClass13_0.NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002144 RID: 8516 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x06002145 RID: 8517 RVA: 0x000953CC File Offset: 0x000935CC
			// (set) Token: 0x06002146 RID: 8518 RVA: 0x0000E3B9 File Offset: 0x0000C5B9
			public unsafe global::Il2CppSystem.Object payload
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notifications.__c__DisplayClass13_0.NativeFieldInfoPtr_payload);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Notifications.__c__DisplayClass13_0.NativeFieldInfoPtr_payload), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001710 RID: 5904
			private static readonly IntPtr NativeFieldInfoPtr_payload;

			// Token: 0x04001711 RID: 5905
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001712 RID: 5906
			private static readonly IntPtr NativeMethodInfoPtr__Acknowledge_b__0_Internal_Boolean_Notification_0;
		}

		// Token: 0x020002C8 RID: 712
		private sealed class MethodInfoStoreGeneric_TryGet_Public_Boolean_byref_Notification_0<T>
		{
			// Token: 0x04001713 RID: 5907
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Notifications.NativeMethodInfoPtr_TryGet_Public_Boolean_byref_Notification_0, Il2CppClassPointerStore<Notifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
