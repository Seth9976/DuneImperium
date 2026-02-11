using System;
using Canis.json.events;
using Canis.messages;
using Canis.skirmishScripts;
using dwd.core.notifications;
using dwd.core.notifications.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.game.messages.pbm;
using UnityEngine;

namespace boardgames.notifications
{
	// Token: 0x02000108 RID: 264
	public class DBGNotifications : MonoBehaviour
	{
		// Token: 0x06000BAB RID: 2987 RVA: 0x000426B8 File Offset: 0x000408B8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGNotifications()
		{
			Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.notifications", "DBGNotifications");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr);
			DBGNotifications.NativeFieldInfoPtr_notifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "notifications");
			DBGNotifications.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "current");
			DBGNotifications.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "cachedVersion");
			DBGNotifications.NativeFieldInfoPtr_messageHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "messageHandlers");
			DBGNotifications.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100664993);
			DBGNotifications.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100664994);
			DBGNotifications.NativeMethodInfoPtr_ShowNotifications_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100664995);
			DBGNotifications.NativeMethodInfoPtr_RunMatchFoundFlow_Protected_Virtual_New_IEnumerator_PBMMatchFound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100664996);
			DBGNotifications.NativeMethodInfoPtr_RunGameCompleteNotificationCommand_Protected_Virtual_New_IEnumerator_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100664997);
			DBGNotifications.NativeMethodInfoPtr_AcknowledgeNotification_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100664998);
			DBGNotifications.NativeMethodInfoPtr_SetMessageHandler_Public_Virtual_Final_New_Void_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100664999);
			DBGNotifications.NativeMethodInfoPtr_HandleNotification_Protected_IEnumerator_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100665000);
			DBGNotifications.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, 100665001);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000427EC File Offset: 0x000409EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509033, XrefRangeEnd = 509038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0004282C File Offset: 0x00040A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509038, XrefRangeEnd = 509042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00042860 File Offset: 0x00040A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509042, XrefRangeEnd = 509047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ShowNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGNotifications.NativeMethodInfoPtr_ShowNotifications_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x000428AC File Offset: 0x00040AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509047, XrefRangeEnd = 509052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator RunMatchFoundFlow(PBMMatchFound matchFound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchFound);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGNotifications.NativeMethodInfoPtr_RunMatchFoundFlow_Protected_Virtual_New_IEnumerator_PBMMatchFound_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00042908 File Offset: 0x00040B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509052, XrefRangeEnd = 509057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator RunGameCompleteNotificationCommand(DBGGameResults gameEnded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameEnded);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGNotifications.NativeMethodInfoPtr_RunGameCompleteNotificationCommand_Protected_Virtual_New_IEnumerator_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00042964 File Offset: 0x00040B64
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 509073, RefRangeEnd = 509082, XrefRangeStart = 509057, XrefRangeEnd = 509073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcknowledgeNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.NativeMethodInfoPtr_AcknowledgeNotification_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00042998 File Offset: 0x00040B98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 509100, RefRangeEnd = 509107, XrefRangeStart = 509082, XrefRangeEnd = 509100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMessageHandler<T>(Func<T, IEnumerator> handler) where T : NetworkMessageEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.MethodInfoStoreGeneric_SetMessageHandler_Public_Virtual_Final_New_Void_Func_2_T_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000429DC File Offset: 0x00040BDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509113, RefRangeEnd = 509115, XrefRangeStart = 509107, XrefRangeEnd = 509113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator HandleNotification(Notification notification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notification);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.NativeMethodInfoPtr_HandleNotification_Protected_IEnumerator_Notification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00042A2C File Offset: 0x00040C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509115, XrefRangeEnd = 509123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGNotifications()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000798F File Offset: 0x00005B8F
		public DBGNotifications(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00042A68 File Offset: 0x00040C68
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x00007998 File Offset: 0x00005B98
		public unsafe Notifications notifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_notifications);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Notifications>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_notifications), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00042A98 File Offset: 0x00040C98
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000079B7 File Offset: 0x00005BB7
		public unsafe Notification current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Notification>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00042AC8 File Offset: 0x00040CC8
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x000079D6 File Offset: 0x00005BD6
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00042AF0 File Offset: 0x00040CF0
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x000079F1 File Offset: 0x00005BF1
		public unsafe Dictionary<Type, Func<NetworkMessageEvent, IEnumerator>> messageHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_messageHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Func<NetworkMessageEvent, IEnumerator>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.NativeFieldInfoPtr_messageHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_notifications;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_messageHandlers;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_ShowNotifications_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_RunMatchFoundFlow_Protected_Virtual_New_IEnumerator_PBMMatchFound_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_RunGameCompleteNotificationCommand_Protected_Virtual_New_IEnumerator_DBGGameResults_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_AcknowledgeNotification_Public_Void_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageHandler_Public_Virtual_Final_New_Void_Func_2_T_IEnumerator_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_HandleNotification_Protected_IEnumerator_Notification_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000346 RID: 838
		[ObfuscatedName("boardgames.notifications.DBGNotifications+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600279D RID: 10141 RVA: 0x0009EFB8 File Offset: 0x0009D1B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr);
				DBGNotifications.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, "<>9");
				DBGNotifications.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, "<>9__4_0");
				DBGNotifications.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, "<>9__4_1");
				DBGNotifications.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, "<>9__4_2");
				DBGNotifications.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, "<>9__4_3");
				DBGNotifications.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, "<>9__4_4");
				DBGNotifications.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, 100665003);
				DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_0_Internal_IEnumerator_PBMTurnReady_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, 100665004);
				DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_1_Internal_IEnumerator_PBMGameResigned_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, 100665005);
				DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_2_Internal_IEnumerator_DailyChallengeBadgeEarned_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, 100665006);
				DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_3_Internal_IEnumerator_BanLogout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, 100665007);
				DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_4_Internal_IEnumerator_ReputationUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr, 100665008);
			}

			// Token: 0x0600279E RID: 10142 RVA: 0x0009F0D4 File Offset: 0x0009D2D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600279F RID: 10143 RVA: 0x0009F110 File Offset: 0x0009D310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508773, XrefRangeEnd = 508777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Start_b__4_0(PBMTurnReady message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_0_Internal_IEnumerator_PBMTurnReady_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060027A0 RID: 10144 RVA: 0x0009F160 File Offset: 0x0009D360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508777, XrefRangeEnd = 508781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Start_b__4_1(PBMGameResigned message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_1_Internal_IEnumerator_PBMGameResigned_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060027A1 RID: 10145 RVA: 0x0009F1B0 File Offset: 0x0009D3B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508781, XrefRangeEnd = 508785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Start_b__4_2(DailyChallengeBadgeEarned message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_2_Internal_IEnumerator_DailyChallengeBadgeEarned_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060027A2 RID: 10146 RVA: 0x0009F200 File Offset: 0x0009D400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508785, XrefRangeEnd = 508789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Start_b__4_3(BanLogout _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_3_Internal_IEnumerator_BanLogout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060027A3 RID: 10147 RVA: 0x0009F250 File Offset: 0x0009D450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508789, XrefRangeEnd = 508793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Start_b__4_4(ReputationUpdated message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c.NativeMethodInfoPtr__Start_b__4_4_Internal_IEnumerator_ReputationUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060027A4 RID: 10148 RVA: 0x00014880 File Offset: 0x00012A80
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x060027A5 RID: 10149 RVA: 0x0009F2A0 File Offset: 0x0009D4A0
			// (set) Token: 0x060027A6 RID: 10150 RVA: 0x00014889 File Offset: 0x00012A89
			public unsafe static DBGNotifications.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGNotifications.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGNotifications.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGNotifications.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x060027A7 RID: 10151 RVA: 0x0009F2C8 File Offset: 0x0009D4C8
			// (set) Token: 0x060027A8 RID: 10152 RVA: 0x0001489B File Offset: 0x00012A9B
			public unsafe static Func<PBMTurnReady, IEnumerator> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PBMTurnReady, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x060027A9 RID: 10153 RVA: 0x0009F2F0 File Offset: 0x0009D4F0
			// (set) Token: 0x060027AA RID: 10154 RVA: 0x000148AD File Offset: 0x00012AAD
			public unsafe static Func<PBMGameResigned, IEnumerator> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PBMGameResigned, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x060027AB RID: 10155 RVA: 0x0009F318 File Offset: 0x0009D518
			// (set) Token: 0x060027AC RID: 10156 RVA: 0x000148BF File Offset: 0x00012ABF
			public unsafe static Func<DailyChallengeBadgeEarned, IEnumerator> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DailyChallengeBadgeEarned, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x060027AD RID: 10157 RVA: 0x0009F340 File Offset: 0x0009D540
			// (set) Token: 0x060027AE RID: 10158 RVA: 0x000148D1 File Offset: 0x00012AD1
			public unsafe static Func<BanLogout, IEnumerator> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BanLogout, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x060027AF RID: 10159 RVA: 0x0009F368 File Offset: 0x0009D568
			// (set) Token: 0x060027B0 RID: 10160 RVA: 0x000148E3 File Offset: 0x00012AE3
			public unsafe static Func<ReputationUpdated, IEnumerator> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ReputationUpdated, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGNotifications.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018D7 RID: 6359
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040018D8 RID: 6360
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040018D9 RID: 6361
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040018DA RID: 6362
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x040018DB RID: 6363
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x040018DC RID: 6364
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x040018DD RID: 6365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018DE RID: 6366
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_0_Internal_IEnumerator_PBMTurnReady_0;

			// Token: 0x040018DF RID: 6367
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_1_Internal_IEnumerator_PBMGameResigned_0;

			// Token: 0x040018E0 RID: 6368
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_2_Internal_IEnumerator_DailyChallengeBadgeEarned_0;

			// Token: 0x040018E1 RID: 6369
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_3_Internal_IEnumerator_BanLogout_0;

			// Token: 0x040018E2 RID: 6370
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_4_Internal_IEnumerator_ReputationUpdated_0;
		}

		// Token: 0x02000347 RID: 839
		[ObfuscatedName("boardgames.notifications.DBGNotifications+<>c__DisplayClass10_0`1")]
		public sealed class __c__DisplayClass10_0<T> : global::Il2CppSystem.Object where T : NetworkMessageEvent
		{
			// Token: 0x060027B1 RID: 10161 RVA: 0x0009F390 File Offset: 0x0009D590
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DBGNotifications.__c__DisplayClass10_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "<>c__DisplayClass10_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications.__c__DisplayClass10_0<T>>.NativeClassPtr);
				DBGNotifications.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications.__c__DisplayClass10_0<T>>.NativeClassPtr, "handler");
				DBGNotifications.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c__DisplayClass10_0<T>>.NativeClassPtr, 100665009);
				DBGNotifications.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__SetMessageHandler_b__0_Internal_IEnumerator_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications.__c__DisplayClass10_0<T>>.NativeClassPtr, 100665010);
			}

			// Token: 0x060027B2 RID: 10162 RVA: 0x0009F434 File Offset: 0x0009D634
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications.__c__DisplayClass10_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027B3 RID: 10163 RVA: 0x0009F470 File Offset: 0x0009D670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508793, XrefRangeEnd = 508798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _SetMessageHandler_b__0(NetworkMessageEvent message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications.__c__DisplayClass10_0<T>.NativeMethodInfoPtr__SetMessageHandler_b__0_Internal_IEnumerator_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060027B4 RID: 10164 RVA: 0x000148F5 File Offset: 0x00012AF5
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x060027B5 RID: 10165 RVA: 0x0009F4C0 File Offset: 0x0009D6C0
			// (set) Token: 0x060027B6 RID: 10166 RVA: 0x000148FE File Offset: 0x00012AFE
			public unsafe Func<T, IEnumerator> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications.__c__DisplayClass10_0<T>.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018E3 RID: 6371
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x040018E4 RID: 6372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018E5 RID: 6373
			private static readonly IntPtr NativeMethodInfoPtr__SetMessageHandler_b__0_Internal_IEnumerator_NetworkMessageEvent_0;
		}

		// Token: 0x02000348 RID: 840
		[ObfuscatedName("boardgames.notifications.DBGNotifications+<HandleNotification>d__11")]
		public sealed class _HandleNotification_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x060027B7 RID: 10167 RVA: 0x0009F4F0 File Offset: 0x0009D6F0
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleNotification_d__11()
			{
				Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "<HandleNotification>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr);
				DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, "<>1__state");
				DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, "<>2__current");
				DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, "<>4__this");
				DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr_notification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, "notification");
				DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, "<>7__wrap1");
				DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, 100665011);
				DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, 100665012);
				DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, 100665013);
				DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, 100665014);
				DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, 100665015);
				DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, 100665016);
				DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr, 100665017);
			}

			// Token: 0x060027B8 RID: 10168 RVA: 0x0009F60C File Offset: 0x0009D80C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleNotification_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications._HandleNotification_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027B9 RID: 10169 RVA: 0x0009F654 File Offset: 0x0009D854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508798, XrefRangeEnd = 508803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027BA RID: 10170 RVA: 0x0009F688 File Offset: 0x0009D888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508803, XrefRangeEnd = 508852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060027BB RID: 10171 RVA: 0x0009F6C4 File Offset: 0x0009D8C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 508855, RefRangeEnd = 508856, XrefRangeStart = 508852, XrefRangeEnd = 508855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x060027BC RID: 10172 RVA: 0x0009F6F8 File Offset: 0x0009D8F8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027BD RID: 10173 RVA: 0x0009F738 File Offset: 0x0009D938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508856, XrefRangeEnd = 508861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x060027BE RID: 10174 RVA: 0x0009F76C File Offset: 0x0009D96C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._HandleNotification_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027BF RID: 10175 RVA: 0x0001491D File Offset: 0x00012B1D
			public _HandleNotification_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0009F7AC File Offset: 0x0009D9AC
			// (set) Token: 0x060027C1 RID: 10177 RVA: 0x00014926 File Offset: 0x00012B26
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x060027C2 RID: 10178 RVA: 0x0009F7D4 File Offset: 0x0009D9D4
			// (set) Token: 0x060027C3 RID: 10179 RVA: 0x00014941 File Offset: 0x00012B41
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x060027C4 RID: 10180 RVA: 0x0009F804 File Offset: 0x0009DA04
			// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00014960 File Offset: 0x00012B60
			public unsafe DBGNotifications __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGNotifications>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0009F834 File Offset: 0x0009DA34
			// (set) Token: 0x060027C7 RID: 10183 RVA: 0x0001497F File Offset: 0x00012B7F
			public unsafe Notification notification
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr_notification);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Notification>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr_notification), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0009F864 File Offset: 0x0009DA64
			// (set) Token: 0x060027C9 RID: 10185 RVA: 0x0001499E File Offset: 0x00012B9E
			public Dictionary<Type, Func<NetworkMessageEvent, IEnumerator>>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<Type, Func<NetworkMessageEvent, IEnumerator>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<Type, Func<NetworkMessageEvent, IEnumerator>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._HandleNotification_d__11.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<Type, Func<NetworkMessageEvent, IEnumerator>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040018E6 RID: 6374
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018E7 RID: 6375
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018E8 RID: 6376
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018E9 RID: 6377
			private static readonly IntPtr NativeFieldInfoPtr_notification;

			// Token: 0x040018EA RID: 6378
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040018EB RID: 6379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018EC RID: 6380
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018ED RID: 6381
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018EE RID: 6382
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040018EF RID: 6383
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018F0 RID: 6384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018F1 RID: 6385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000349 RID: 841
		[ObfuscatedName("boardgames.notifications.DBGNotifications+<RunGameCompleteNotificationCommand>d__8")]
		public sealed class _RunGameCompleteNotificationCommand_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x060027CA RID: 10186 RVA: 0x0009F894 File Offset: 0x0009DA94
			// Note: this type is marked as 'beforefieldinit'.
			static _RunGameCompleteNotificationCommand_d__8()
			{
				Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "<RunGameCompleteNotificationCommand>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr);
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, "<>1__state");
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, "<>2__current");
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr_gameEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, "gameEnded");
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, 100665018);
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, 100665019);
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, 100665020);
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, 100665021);
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, 100665022);
				DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr, 100665023);
			}

			// Token: 0x060027CB RID: 10187 RVA: 0x0009F974 File Offset: 0x0009DB74
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunGameCompleteNotificationCommand_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications._RunGameCompleteNotificationCommand_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027CC RID: 10188 RVA: 0x0009F9BC File Offset: 0x0009DBBC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027CD RID: 10189 RVA: 0x0009F9F0 File Offset: 0x0009DBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508861, XrefRangeEnd = 508866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x060027CE RID: 10190 RVA: 0x0009FA2C File Offset: 0x0009DC2C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027CF RID: 10191 RVA: 0x0009FA6C File Offset: 0x0009DC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508866, XrefRangeEnd = 508871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x060027D0 RID: 10192 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027D1 RID: 10193 RVA: 0x000149CC File Offset: 0x00012BCC
			public _RunGameCompleteNotificationCommand_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x060027D2 RID: 10194 RVA: 0x0009FAE0 File Offset: 0x0009DCE0
			// (set) Token: 0x060027D3 RID: 10195 RVA: 0x000149D5 File Offset: 0x00012BD5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x060027D4 RID: 10196 RVA: 0x0009FB08 File Offset: 0x0009DD08
			// (set) Token: 0x060027D5 RID: 10197 RVA: 0x000149F0 File Offset: 0x00012BF0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x060027D6 RID: 10198 RVA: 0x0009FB38 File Offset: 0x0009DD38
			// (set) Token: 0x060027D7 RID: 10199 RVA: 0x00014A0F File Offset: 0x00012C0F
			public unsafe DBGGameResults gameEnded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr_gameEnded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunGameCompleteNotificationCommand_d__8.NativeFieldInfoPtr_gameEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018F2 RID: 6386
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018F3 RID: 6387
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018F4 RID: 6388
			private static readonly IntPtr NativeFieldInfoPtr_gameEnded;

			// Token: 0x040018F5 RID: 6389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018F6 RID: 6390
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018F7 RID: 6391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018F8 RID: 6392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018F9 RID: 6393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018FA RID: 6394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200034A RID: 842
		[ObfuscatedName("boardgames.notifications.DBGNotifications+<RunMatchFoundFlow>d__7")]
		public sealed class _RunMatchFoundFlow_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x060027D8 RID: 10200 RVA: 0x0009FB68 File Offset: 0x0009DD68
			// Note: this type is marked as 'beforefieldinit'.
			static _RunMatchFoundFlow_d__7()
			{
				Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "<RunMatchFoundFlow>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr);
				DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, "<>1__state");
				DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, "<>2__current");
				DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr_matchFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, "matchFound");
				DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, 100665024);
				DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, 100665025);
				DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, 100665026);
				DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, 100665027);
				DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, 100665028);
				DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr, 100665029);
			}

			// Token: 0x060027D9 RID: 10201 RVA: 0x0009FC48 File Offset: 0x0009DE48
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunMatchFoundFlow_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications._RunMatchFoundFlow_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027DA RID: 10202 RVA: 0x0009FC90 File Offset: 0x0009DE90
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027DB RID: 10203 RVA: 0x0009FCC4 File Offset: 0x0009DEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508871, XrefRangeEnd = 508876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x060027DC RID: 10204 RVA: 0x0009FD00 File Offset: 0x0009DF00
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027DD RID: 10205 RVA: 0x0009FD40 File Offset: 0x0009DF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508876, XrefRangeEnd = 508881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x060027DE RID: 10206 RVA: 0x0009FD74 File Offset: 0x0009DF74
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._RunMatchFoundFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027DF RID: 10207 RVA: 0x00014A2E File Offset: 0x00012C2E
			public _RunMatchFoundFlow_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x060027E0 RID: 10208 RVA: 0x0009FDB4 File Offset: 0x0009DFB4
			// (set) Token: 0x060027E1 RID: 10209 RVA: 0x00014A37 File Offset: 0x00012C37
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0009FDDC File Offset: 0x0009DFDC
			// (set) Token: 0x060027E3 RID: 10211 RVA: 0x00014A52 File Offset: 0x00012C52
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0009FE0C File Offset: 0x0009E00C
			// (set) Token: 0x060027E5 RID: 10213 RVA: 0x00014A71 File Offset: 0x00012C71
			public unsafe PBMMatchFound matchFound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr_matchFound);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PBMMatchFound>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._RunMatchFoundFlow_d__7.NativeFieldInfoPtr_matchFound), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018FB RID: 6395
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018FC RID: 6396
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018FD RID: 6397
			private static readonly IntPtr NativeFieldInfoPtr_matchFound;

			// Token: 0x040018FE RID: 6398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018FF RID: 6399
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001900 RID: 6400
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001901 RID: 6401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001902 RID: 6402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001903 RID: 6403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200034B RID: 843
		[ObfuscatedName("boardgames.notifications.DBGNotifications+<ShowNotifications>d__6")]
		public sealed class _ShowNotifications_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x060027E6 RID: 10214 RVA: 0x0009FE3C File Offset: 0x0009E03C
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowNotifications_d__6()
			{
				Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "<ShowNotifications>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr);
				DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, "<>1__state");
				DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, "<>2__current");
				DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, "<>4__this");
				DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, 100665030);
				DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, 100665031);
				DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, 100665032);
				DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, 100665033);
				DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, 100665034);
				DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr, 100665035);
			}

			// Token: 0x060027E7 RID: 10215 RVA: 0x0009FF1C File Offset: 0x0009E11C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowNotifications_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications._ShowNotifications_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027E8 RID: 10216 RVA: 0x0009FF64 File Offset: 0x0009E164
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027E9 RID: 10217 RVA: 0x0009FF98 File Offset: 0x0009E198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508881, XrefRangeEnd = 508900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x060027EA RID: 10218 RVA: 0x0009FFD4 File Offset: 0x0009E1D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027EB RID: 10219 RVA: 0x000A0014 File Offset: 0x0009E214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508900, XrefRangeEnd = 508905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x060027EC RID: 10220 RVA: 0x000A0048 File Offset: 0x0009E248
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._ShowNotifications_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027ED RID: 10221 RVA: 0x00014A90 File Offset: 0x00012C90
			public _ShowNotifications_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x060027EE RID: 10222 RVA: 0x000A0088 File Offset: 0x0009E288
			// (set) Token: 0x060027EF RID: 10223 RVA: 0x00014A99 File Offset: 0x00012C99
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x060027F0 RID: 10224 RVA: 0x000A00B0 File Offset: 0x0009E2B0
			// (set) Token: 0x060027F1 RID: 10225 RVA: 0x00014AB4 File Offset: 0x00012CB4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000A00E0 File Offset: 0x0009E2E0
			// (set) Token: 0x060027F3 RID: 10227 RVA: 0x00014AD3 File Offset: 0x00012CD3
			public unsafe DBGNotifications __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGNotifications>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._ShowNotifications_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001904 RID: 6404
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001905 RID: 6405
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001906 RID: 6406
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001907 RID: 6407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001908 RID: 6408
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001909 RID: 6409
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400190A RID: 6410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400190B RID: 6411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400190C RID: 6412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200034C RID: 844
		[ObfuscatedName("boardgames.notifications.DBGNotifications+<Start>d__4")]
		public sealed class _Start_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x060027F4 RID: 10228 RVA: 0x000A0110 File Offset: 0x0009E310
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__4()
			{
				Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "<Start>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr);
				DBGNotifications._Start_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, "<>1__state");
				DBGNotifications._Start_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, "<>2__current");
				DBGNotifications._Start_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, "<>4__this");
				DBGNotifications._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, 100665036);
				DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, 100665037);
				DBGNotifications._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, 100665038);
				DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, 100665039);
				DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, 100665040);
				DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr, 100665041);
			}

			// Token: 0x060027F5 RID: 10229 RVA: 0x000A01F0 File Offset: 0x0009E3F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGNotifications._Start_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027F6 RID: 10230 RVA: 0x000A0238 File Offset: 0x0009E438
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027F7 RID: 10231 RVA: 0x000A026C File Offset: 0x0009E46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508905, XrefRangeEnd = 509028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x060027F8 RID: 10232 RVA: 0x000A02A8 File Offset: 0x0009E4A8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027F9 RID: 10233 RVA: 0x000A02E8 File Offset: 0x0009E4E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509028, XrefRangeEnd = 509033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x060027FA RID: 10234 RVA: 0x000A031C File Offset: 0x0009E51C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGNotifications._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027FB RID: 10235 RVA: 0x00014AF2 File Offset: 0x00012CF2
			public _Start_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x060027FC RID: 10236 RVA: 0x000A035C File Offset: 0x0009E55C
			// (set) Token: 0x060027FD RID: 10237 RVA: 0x00014AFB File Offset: 0x00012CFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._Start_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._Start_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x060027FE RID: 10238 RVA: 0x000A0384 File Offset: 0x0009E584
			// (set) Token: 0x060027FF RID: 10239 RVA: 0x00014B16 File Offset: 0x00012D16
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._Start_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._Start_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06002800 RID: 10240 RVA: 0x000A03B4 File Offset: 0x0009E5B4
			// (set) Token: 0x06002801 RID: 10241 RVA: 0x00014B35 File Offset: 0x00012D35
			public unsafe DBGNotifications __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._Start_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGNotifications>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGNotifications._Start_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400190D RID: 6413
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400190E RID: 6414
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400190F RID: 6415
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001910 RID: 6416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001911 RID: 6417
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001912 RID: 6418
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001913 RID: 6419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001914 RID: 6420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001915 RID: 6421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200034D RID: 845
		private sealed class MethodInfoStoreGeneric_SetMessageHandler_Public_Virtual_Final_New_Void_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x04001916 RID: 6422
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DBGNotifications.NativeMethodInfoPtr_SetMessageHandler_Public_Virtual_Final_New_Void_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
